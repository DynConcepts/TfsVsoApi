using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class IWorkItemRowSetsImpl : IIWorkItemRowSets
    {
        IIRowSet IIWorkItemRowSets.this[IWorkItemRowSetNames name] { get { throw new ToBeImplementedException(); } }
        IIRowSet IIWorkItemRowSets.this[String name] { get { throw new ToBeImplementedException(); } }
        Boolean IIWorkItemRowSets.TryGetRowSet(String name, out IIRowSet rowset) { throw new ToBeImplementedException(); }
    }
}