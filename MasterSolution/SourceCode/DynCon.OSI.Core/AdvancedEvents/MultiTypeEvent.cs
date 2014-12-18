#region Namespace References

using System;
using System.Collections.Generic;
using System.Reflection;

#endregion

namespace DynCon.OSI.Core.AdvancedEvents
{
    /// <summary>
    ///     Class MultiTypeEvent.
    /// </summary>
    public class MultiTypeEvent
    {
        /// <summary>
        ///     Fires the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="data">The data.</param>
        public void Fire(object sender, object data)
        {
            Type eventType = data.GetType();
            MethodInfo actualMethod;
            if (!r_Dispatch.TryGetValue(eventType, out actualMethod))
            {
                MethodInfo baseMethod = GetType().GetMethod("InternalFire", BindingFlags.Instance | BindingFlags.NonPublic);
                actualMethod = baseMethod.MakeGenericMethod(new[] {eventType});
                r_Dispatch.Add(eventType, actualMethod);
            }
            actualMethod.Invoke(this, new[] {sender, data});
        }

        /// <summary>
        ///     Holders this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>GenericEventHolder&lt;T&gt;.</returns>
        public GenericEventHolder<T> Holder<T>() //where T : EventArgs
        {
            GenericEventHolder raw;
            if (r_EventHolders.TryGetValue(typeof (T), out raw)) return (GenericEventHolder<T>) raw;
            raw = new GenericEventHolder<T>();
            r_EventHolders.Add(typeof (T), raw);
            return (GenericEventHolder<T>) raw;
        }

        /// <summary>
        ///     Internals the fire.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender">The sender.</param>
        /// <param name="data">The data.</param>
        private void InternalFire<T>(object sender, T data) // where T : EventArgs
        { Holder<T>().Fire(sender, data); }

        /// <summary>
        ///     The r_ dispatch
        /// </summary>
        private readonly Dictionary<Type, MethodInfo> r_Dispatch = new Dictionary<Type, MethodInfo>();

        /// <summary>
        ///     The r_ event holders
        /// </summary>
        private readonly Dictionary<Type, GenericEventHolder> r_EventHolders = new Dictionary<Type, GenericEventHolder>();
    }
}