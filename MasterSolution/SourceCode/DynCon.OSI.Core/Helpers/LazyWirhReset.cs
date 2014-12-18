using System;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    /// Class LazyWithReset.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LazyWithReset<T>
    {
        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset() { m_Instance = new Lazy<T>(r_ValueFactory); ; }

        /// <summary>
        /// Gets a value indicating whether this instance is value created.
        /// </summary>
        /// <value><c>true</c> if this instance is value created; otherwise, <c>false</c>.</value>
        public bool IsValueCreated { get { return m_Instance.IsValueCreated; } }
        //
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value { get { return m_Instance.Value; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="LazyWithReset{T}"/> class.
        /// </summary>
        /// <param name="valueFactory">The value factory.</param>
        public LazyWithReset(Func<T> valueFactory)
        {
            r_ValueFactory = valueFactory;
            Reset();
        }

        /// <summary>
        /// The m_ instance
        /// </summary>
        private Lazy<T> m_Instance;
        /// <summary>
        /// The r_ value factory
        /// </summary>
        private readonly Func<T> r_ValueFactory;
    }
}