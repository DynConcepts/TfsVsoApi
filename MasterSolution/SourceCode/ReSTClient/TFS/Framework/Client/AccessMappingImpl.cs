using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class AccessMappingImpl : IAccessMapping
    {
        String IAccessMapping.AccessPoint { get { throw new ToBeImplementedException(); } }
        String IAccessMapping.DisplayName { get { throw new ToBeImplementedException(); } }
        String IAccessMapping.Moniker { get { throw new ToBeImplementedException(); } }
        void IAccessMapping.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}