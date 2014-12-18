using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemCollection : IReadOnlyList
  {
    void Resort();
    Int32 GetId( Int32 index);
    Int32 IndexOf( Int32 id);
    Int32 IndexOf( IWorkItem value);
    Boolean Contains( IWorkItem value);
    DateTime AsOfUTC  { get; set;   }
    DateTime AsOf  { get; set;   }
    Int32 PageSize  { get; set;   }
    Int32 DefaultProjectHint  { get; set;   }
    IWorkItem this[Int32 index] { get;   }
    IQuery Query  { get;   }
    IWorkItemStore Store  { get;   }
    IDisplayFieldList DisplayFields  { get;   }
    ISortFieldList SortFields  { get;   }
  }
}
