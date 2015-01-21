using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    /// <summary>
    ///     Class CoreRestCalls.
    /// </summary>
    internal class CoreRestCalls
    {
        /// <summary>
        ///     Gets the connected services.
        /// </summary>
        /// <value>The connected services.</value>
        internal static CallSpec ConnectedServices { get { return sr_ConnectedServices; } }

        /// <summary>
        ///     Gets the identity MRU.
        /// </summary>
        /// <value>The identity MRU.</value>
        internal static CallSpec IdentityMru { get { return sr_IdentityMru; } }

        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <value>The members.</value>
        internal static CallSpec Members { get { return sr_Members; } }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        internal static CallSpec Projects { get { return sr_Projects; } }

        /// <summary>
        ///     Gets the proxies.
        /// </summary>
        /// <value>The proxies.</value>
        internal static CallSpec Proxies { get { return sr_Proxies; } }

        /// <summary>
        ///     Gets the teams.
        /// </summary>
        /// <value>The teams.</value>
        internal static CallSpec Teams { get { return sr_Teams; } }

        /// <summary>
        ///     The SR_ connected services
        /// </summary>
        private static readonly CallSpec sr_ConnectedServices = new CallSpec("_apis/projects/{projectId}/connectedServices/{name}");

        /// <summary>
        ///     The SR_ identity MRU
        /// </summary>
        private static readonly CallSpec sr_IdentityMru = new CallSpec("_apis/core/identityMru/{mruName}");

        /// <summary>
        ///     The SR_ members
        /// </summary>
        private static readonly CallSpec sr_Members = new CallSpec("_apis/projects/{projectId}/teams/{teamId}/members");

        /// <summary>
        ///     The SR_ projects
        /// </summary>
        private static readonly CallSpec sr_Projects = new CallSpec("_apis/projects");
        private static readonly CallSpec sr_Project = new CallSpec("_apis/projects/{*projectId}");

        /// <summary>
        ///     The SR_ proxies
        /// </summary>
        private static readonly CallSpec sr_Proxies = new CallSpec("_apis/proxies");

        /// <summary>
        ///     The SR_ teams
        /// </summary>
        private static readonly CallSpec sr_Teams = new CallSpec("_apis/projects/{projectId}/teams/{*teamId}");
    }
}