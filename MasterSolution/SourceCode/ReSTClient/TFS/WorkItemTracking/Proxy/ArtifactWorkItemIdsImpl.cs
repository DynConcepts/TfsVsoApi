using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class ArtifactWorkItemIdsImpl : IArtifactWorkItemIds, IITfsXmlSerializable
    {
        Int32[] IArtifactWorkItemIds.GetWorkItemIds() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IArtifactWorkItemIds.Uri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IArtifactWorkItemIds.UriListOffset { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}