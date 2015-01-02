using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class LocationRestCalls.
    /// </summary>
    internal class LocationRestCalls
    {
        /// <summary>
        ///     Gets the connection data.
        /// </summary>
        /// <value>The connection data.</value>
        internal static CallSpec ConnectionData { get { return sr_ConnectionData; } }

        /// <summary>
        ///     Gets the service definitions.
        /// </summary>
        /// <value>The service definitions.</value>
        internal static CallSpec ServiceDefinitions { get { return sr_ServiceDefinitions; } }

        /// <summary>
        ///     The SR_ connection data
        /// </summary>
        private static readonly CallSpec sr_ConnectionData = new CallSpec("_apis/ConnectionData");

        /// <summary>
        ///     The SR_ service definitions
        /// </summary>
        private static readonly CallSpec sr_ServiceDefinitions = new CallSpec("_apis/ServiceDefinitions/{serviceType}/{identifier}");
    }
}