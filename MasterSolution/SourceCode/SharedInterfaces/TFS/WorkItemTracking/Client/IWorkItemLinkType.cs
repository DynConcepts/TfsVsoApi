namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemLinkType
  {
    System.Xml.XmlDocument Export();
    void Delete();
    void Activate();
    void Deactivate();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd ForwardEnd  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeEnd ReverseEnd  { get;   }
    System.String ReferenceName  { get;   }
    System.Boolean IsDirectional  { get;   }
    System.Boolean IsNonCircular  { get;   }
    System.Boolean IsOneToMany  { get;   }
    System.Boolean IsActive  { get;   }
    System.Boolean CanDelete  { get;   }
    System.Boolean CanEdit  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkType_Topology LinkTopology  { get;   }
    System.Boolean IsDeleted  { get;   }
  }
}
namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public enum IWorkItemLinkType_Topology  {
  }
}
