using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IBatchReadParameterCollection : IVariableSizeList
  {
    Int32 Add( IBatchReadParameter item);
    Boolean Contains( Int32 id);
    Int32 IndexOf( IBatchReadParameter item);
    Boolean Contains( IBatchReadParameter item);
    void Remove( IBatchReadParameter item);
    IBatchReadParameter this[Int32 index] { get;   }
  }
}
