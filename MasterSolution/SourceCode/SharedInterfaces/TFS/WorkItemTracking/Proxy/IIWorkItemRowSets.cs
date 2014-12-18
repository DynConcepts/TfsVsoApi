using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIWorkItemRowSets
  {
    Boolean TryGetRowSet( String name,out IIRowSet rowset);
    IIRowSet this[IWorkItemRowSetNames name] { get;   }
    IIRowSet this[String name] { get;   }
  }
}
