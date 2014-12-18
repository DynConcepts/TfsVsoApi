using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface ILink
  {
    IBaseLinkType BaseType  { get;   }
    IRegisteredLinkType ArtifactLinkType  { get;   }
    String Comment  { get; set;   }
    Boolean IsLocked  { get; set;   }
    Boolean IsNew  { get;   }
  }
}
