using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkType
  {
    XmlDocument Export();
    void Delete();
    void Activate();
    void Deactivate();
    IWorkItemLinkTypeEnd ForwardEnd  { get;   }
    IWorkItemLinkTypeEnd ReverseEnd  { get;   }
    String ReferenceName  { get;   }
    Boolean IsDirectional  { get;   }
    Boolean IsNonCircular  { get;   }
    Boolean IsOneToMany  { get;   }
    Boolean IsActive  { get;   }
    Boolean CanDelete  { get;   }
    Boolean CanEdit  { get;   }
    IWorkItemLinkType_Topology LinkTopology  { get;   }
    Boolean IsDeleted  { get;   }
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public enum IWorkItemLinkType_Topology  {
  }
}
