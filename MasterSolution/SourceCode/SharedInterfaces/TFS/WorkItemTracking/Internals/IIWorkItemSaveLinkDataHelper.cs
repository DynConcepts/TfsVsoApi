namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IIWorkItemSaveLinkDataHelper
  {
    void ResetWorkItemLinkInfo();
    void AddWorkItemLinkInfo( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IWorkItemLinkInfo link);
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo> DeletedLinks  { get;   }
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo> AddedLinks  { get;   }
    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo,DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkUpdate>> UpdatedLinks  { get;   }
  }
}
