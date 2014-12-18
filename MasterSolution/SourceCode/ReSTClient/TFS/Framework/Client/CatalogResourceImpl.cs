using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class CatalogResourceImpl : ICatalogResource
    {
        String ICatalogResource.Description { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ICatalogResource.DisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Guid ICatalogResource.Identifier { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ReadOnlyCollection<ICatalogNode> ICatalogResource.NodeReferences { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IDictionary<String, String> ICatalogResource.Properties { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ICatalogResourceType ICatalogResource.ResourceType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IDictionary<String, IServiceDefinition> ICatalogResource.ServiceReferences { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ICatalogResource.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}