using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IIRowSet
  {
    Boolean ContainsColumn( String name);
    void SwapRows( Int32 row1, Int32 row2);
    Int32 RowCount  { get;   }
    Int32 ColumnCount  { get;   }
    String this[Int32 column] { get;   }
    Object this[Int32 column,Int32 row] { get;   }
    Object this[String column,Int32 row] { get;   }
  }
}
