using System;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    ///     Interface IParameterizedLazyWithReset
    /// </summary>
    /// <typeparam name="TParam">The type of the t parameter.</typeparam>
    /// <typeparam name="TResult">The type of the t result.</typeparam>
    public interface IParameterizedLazyWithReset<in TParam, out TResult>
    {
        /// <summary>
        ///     Resets this instance.
        /// </summary>
        void Reset();

        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns>TResult.</returns>
        /// <value>The value.</value>
        TResult Value(TParam param);

        /// <summary>
        ///     Gets a value indicating whether this instance is value created.
        /// </summary>
        /// <value><c>true</c> if this instance is value created; otherwise, <c>false</c>.</value>
        bool IsValueCreated { get; }
    }

    /// <summary>
    ///     Class ParameterizedLazyWithReset.
    /// </summary>
    /// <typeparam name="TParam">The type of the t parameter.</typeparam>
    /// <typeparam name="TResult">The type of the t result.</typeparam>
    public class ParameterizedLazyWithReset<TParam, TResult> : IParameterizedLazyWithReset<TParam, TResult>
    {
        /// <summary>
        ///     Resets this instance.
        /// </summary>
        public void Reset() { m_Instance = new Lazy<TResult>(Handler); }

        //
        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <param name="param">The parameter.</param>
        /// <returns>TResult.</returns>
        /// <value>The value.</value>
        public TResult Value(TParam param)
        {
            _param = param;
            return m_Instance.Value;
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is value created.
        /// </summary>
        /// <value><c>true</c> if this instance is value created; otherwise, <c>false</c>.</value>
        public bool IsValueCreated { get { return m_Instance.IsValueCreated; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LazyWithReset{T}" /> class.
        /// </summary>
        /// <param name="valueFactory">The value factory.</param>
        public ParameterizedLazyWithReset(Func<TParam, TResult> valueFactory)
        {
            r_ValueFactory = valueFactory;
            Reset();
        }

        /// <summary>
        ///     Handlers this instance.
        /// </summary>
        /// <returns>TResult.</returns>
        private TResult Handler() { return r_ValueFactory(_param); }

        /// <summary>
        ///     The r_ value factory
        /// </summary>
        private readonly Func<TParam, TResult> r_ValueFactory;

        /// <summary>
        ///     The _param
        /// </summary>
        private TParam _param;

        /// <summary>
        ///     The m_ instance
        /// </summary>
        private Lazy<TResult> m_Instance;
    }
}