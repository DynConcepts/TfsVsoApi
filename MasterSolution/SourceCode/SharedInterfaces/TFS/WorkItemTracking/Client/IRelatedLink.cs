namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IRelatedLink : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILink
  {
    System.Int32 RelatedWorkItemId  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd LinkTypeEnd  { get;   }
  }
}
