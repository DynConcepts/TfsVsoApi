using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITfsTeamProjectCollection
    /// </summary>
    public interface ITfsTeamProjectCollection : ITfsConnection
    {
        /// <summary>
        /// Gets the configuration server.
        /// </summary>
        /// <value>The configuration server.</value>
        ITfsConfigurationServer ConfigurationServer { get; }
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; }
        /// <summary>
        /// Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        ITeamFoundationServer TeamFoundationServer { get; }
    }
}