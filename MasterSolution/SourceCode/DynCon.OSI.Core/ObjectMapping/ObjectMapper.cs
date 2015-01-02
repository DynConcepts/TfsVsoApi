using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;

namespace DynCon.OSI.Core.ObjectMapping
{
    /// <summary>
    ///     Class ObjectMapper.
    /// </summary>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    /// <typeparam name="TObjectMode">The type of the t object mode.</typeparam>
    public class ObjectMapper<TInterface, TObjectMode> where TInterface : class
    {
        /// <summary>
        ///     Converts the specified source.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TInterface.</returns>
        public TInterface Convert(TObjectMode src)
        {
            lock (r_SyncRoot)
            {
                WeakReference<TInterface> result;
                if (!r_Map.TryGetValue(src, out result))
                {
                    return CreateWrapper(src);
                }
                TInterface target;
                if (!result.TryGetTarget(out target))
                {
                    r_Map.Remove(src);
                    target = CreateWrapper(src);
                }
                return target;
            }
        }

        /// <summary>
        ///     Converts the specified source.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TObjectMode.</returns>
        public TObjectMode Convert(TInterface src) { return r_ToInstanceFunc(src); }


        /// <summary>
        ///     Purges this instance.
        /// </summary>
        public void Purge()
        {
            lock (r_SyncRoot)
            {
                var list = new List<TObjectMode>();

                foreach (KeyValuePair<TObjectMode, WeakReference<TInterface>> pair in r_Map)
                {
                    TInterface instance;
                    if (!pair.Value.TryGetTarget(out instance))
                    {
                        list.Add(pair.Key);
                    }
                }
                foreach (TObjectMode item in list)
                {
                    try  // TODO: Hack because of occasional throws...probably need ConcurrentDictionary
                    {
                        r_Map.Remove(item);
                    }
                    catch (NullReferenceException)
                    {
                    }
                }
            }
        }

        private object r_SyncRoot = new Object();
        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return r_Map.Count; } }

        /// <summary>
        ///     Gets or sets the purge time.
        /// </summary>
        /// <value>The purge time.</value>
        public TimeSpan PurgeTime { get { return m_PurgeTime; } set { m_PurgeTime = value; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectMapper{TInterface, TObjectMode}" /> class.
        /// </summary>
        /// <param name="toInstanceFunc">To instance function.</param>
        /// <param name="toWrapperFunc">To wrapper function.</param>
        public ObjectMapper(Func<TInterface, TObjectMode> toInstanceFunc, Func<TObjectMode, TInterface> toWrapperFunc)
        {
            r_ToInstanceFunc = toInstanceFunc;
            r_ToWrapperFunc = toWrapperFunc;
        }

        /// <summary>
        ///     Creates the purge task.
        /// </summary>
        private void CreatePurgeTask()
        {
            if (m_PurgeTask != null)
                return;
            m_PurgeTask = TaskHelpers.DeferredAction(PurgeTime, () =>
            {
                Purge();
                m_PurgeTask = null;
                if (r_Map.Count > 0)
                    CreatePurgeTask();
            });
        }

        /// <summary>
        ///     Creates the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TInterface.</returns>
        private TInterface CreateWrapper(TObjectMode src)
        {
            TInterface wrapper = r_ToWrapperFunc(src);
            var result = new WeakReference<TInterface>(wrapper);
            if (r_Map.Count == 0)
            {
                CreatePurgeTask();
            }
            lock (r_SyncRoot)
            {
                r_Map.Add(src, result);
            }
            return wrapper;
        }

        /// <summary>
        ///     The _map
        /// </summary>
        private readonly Dictionary<TObjectMode, WeakReference<TInterface>> r_Map = new Dictionary<TObjectMode, WeakReference<TInterface>>();

        /// <summary>
        ///     The _to instance function
        /// </summary>
        private readonly Func<TInterface, TObjectMode> r_ToInstanceFunc;

        /// <summary>
        ///     The _to wrapper function
        /// </summary>
        private readonly Func<TObjectMode, TInterface> r_ToWrapperFunc;

        /// <summary>
        ///     The _purge task
        /// </summary>
        private Task m_PurgeTask;

        /// <summary>
        ///     The _purge time
        /// </summary>
        private TimeSpan m_PurgeTime = TimeSpan.FromSeconds(10);
    }
}