namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIRowSet
  {
    System.Boolean ContainsColumn( System.String name);
    void SwapRows( System.Int32 row1, System.Int32 row2);
    System.Int32 RowCount  { get;   }
    System.Int32 ColumnCount  { get;   }
    System.String this[System.Int32 column] { get;   }
    System.Object this[System.Int32 column,System.Int32 row] { get;   }
    System.Object this[System.String column,System.Int32 row] { get;   }
  }
}
