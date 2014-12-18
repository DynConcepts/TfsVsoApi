using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkTypeEnd
  {
    IWorkItemLinkType LinkType  { get;   }
    String Name  { get;   }
    String ImmutableName  { get;   }
    Int32 Id  { get;   }
    IWorkItemLinkTypeEnd OppositeEnd  { get;   }
    Boolean IsForwardLink  { get;   }
  }
}
