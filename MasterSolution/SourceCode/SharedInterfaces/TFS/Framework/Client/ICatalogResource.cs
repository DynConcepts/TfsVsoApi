namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogResource
  {
    void ToXml( System.Xml.XmlWriter writer, System.String element);
    System.Guid Identifier  { get;   }
    System.String DisplayName  { get; set;   }
    System.String Description  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogResourceType ResourceType  { get;   }
    System.Collections.Generic.IDictionary<System.String,System.String> Properties  { get;   }
    System.Collections.Generic.IDictionary<System.String,DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IServiceDefinition> ServiceReferences  { get;   }
    System.Collections.ObjectModel.ReadOnlyCollection<DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.ICatalogNode> NodeReferences  { get;   }
  }
}
