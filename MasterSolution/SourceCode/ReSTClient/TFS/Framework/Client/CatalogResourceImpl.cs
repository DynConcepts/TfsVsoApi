using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class CatalogResourceImpl : ICatalogResource
    {
        String ICatalogResource.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String ICatalogResource.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Guid ICatalogResource.Identifier { get { throw new ToBeImplementedException(); } }
        ReadOnlyCollection<ICatalogNode> ICatalogResource.NodeReferences { get { throw new ToBeImplementedException(); } }
        IDictionary<String, String> ICatalogResource.Properties { get { throw new ToBeImplementedException(); } }
        ICatalogResourceType ICatalogResource.ResourceType { get { throw new ToBeImplementedException(); } }
        IDictionary<String, IServiceDefinition> ICatalogResource.ServiceReferences { get { throw new ToBeImplementedException(); } }
        void ICatalogResource.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}