using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    ///     Class TaskHelpers.
    /// </summary>
    public static class TaskHelpers
    {
        /// <summary>
        ///     Cancellables the action.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="action">The action.</param>
        /// <returns>CancellationTokenSource.</returns>
        public static CancellationTokenSource CancellableAction(TimeSpan time, Action action)
        {
            var tcs = new CancellationTokenSource();
            var deferredAction = new Task(action, tcs.Token);
            if (time <= TimeSpan.Zero)
            {
                deferredAction.Start();
                return tcs;
            }
            Timer timer = CreateTimer();
            timer.Elapsed += (obj, args) =>
            {
                RemoveTimer(timer);
                timer.Stop();
                switch (deferredAction.Status)
                {
                    case TaskStatus.Created:
                        deferredAction.Start();
                        break;
                    case TaskStatus.Canceled: // We dont want to do it....
                        break;
                    default:
                        throw new Exception("Unexpected Task Status for CancellableAction");
                }
            };
            timer.Interval = time.TotalMilliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs;
        }

        /// <summary>
        ///     Cancellables the delay.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="token">The token.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool CancellableDelay(TimeSpan time, CancellationToken token)
        {
            Task delay = Delay(time);
            try
            {
                delay.Wait(token);
                return false;
            }
            catch (OperationCanceledException)
            {
                // This is OK...it actually means the WAIT was canceled,
                // because the WorkFlow COMPLETED!!!!

                return true;
            }
        }

        /// <summary>
        ///     Deadmans the action.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="action">The action.</param>
        /// <returns>DeadmanHandle.</returns>
        public static DeadmanHandle DeadmanAction(TimeSpan time, Action action) { return new DeadmanHandle(new RetiggerableTimer(time, action)); }

        /// <summary>
        ///     Deferreds the action.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="action">The action.</param>
        /// <returns>Task.</returns>
        public static Task DeferredAction(TimeSpan time, Action action)
        {
            if (time <= TimeSpan.Zero)
            {
                action();
                var deferredAction = new Task(() => { });
                deferredAction.Start();
                return deferredAction;
            }
            var tcs = new TaskCompletionSource<bool>();
            Timer timer = CreateTimer();
            timer.Elapsed += (obj, args) =>
            {
                RemoveTimer(timer);
                action();
                tcs.TrySetResult(true);
            };
            timer.Interval = time.TotalMilliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }

        /// <summary>
        ///     Delays the specified time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>Task.</returns>
        public static Task Delay(TimeSpan time)
        {
            var tcs = new TaskCompletionSource<bool>();
            Timer timer = CreateTimer();
            timer.Elapsed += (obj, args) =>
            {
                RemoveTimer(timer);
                tcs.TrySetResult(true);
            };
            timer.Interval = time.TotalMilliseconds;
            timer.AutoReset = false;
            timer.Start();
            return tcs.Task;
        }

        /// <summary>
        ///     Creates the timer.
        /// </summary>
        /// <returns>Timer.</returns>
        private static Timer CreateTimer()
        {
            var timer = new Timer();
            lock (sr_SyncRoot)
            {
                sr_ActiveTimers.Add(timer);
            }
            return timer;
        }

        /// <summary>
        ///     Removes the timer.
        /// </summary>
        /// <param name="timer">The timer.</param>
        private static void RemoveTimer(Timer timer)
        {
            lock (sr_SyncRoot)
            {
                sr_ActiveTimers.Remove(timer);
            }
        }

        /// <summary>
        ///     The SR_ active timers
        /// </summary>
        private static readonly List<Timer> sr_ActiveTimers = new List<Timer>();

        private static readonly object sr_SyncRoot = new object();

        /// <summary>
        ///     Class DeadmanHandle.
        /// </summary>
        public class DeadmanHandle
        {
            /// <summary>
            ///     Cancels this instance.
            /// </summary>
            public void Cancel() { r_Timer.Cancel(); }

            /// <summary>
            ///     Res the trigger.
            /// </summary>
            public void ReTrigger() { r_Timer.Retrigger(); }

            /// <summary>
            ///     Initializes a new instance of the <see cref="DeadmanHandle" /> class.
            /// </summary>
            /// <param name="timer">The timer.</param>
            public DeadmanHandle(RetiggerableTimer timer) { r_Timer = timer; }

            /// <summary>
            ///     The _timer
            /// </summary>
            private readonly RetiggerableTimer r_Timer;
        }

        /// <summary>
        ///     Class RetiggerableTimer.
        /// </summary>
        public class RetiggerableTimer
        {
            /// <summary>
            ///     Cancels this instance.
            /// </summary>
            public void Cancel()
            {
                if (m_Timer != null)
                {
                    m_Timer.Elapsed -= OnElapsed;
                    m_Timer.Close();
                    m_Timer = null;
                }
            }

            /// <summary>
            ///     Retriggers this instance.
            /// </summary>
            public void Retrigger()
            {
                Cancel();
                m_Timer = CreateTimer();
                m_Timer.Interval = r_Expiration.TotalMilliseconds;
                m_Timer.AutoReset = false;
                m_Timer.Start();
                m_Timer.Elapsed += OnElapsed;
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="RetiggerableTimer" /> class.
            /// </summary>
            /// <param name="expiration">The expiration.</param>
            /// <param name="action">The action.</param>
            public RetiggerableTimer(TimeSpan expiration, Action action)
            {
                r_Expiration = expiration;
                r_Action = action;
                Retrigger();
            }

            /// <summary>
            ///     Handles the <see cref="E:Elapsed" /> event.
            /// </summary>
            /// <param name="obj">The object.</param>
            /// <param name="args">The <see cref="ElapsedEventArgs" /> instance containing the event data.</param>
            private void OnElapsed(object obj, ElapsedEventArgs args)
            {
                RemoveTimer(m_Timer);
                r_Action();
            }

            /// <summary>
            ///     The _action
            /// </summary>
            private readonly Action r_Action;

            /// <summary>
            ///     The _expiration
            /// </summary>
            private readonly TimeSpan r_Expiration;

            /// <summary>
            ///     The _timer
            /// </summary>
            private Timer m_Timer;
        }
    }
}