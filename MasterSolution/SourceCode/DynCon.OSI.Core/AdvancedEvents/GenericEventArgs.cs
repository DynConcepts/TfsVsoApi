
using System;

namespace DynCon.OSI.Core.AdvancedEvents
{
    /// <summary>
    /// Class GenericEventArgs.
    /// </summary>
    public class GenericEventArgs : EventArgs
    {
    }

    /// <summary>
    /// Class GenericEventArgs.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericEventArgs<T> : GenericEventArgs
    {
        /// <summary>
        /// The r_ data
        /// </summary>
        private readonly T r_Data;

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>The data.</value>
        public T Data { get { return r_Data; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericEventArgs{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public GenericEventArgs(T data) { r_Data = data; }
    }
}