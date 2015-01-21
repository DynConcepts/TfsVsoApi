namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Interface IDeepComparer
    /// </summary>
    internal interface IDeepComparer
    {
        /// <summary>
        ///     Processes the specified left value.
        /// </summary>
        /// <param name="leftValue">The left value.</param>
        /// <param name="rightValue">The right value.</param>
        /// <param name="context">The context.</param>
        /// <returns>CompareResults.</returns>
        CompareResults Process(object leftValue, object rightValue, CompareContext context);
    }
}