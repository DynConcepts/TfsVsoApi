namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ILink
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBaseLinkType BaseType  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType ArtifactLinkType  { get;   }
    System.String Comment  { get; set;   }
    System.Boolean IsLocked  { get; set;   }
    System.Boolean IsNew  { get;   }
  }
}
