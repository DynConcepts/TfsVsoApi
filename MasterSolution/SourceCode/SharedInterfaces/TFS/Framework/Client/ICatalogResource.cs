using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface ICatalogResource
    {
        void ToXml(XmlWriter writer, String element);
        String Description { get; set; }
        String DisplayName { get; set; }
        Guid Identifier { get; }
        ReadOnlyCollection<ICatalogNode> NodeReferences { get; }
        IDictionary<String, String> Properties { get; }
        ICatalogResourceType ResourceType { get; }
        IDictionary<String, IServiceDefinition> ServiceReferences { get; }
    }
}