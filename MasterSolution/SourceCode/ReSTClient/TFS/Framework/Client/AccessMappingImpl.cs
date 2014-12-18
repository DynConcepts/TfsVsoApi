using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class AccessMappingImpl : IAccessMapping
    {
        String IAccessMapping.AccessPoint { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IAccessMapping.DisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IAccessMapping.Moniker { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IAccessMapping.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}