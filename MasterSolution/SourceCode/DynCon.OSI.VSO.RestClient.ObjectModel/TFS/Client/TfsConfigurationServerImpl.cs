using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TfsConfigurationServerImpl.
    /// </summary>
    internal class TfsConfigurationServerImpl : TfsConnectionImpl, ITfsConfigurationServer
    {
        /// <summary>
        ///     Gets the team project collection.
        /// </summary>
        /// <param name="collectionId">The collection identifier.</param>
        /// <returns>ITfsTeamProjectCollection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ITfsTeamProjectCollection ITfsConfigurationServer.GetTeamProjectCollection(Guid collectionId) { throw new ToBeImplementedException(); }
    }
}