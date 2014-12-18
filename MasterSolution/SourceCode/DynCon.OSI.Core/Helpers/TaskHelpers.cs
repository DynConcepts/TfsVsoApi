using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DynCon.OSI.Core
{
    /// <summary>
    /// Class TaskHelpers.
    /// </summary>
    public static class TaskHelpers
    {
        /// <summary>
        /// The SR_ active timers
        /// </summary>
        private static readonly List<Timer> sr_ActiveTimers = new List<Timer>();

        /// <summary>
        /// Delays the specified time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>Task.</returns>
         public static Task Delay(TimeSpan time)
        {
            var tcs = new TaskCompletionSource<bool>();
            var timer = CreateTimer();
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
         /// Removes the timer.
         /// </summary>
         /// <param name="timer">The timer.</param>
        private static void RemoveTimer(Timer timer)
        {
            sr_ActiveTimers.Remove(timer);
        }

        /// <summary>
        /// Creates the timer.
        /// </summary>
        /// <returns>Timer.</returns>
        private static Timer CreateTimer()
        {
            var timer = new Timer();
            sr_ActiveTimers.Add(timer);
            return timer;
        }

        /// <summary>
        /// Cancellables the delay.
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
        /// Deferreds the action.
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
            var timer = CreateTimer();
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
       /// Cancellables the action.
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
           var timer = CreateTimer();
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
       /// Class DeadmanHandle.
       /// </summary>
        public class DeadmanHandle
        {
            /// <summary>
            /// The _timer
            /// </summary>
            private readonly RetiggerableTimer _timer;

            /// <summary>
            /// Initializes a new instance of the <see cref="DeadmanHandle"/> class.
            /// </summary>
            /// <param name="timer">The timer.</param>
            public DeadmanHandle(RetiggerableTimer timer)
            {
                _timer = timer;
            }

            /// <summary>
            /// Res the trigger.
            /// </summary>
            public void ReTrigger()
            {
                _timer.Retrigger();
            }

            /// <summary>
            /// Cancels this instance.
            /// </summary>
            public void Cancel()
            {
                _timer.Cancel();
            }
        }

        /// <summary>
        /// Deadmans the action.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <param name="action">The action.</param>
        /// <returns>DeadmanHandle.</returns>
        public static DeadmanHandle DeadmanAction(TimeSpan time, Action action)
        {
            return new DeadmanHandle(new RetiggerableTimer(time, action));
        }

        /// <summary>
        /// Class RetiggerableTimer.
        /// </summary>
        public class RetiggerableTimer
        {
            /// <summary>
            /// The _expiration
            /// </summary>
            private readonly TimeSpan _expiration;
            /// <summary>
            /// The _action
            /// </summary>
            private readonly Action _action;
            /// <summary>
            /// The _timer
            /// </summary>
            private Timer _timer;

            /// <summary>
            /// Initializes a new instance of the <see cref="RetiggerableTimer"/> class.
            /// </summary>
            /// <param name="expiration">The expiration.</param>
            /// <param name="action">The action.</param>
            public RetiggerableTimer(TimeSpan expiration, Action action)
            {
                _expiration = expiration;
                _action = action;
                Retrigger();
            }

            /// <summary>
            /// Retriggers this instance.
            /// </summary>
            public void Retrigger()
            {
                Cancel();
                _timer = CreateTimer();
                _timer.Interval = _expiration.TotalMilliseconds;
                _timer.AutoReset = false;
                _timer.Start();
                _timer.Elapsed += OnElapsed;
            }

            /// <summary>
            /// Cancels this instance.
            /// </summary>
            public void Cancel()
            {
                if (_timer != null)
                {
                    _timer.Elapsed -= OnElapsed;
                    _timer.Close();
                    _timer = null;
                }
            }

            /// <summary>
            /// Handles the <see cref="E:Elapsed" /> event.
            /// </summary>
            /// <param name="obj">The object.</param>
            /// <param name="args">The <see cref="ElapsedEventArgs"/> instance containing the event data.</param>
            private void OnElapsed(object obj, ElapsedEventArgs args)
            {
                RemoveTimer(_timer);
                _action();
            }
        }
    }
}   