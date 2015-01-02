using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class PropertiesRestCalls.
    /// </summary>
    internal class PropertiesRestCalls
    {
        /// <summary>
        ///     Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        internal static CallSpec Properties { get { return sr_Properties; } }

        /// <summary>
        ///     The SR_ properties
        /// </summary>
        private static readonly CallSpec sr_Properties = new CallSpec("_apis/properties/{id}");
    }
}