using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITfsConfigurationServer
    /// </summary>
    public interface ITfsConfigurationServer : ITfsConnection
    {
        /// <summary>
        /// Gets the team project collection.
        /// </summary>
        /// <param name="collectionId">The collection identifier.</param>
        /// <returns>ITfsTeamProjectCollection.</returns>
        ITfsTeamProjectCollection GetTeamProjectCollection(Guid collectionId);
    }
}