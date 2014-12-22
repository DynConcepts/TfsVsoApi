using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface ICatalogResourceType
    {
        void ToXml(XmlWriter writer, String element);
        String Description { get; }
        String DisplayName { get; }
        Guid Identifier { get; }
    }
}