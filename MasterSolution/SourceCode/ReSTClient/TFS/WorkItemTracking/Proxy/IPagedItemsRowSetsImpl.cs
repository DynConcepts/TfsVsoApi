using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class IPagedItemsRowSetsImpl : IIPagedItemsRowSets
    {
        IIRowSet IIPagedItemsRowSets.this[IPagedItemsRowSetNames name] { get { throw new ToBeImplementedException(); } }
    }
}