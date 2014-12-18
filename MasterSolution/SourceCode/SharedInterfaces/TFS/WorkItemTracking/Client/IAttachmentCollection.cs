using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IAttachmentCollection : IVariableSizeList
  {
    void Refresh();
    Int32 Add( IAttachment attachment);
    Int32 IndexOf( IAttachment attachment);
    void Remove( IAttachment attachment);
    Boolean Contains( IAttachment attachment);
    IAttachment this[Int32 index] { get;   }
  }
}
