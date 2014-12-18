namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IAccessControlListMetadata
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.String FullSelectionPermission  { get; set;   }
    System.String[] IrrevocableAdminPermissions  { get; set;   }
    System.String ObjectClassId  { get; set;   }
    System.String[] PermissionDescriptions  { get; set;   }
    System.String[] PermissionDisplayStrings  { get; set;   }
    System.String[] PermissionNames  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRequiredPermissions[] PermissionRequirements  { get; set;   }
  }
}
