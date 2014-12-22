using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IIMetadataRowSets
    {
        Int32 Count { get; }
        IIRowSet this[IMetadataRowSetNames name] { get; }
        IIRowSet this[Int32 index] { get; }
    }
}