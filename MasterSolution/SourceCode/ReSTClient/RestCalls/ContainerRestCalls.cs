using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class ContainerRestCalls.
    /// </summary>
    internal class ContainerRestCalls
    {
        /// <summary>
        ///     Gets the containers.
        /// </summary>
        /// <value>The containers.</value>
        internal static CallSpec Containers { get { return sr_Containers; } }

        /// <summary>
        ///     The SR_ containers
        /// </summary>
        private static readonly CallSpec sr_Containers = new CallSpec("_apis/resources/Containers/{containerId}/{*itemPath}");
    }
}