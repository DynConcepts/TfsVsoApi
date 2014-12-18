using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
  public interface ICatalogResource
  {
    void ToXml( XmlWriter writer, String element);
    Guid Identifier  { get;   }
    String DisplayName  { get; set;   }
    String Description  { get; set;   }
    ICatalogResourceType ResourceType  { get;   }
    IDictionary<String,String> Properties  { get;   }
    IDictionary<String,IServiceDefinition> ServiceReferences  { get;   }
    ReadOnlyCollection<ICatalogNode> NodeReferences  { get;   }
  }
}
