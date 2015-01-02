using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class CodelensRestCalls.
    /// </summary>
    internal class CodelensRestCalls
    {
        /// <summary>
        ///     Gets the filedetails.
        /// </summary>
        /// <value>The filedetails.</value>
        internal static CallSpec Filedetails { get { return sr_Filedetails; } }

        /// <summary>
        ///     Gets the filesummaries.
        /// </summary>
        /// <value>The filesummaries.</value>
        internal static CallSpec Filesummaries { get { return sr_Filesummaries; } }

        /// <summary>
        ///     The SR_ filedetails
        /// </summary>
        private static readonly CallSpec sr_Filedetails = new CallSpec("_apis/codelens/filedetails");

        /// <summary>
        ///     The SR_ filesummaries
        /// </summary>
        private static readonly CallSpec sr_Filesummaries = new CallSpec("_apis/codelens/filesummaries");
    }
}