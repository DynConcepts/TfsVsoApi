namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common
{
  public interface IVariableSizeList : System.Collections.IEnumerable ,DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IIVersionTag
  {
    void RemoveAt( System.Int32 index);
    void Clear();
    void CopyTo( System.Array array, System.Int32 index);
    System.Int32 Count  { get;   }
    System.Boolean IsSynchronized  { get;   }
    System.Object SyncRoot  { get;   }
    System.Boolean IsFixedSize  { get;   }
    System.Boolean IsReadOnly  { get;   }
  }
}
