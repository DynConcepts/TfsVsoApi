using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ServerInfoImpl : IServerInfo
    {
        IEnumerable<String> IServerInfo.Features { get { throw new ToBeImplementedException(); } }
        Boolean IServerInfo.IsSupported(String feature) { throw new ToBeImplementedException(); }
    }
}