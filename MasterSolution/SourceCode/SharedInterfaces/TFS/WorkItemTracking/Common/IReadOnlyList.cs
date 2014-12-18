namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common
{
  public interface IReadOnlyList : System.Collections.IEnumerable
  {
    void CopyTo( System.Array array, System.Int32 index);
    System.Int32 Count  { get;   }
    System.Boolean IsSynchronized  { get;   }
    System.Object SyncRoot  { get;   }
    System.Boolean IsFixedSize  { get;   }
    System.Boolean IsReadOnly  { get;   }
  }
}
