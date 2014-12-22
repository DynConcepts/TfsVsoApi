using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class RegisteredLinkTypeImpl : IRegisteredLinkType
    {
        Boolean IRegisteredLinkType.Equals(IRegisteredLinkType type) { throw new ToBeImplementedException(); }
        String IRegisteredLinkType.Name { get { throw new ToBeImplementedException(); } }
    }
}