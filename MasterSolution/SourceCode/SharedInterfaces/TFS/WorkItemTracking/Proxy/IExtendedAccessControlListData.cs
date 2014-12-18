namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IExtendedAccessControlListData
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Boolean InheritPermissions  { get; set;   }
    System.Boolean IsEditable  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlListMetadata[] Metadata  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IAccessControlEntryData[] Permissions  { get; set;   }
    System.String Token  { get; set;   }
  }
}
