namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class CompoundComparer.
    /// </summary>
    internal class CompoundComparer : IDeepComparer
    {
        /// <summary>
        ///     Processes the specified left value.
        /// </summary>
        /// <param name="leftValue">The left value.</param>
        /// <param name="rightValue">The right value.</param>
        /// <param name="context">The context.</param>
        /// <returns>CompareResults.</returns>
        public CompareResults Process(object leftValue, object rightValue, CompareContext context)
        {
            var instance = new DeepCompare(context);
            CompareResults result = instance.Execute(leftValue, rightValue);
            return result;
        }
    }
}