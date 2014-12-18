using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyRefreshDataImpl : IQueryHierarchyRefreshData
    {
        IQueryHierarchy IQueryHierarchyRefreshData.Hierarchy { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryHierarchyRefreshData.IsLegacy { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ArrayList IQueryHierarchyRefreshData.LegacyQueries { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IRowSetCollection IQueryHierarchyRefreshData.QueriesDataSet { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}