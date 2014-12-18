using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIMetadataRowSets
  {
    IIRowSet this[IMetadataRowSetNames name] { get;   }
    IIRowSet this[Int32 index] { get;   }
    Int32 Count  { get;   }
  }
}
