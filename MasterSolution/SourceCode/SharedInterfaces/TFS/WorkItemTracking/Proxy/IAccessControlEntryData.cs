namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IAccessControlEntryData
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Int32 Allow  { get; set;   }
    System.Int32 Deny  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdentityDescriptorData Descriptor  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlEntryExtendedData ExtendedInfo  { get; set;   }
  }
}
