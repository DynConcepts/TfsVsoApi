using System;
using System.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryHierarchyRefreshData
    {
        IQueryHierarchy Hierarchy { get; }
        Boolean IsLegacy { get; }
        ArrayList LegacyQueries { get; }
        IRowSetCollection QueriesDataSet { get; }
    }
}