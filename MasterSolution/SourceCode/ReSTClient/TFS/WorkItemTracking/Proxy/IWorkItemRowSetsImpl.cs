using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class IWorkItemRowSetsImpl : IIWorkItemRowSets
    {
        IIRowSet IIWorkItemRowSets.this[IWorkItemRowSetNames name] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIRowSet IIWorkItemRowSets.this[String name] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IIWorkItemRowSets.TryGetRowSet(String name, out IIRowSet rowset) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}