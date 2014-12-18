namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkTypeEnd
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType LinkType  { get;   }
    System.String Name  { get;   }
    System.String ImmutableName  { get;   }
    System.Int32 Id  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd OppositeEnd  { get;   }
    System.Boolean IsForwardLink  { get;   }
  }
}
