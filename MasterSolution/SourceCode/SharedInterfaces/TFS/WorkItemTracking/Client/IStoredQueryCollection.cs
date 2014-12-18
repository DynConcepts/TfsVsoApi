using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IStoredQueryCollection : IVariableSizeList
  {
    Int32 Add( IStoredQuery storedQuery);
    Int32 IndexOf( IStoredQuery storedQuery);
    void Remove( IStoredQuery storedQuery);
    void Refresh();
    IStoredQuery this[Guid guid] { get;   }
    IStoredQuery this[Int32 index] { get;   }
  }
}
