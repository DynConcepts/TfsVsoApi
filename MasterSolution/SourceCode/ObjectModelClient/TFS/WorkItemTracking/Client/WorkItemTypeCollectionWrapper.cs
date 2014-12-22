using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemTypeCollectionWrapper : WorkItemTypeCollectionWrapper<IWorkItemTypeCollection, WorkItemTypeCollection>, IWorkItemTypeCollection
    {
        protected WorkItemTypeCollectionWrapper(WorkItemTypeCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemTypeCollection, WorkItemTypeCollection>(src => src == null ? null : ((WorkItemTypeCollectionWrapper) src).r_Instance, src => new WorkItemTypeCollectionWrapper(src)); }
    }


    internal class WorkItemTypeCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, WorkItemType, IWorkItemType>, IWorkItemTypeCollection
        where TInterface : class
        where TWrapper : class
    {
        Boolean IWorkItemTypeCollection.Contains(String typeName)
        {
            bool nativeCallResult = r_Instance.Contains(typeName);
            return nativeCallResult;
        }

        Boolean IWorkItemTypeCollection.Contains(IWorkItemType value)
        {
            bool nativeCallResult = r_Instance.Contains(WorkItemTypeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        void IWorkItemTypeCollection.Import(String definition) { r_Instance.Import(definition); }

        void IWorkItemTypeCollection.Import(XmlElement definitionElement) { r_Instance.Import(definitionElement); }

        void IWorkItemTypeCollection.Import(String definition, String methodologyName) { r_Instance.Import(definition, methodologyName); }

        void IWorkItemTypeCollection.Import(XmlElement definitionElement, String methodologyName) { r_Instance.Import(definitionElement, methodologyName); }


        Int32 IWorkItemTypeCollection.IndexOf(IWorkItemType value)
        {
            int nativeCallResult = r_Instance.IndexOf(WorkItemTypeWrapper.GetInstance(value));
            return nativeCallResult;
        }


        IWorkItemType IWorkItemTypeCollection.this[Int32 index]
        {
            get
            {
                WorkItemType nativeCallResult = r_Instance[index];
                IWorkItemType wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemType IWorkItemTypeCollection.this[String typeName]
        {
            get
            {
                WorkItemType nativeCallResult = r_Instance[typeName];
                IWorkItemType wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemTypeCollectionWrapper(WorkItemTypeCollection instance)
            : base(instance, o => WorkItemTypeWrapper.GetWrapper((WorkItemType) o)) { r_Instance = instance; }

        protected new readonly WorkItemTypeCollection r_Instance;
    }
}