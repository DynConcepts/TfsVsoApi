namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface IWorkItemLinkInfo : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo
  {
    System.Int32 LinkType  { get; set;   }
    System.Int32 SourceId  { get; set;   }
    System.Int32 TargetId  { get; set;   }
    System.Boolean IsLocked  { get; set;   }
  }
}
