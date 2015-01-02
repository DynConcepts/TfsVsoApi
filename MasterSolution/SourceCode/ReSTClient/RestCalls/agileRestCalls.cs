using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class AgileRestCalls.
    /// </summary>
    internal class AgileRestCalls
    {
        /// <summary>
        ///     Gets the backlogs.
        /// </summary>
        /// <value>The backlogs.</value>
        internal static CallSpec Backlogs { get { return sr_Backlogs; } }

        /// <summary>
        ///     The SR_ backlogs
        /// </summary>
        private static readonly CallSpec sr_Backlogs = new CallSpec("_apis/agile/backlogs/{id}");
    }
}