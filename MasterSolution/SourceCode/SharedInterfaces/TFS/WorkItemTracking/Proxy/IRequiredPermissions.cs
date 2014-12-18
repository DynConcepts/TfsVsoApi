namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IRequiredPermissions
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.String PermissionName  { get; set;   }
    System.Int32 RequiredPermissionBits  { get; set;   }
  }
}
