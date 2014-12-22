using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class CatalogResourceTypeImpl : ICatalogResourceType
    {
        String ICatalogResourceType.Description { get { throw new ToBeImplementedException(); } }
        String ICatalogResourceType.DisplayName { get { throw new ToBeImplementedException(); } }
        Guid ICatalogResourceType.Identifier { get { throw new ToBeImplementedException(); } }
        void ICatalogResourceType.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}