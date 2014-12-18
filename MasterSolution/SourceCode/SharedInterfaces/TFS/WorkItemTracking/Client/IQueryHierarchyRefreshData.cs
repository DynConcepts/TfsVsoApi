using System;
using System.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IQueryHierarchyRefreshData
  {
    Boolean IsLegacy  { get;   }
    IQueryHierarchy Hierarchy  { get;   }
    IRowSetCollection QueriesDataSet  { get;   }
    ArrayList LegacyQueries  { get;   }
  }
}
