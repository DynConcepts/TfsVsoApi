using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common
{
  public interface IVariableSizeList : IEnumerable ,IIVersionTag
  {
    void RemoveAt( Int32 index);
    void Clear();
    void CopyTo( Array array, Int32 index);
    Int32 Count  { get;   }
    Boolean IsSynchronized  { get;   }
    Object SyncRoot  { get;   }
    Boolean IsFixedSize  { get;   }
    Boolean IsReadOnly  { get;   }
  }
}
