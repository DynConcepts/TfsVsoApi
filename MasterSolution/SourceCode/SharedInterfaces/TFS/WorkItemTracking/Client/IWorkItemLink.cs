namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLink : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILink
  {
    System.Int32 SourceId  { get; set;   }
    System.Int32 TargetId  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd LinkTypeEnd  { get;   }
    System.DateTime AddedDateUtc  { get;   }
    System.DateTime AddedDate  { get;   }
    System.DateTime RemovedDateUtc  { get;   }
    System.DateTime RemovedDate  { get;   }
    System.String AddedBy  { get;   }
    System.String RemovedBy  { get;   }
    System.Nullable<System.DateTime> ChangedDate  { get; set;   }
  }
}
