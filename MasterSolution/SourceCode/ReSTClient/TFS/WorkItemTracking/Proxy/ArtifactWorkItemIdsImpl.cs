using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class ArtifactWorkItemIdsImpl : IArtifactWorkItemIds, IITfsXmlSerializable
    {
        Int32[] IArtifactWorkItemIds.GetWorkItemIds() { throw new ToBeImplementedException(); }
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new ToBeImplementedException(); }
        String IArtifactWorkItemIds.Uri { get { throw new ToBeImplementedException(); } }
        Int32 IArtifactWorkItemIds.UriListOffset { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new ToBeImplementedException(); }
    }
}