namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkData : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveLinkDataHelper
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo GetLinkInfo( System.Int32 index);
    System.Boolean IsDirty();
    System.Int32 GetLinkInfoCount();
    void AddLinkInfo( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, System.Object updatedItem);
    void MarkLinkToDelete( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, System.Object updatedItem);
    System.Collections.Generic.HashSet<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo> GetAddedLinks();
    System.Collections.Generic.HashSet<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo> GetDeletedLinks();
    System.Collections.Generic.Dictionary<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo,DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate> GetUpdatedLinks();
    System.Int32 GetAddedLinksCount();
    System.Int32 GetDeletedLinksCount();
    System.Int32 GetUpdatedLinksCount();
    void SetLinkComment( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo linkInfo, System.String value);
    void Reset();
    void Check();
  }
}
