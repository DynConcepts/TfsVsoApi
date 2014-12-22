namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IIPagedItemsRowSets
    {
        IIRowSet this[IPagedItemsRowSetNames name] { get; }
    }
}