using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkData : IIWorkItemSaveLinkDataHelper
  {
    ILinkInfo GetLinkInfo( Int32 index);
    Boolean IsDirty();
    Int32 GetLinkInfoCount();
    void AddLinkInfo( ILinkInfo linkInfo, Object updatedItem);
    void MarkLinkToDelete( ILinkInfo linkInfo, Object updatedItem);
    HashSet<ILinkInfo> GetAddedLinks();
    HashSet<ILinkInfo> GetDeletedLinks();
    Dictionary<ILinkInfo,ILinkUpdate> GetUpdatedLinks();
    Int32 GetAddedLinksCount();
    Int32 GetDeletedLinksCount();
    Int32 GetUpdatedLinksCount();
    void SetLinkComment( ILinkInfo linkInfo, String value);
    void Reset();
    void Check();
  }
}
