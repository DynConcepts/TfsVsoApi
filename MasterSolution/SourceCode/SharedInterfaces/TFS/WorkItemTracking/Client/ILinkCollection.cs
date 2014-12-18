using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ILinkCollection : IVariableSizeList
  {
    void Refresh();
    Int32 Add( ILink link);
    Int32 Add( IHyperlink link);
    Int32 Add( IExternalLink link);
    Int32 Add( IRelatedLink link);
    Int32 IndexOf( ILink link);
    void Remove( ILink link);
    Boolean Contains( ILink link);
    IWorkItem WorkItem  { get;   }
    ILink this[Int32 index] { get;   }
  }
}
