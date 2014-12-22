using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TfsConfigurationServerImpl : TfsConnectionImpl, ITfsConfigurationServer
    {
        ITfsTeamProjectCollection ITfsConfigurationServer.GetTeamProjectCollection(Guid collectionId) { throw new ToBeImplementedException(); }
    }
}