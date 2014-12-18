using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class RegisteredLinkTypeImpl : IRegisteredLinkType
    {
        Boolean IRegisteredLinkType.Equals(IRegisteredLinkType type) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IRegisteredLinkType.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}