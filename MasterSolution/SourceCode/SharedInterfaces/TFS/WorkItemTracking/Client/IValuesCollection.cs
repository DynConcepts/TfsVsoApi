using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IValuesCollection : IReadOnlyList
  {
    Boolean Contains( String value);
    Int32 IndexOf( String value);
    String this[Int32 index] { get;   }
  }
}
