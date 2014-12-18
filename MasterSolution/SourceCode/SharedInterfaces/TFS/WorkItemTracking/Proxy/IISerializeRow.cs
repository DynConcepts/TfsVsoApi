using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IISerializeRow
  {
    void CopyRow( Int32 row, IntPtr p, Int32 esz);
  }
}
