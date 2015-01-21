using System;
using System.Linq;

namespace DynCon.OSI.VSO.ObjectModelClient.Helpers
{
    /// <summary>
    ///     Class EnumTransform.
    /// </summary>
    /// <typeparam name="TSource">The type of the t source.</typeparam>
    /// <typeparam name="TTarget">The type of the t target.</typeparam>
    internal class EnumTransform<TSource, TTarget>
    {
        /// <summary>
        ///     Changes the specified source.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TTarget.</returns>
        public static TTarget Change(TSource src) { return (TTarget) Enum.Parse(typeof (TTarget), Enum.GetName(typeof (TSource), src)); }

        /// <summary>
        ///     Changes the specified source.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TSource.</returns>
        public static TSource Change(TTarget src) { return (TSource) Enum.Parse(typeof (TTarget), Enum.GetName(typeof (TTarget), src)); }

        /// <summary>
        ///     Changes the specified source.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TTarget[].</returns>
        public static TTarget[] Change(TSource[] src) { return src.Select(Change).ToArray(); }

        /// <summary>
        ///     Changes the specified source.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TSource[].</returns>
        public static TSource[] Change(TTarget[] src) { return src.Select(Change).ToArray(); }
    }
}