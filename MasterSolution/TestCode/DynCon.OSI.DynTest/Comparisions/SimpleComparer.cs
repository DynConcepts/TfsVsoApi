namespace DynCon.OSI.DynTest.Comparisions
{
    internal class SimpleComparer : IDeepComparer
    {
        public CompareResults Process(object leftValue, object rightValue, CompareContext context)
        {
            bool equal = leftValue.Equals(rightValue);
            var retVal = new CompareResults();
            if (!equal) retVal.MarkAsDifferent();
            return retVal;
        }
    }
}