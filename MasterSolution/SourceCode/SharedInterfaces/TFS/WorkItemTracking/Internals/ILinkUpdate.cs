namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
  public interface ILinkUpdate
  {
    void Submit( System.Xml.XmlElement element);
    void Submit( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkInfo li);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.ILinkProperties Mask  { get;   }
    System.String Comment  { get; set;   }
    System.Boolean IsLocked  { get; set;   }
  }
}
