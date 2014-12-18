using System;
using System.Collections;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeCollectionWrapper : WorkItemLinkTypeCollectionWrapper<IWorkItemLinkTypeCollection, WorkItemLinkTypeCollection>, IWorkItemLinkTypeCollection, IEnumerable
    {
        protected WorkItemLinkTypeCollectionWrapper(WorkItemLinkTypeCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkTypeCollection, WorkItemLinkTypeCollection>(src => ((WorkItemLinkTypeCollectionWrapper) src).r_Instance, src => new WorkItemLinkTypeCollectionWrapper(src)); }
    }


    internal class WorkItemLinkTypeCollectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemLinkTypeCollection where TInterface : class where TWrapper : class
    {

        Boolean IWorkItemLinkTypeCollection.Contains(String linkTypeReferenceName)
        {
            bool nativeCallResult = r_Instance.Contains(linkTypeReferenceName);
            return nativeCallResult;
        }

        Int32 IWorkItemLinkTypeCollection.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        XmlDocument IWorkItemLinkTypeCollection.Export()
        {
            XmlDocument nativeCallResult = r_Instance.Export();
            return nativeCallResult;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            return nativeCallResult;
        }


        void IWorkItemLinkTypeCollection.Import(String definitionXml) { r_Instance.Import(definitionXml); }

        void IWorkItemLinkTypeCollection.Import(XmlElement definitionElement) { r_Instance.Import(definitionElement); }

        void IWorkItemLinkTypeCollection.Import(String definitionXml, Boolean insertsOnly) { r_Instance.Import(definitionXml, insertsOnly); }


        IWorkItemLinkType IWorkItemLinkTypeCollection.this[String linkTypeReferenceName]
        {
            get
            {
                WorkItemLinkType nativeCallResult = r_Instance[linkTypeReferenceName];
                IWorkItemLinkType wrappedCallResult = WorkItemLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemLinkTypeEndCollection IWorkItemLinkTypeCollection.LinkTypeEnds
        {
            get
            {
                WorkItemLinkTypeEndCollection nativeCallResult = r_Instance.LinkTypeEnds;
                IWorkItemLinkTypeEndCollection wrappedCallResult = WorkItemLinkTypeEndCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IWorkItemLinkTypeCollection.TryGetByName(String linkTypeReferenceName, out IWorkItemLinkType linkType)
        {
            WorkItemLinkType tmp_linkType;
            bool nativeCallResult = r_Instance.TryGetByName(linkTypeReferenceName, out tmp_linkType);
            linkType = WorkItemLinkTypeWrapper.GetWrapper(tmp_linkType);
            return nativeCallResult;
        }

        void IWorkItemLinkTypeCollection.Validate(String definitionXml) { r_Instance.Validate(definitionXml); }
        protected WorkItemLinkTypeCollectionWrapper(WorkItemLinkTypeCollection instance) { r_Instance = instance; }
        protected readonly WorkItemLinkTypeCollection r_Instance;
    }
}