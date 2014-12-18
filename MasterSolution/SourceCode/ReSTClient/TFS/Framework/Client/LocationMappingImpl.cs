using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class LocationMappingImpl : ILocationMapping
    {
        IAccessMapping ILocationMapping.AccessMapping { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ILocationMapping.Location { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ILocationMapping.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}