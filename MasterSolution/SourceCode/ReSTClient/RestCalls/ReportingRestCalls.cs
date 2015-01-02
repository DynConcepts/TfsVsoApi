using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class ReportingRestCalls.
    /// </summary>
    internal class ReportingRestCalls
    {
        /// <summary>
        ///     Gets the chart configuration.
        /// </summary>
        /// <value>The chart configuration.</value>
        internal static CallSpec ChartConfiguration { get { return sr_ChartConfiguration; } }

        /// <summary>
        ///     Gets the data service capabilities.
        /// </summary>
        /// <value>The data service capabilities.</value>
        internal static CallSpec DataServiceCapabilities { get { return sr_DataServiceCapabilities; } }

        /// <summary>
        ///     Gets the transform query.
        /// </summary>
        /// <value>The transform query.</value>
        internal static CallSpec TransformQuery { get { return sr_TransformQuery; } }

        /// <summary>
        ///     The SR_ chart configuration
        /// </summary>
        private static readonly CallSpec sr_ChartConfiguration = new CallSpec("_apis/Reporting/ChartConfiguration/{id}");

        /// <summary>
        ///     The SR_ data service capabilities
        /// </summary>
        private static readonly CallSpec sr_DataServiceCapabilities = new CallSpec("_apis/Reporting/DataServiceCapabilities/{scope}");

        /// <summary>
        ///     The SR_ transform query
        /// </summary>
        private static readonly CallSpec sr_TransformQuery = new CallSpec("_apis/Reporting/TransformQuery/{scope}");
    }
}