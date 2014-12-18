using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal partial class ArtifactWorkItemIdsWrapper : ArtifactWorkItemIdsWrapper<IArtifactWorkItemIds, ArtifactWorkItemIds>, IArtifactWorkItemIds, IITfsXmlSerializable
    {
        protected ArtifactWorkItemIdsWrapper(ArtifactWorkItemIds instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IArtifactWorkItemIds, ArtifactWorkItemIds>(src => src==null ? null : ((ArtifactWorkItemIdsWrapper) src).r_Instance, src => new ArtifactWorkItemIdsWrapper(src)); }
    }


    internal class ArtifactWorkItemIdsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IArtifactWorkItemIds where TInterface : class where TWrapper : class
    {

        Int32[] IArtifactWorkItemIds.GetWorkItemIds()
        {
            int[] nativeCallResult = r_Instance.GetWorkItemIds();
            return nativeCallResult;
        }


        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { r_Instance.ReadXml(reader, xmlElement); }


        String IArtifactWorkItemIds.Uri
        {
            get
            {
                string nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        Int32 IArtifactWorkItemIds.UriListOffset
        {
            get
            {
                int nativeCallResult = r_Instance.UriListOffset;
                return nativeCallResult;
            }
            set { r_Instance.UriListOffset = value; }
        }

        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { r_Instance.WriteXml(writer, xmlElement); }
        protected ArtifactWorkItemIdsWrapper(ArtifactWorkItemIds instance) { r_Instance = instance; }
        protected readonly ArtifactWorkItemIds r_Instance;
    }
}