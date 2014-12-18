using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLink : ILink
  {
    Int32 SourceId  { get; set;   }
    Int32 TargetId  { get; set;   }
    IWorkItemLinkTypeEnd LinkTypeEnd  { get;   }
    DateTime AddedDateUtc  { get;   }
    DateTime AddedDate  { get;   }
    DateTime RemovedDateUtc  { get;   }
    DateTime RemovedDate  { get;   }
    String AddedBy  { get;   }
    String RemovedBy  { get;   }
    Nullable<DateTime> ChangedDate  { get; set;   }
  }
}
