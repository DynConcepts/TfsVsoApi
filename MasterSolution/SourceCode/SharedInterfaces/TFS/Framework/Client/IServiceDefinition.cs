namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface IServiceDefinition
  {
    void AddLocationMapping( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping, System.String location);
    System.Boolean RemoveLocationMapping( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ILocationMapping GetLocationMapping( DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IAccessMapping accessMapping);
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.String ServiceType  { get; set;   }
    System.Guid Identifier  { get; set;   }
    System.String DisplayName  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common.IRelativeToSetting RelativeToSetting  { get; set;   }
    System.String RelativePath  { get; set;   }
    System.String Description  { get; set;   }
    System.String ToolType  { get; set;   }
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ILocationMapping> LocationMappings  { get;   }
  }
}
