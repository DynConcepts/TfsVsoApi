using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkTypeEndCollectionWrapper : WorkItemLinkTypeEndCollectionWrapper<IWorkItemLinkTypeEndCollection, WorkItemLinkTypeEndCollection>, IWorkItemLinkTypeEndCollection, IEnumerable
    {
        protected WorkItemLinkTypeEndCollectionWrapper(WorkItemLinkTypeEndCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkTypeEndCollection, WorkItemLinkTypeEndCollection>(src => src==null ? null : ((WorkItemLinkTypeEndCollectionWrapper) src).r_Instance, src => new WorkItemLinkTypeEndCollectionWrapper(src)); }
    }


    internal class WorkItemLinkTypeEndCollectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemLinkTypeEndCollection where TInterface : class where TWrapper : class
    {

        Boolean IWorkItemLinkTypeEndCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }


        Boolean IWorkItemLinkTypeEndCollection.Contains(String linkTypeName)
        {
            bool nativeCallResult = r_Instance.Contains(linkTypeName);
            return nativeCallResult;
        }

        Int32 IWorkItemLinkTypeEndCollection.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }


        IWorkItemLinkTypeEnd IWorkItemLinkTypeEndCollection.GetById(Int32 id)
        {
            WorkItemLinkTypeEnd nativeCallResult = r_Instance.GetById(id);
            IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }




        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            return nativeCallResult;
        }

        IWorkItemLinkTypeEnd IWorkItemLinkTypeEndCollection.this[String linkTypeEndName]
        {
            get
            {
                WorkItemLinkTypeEnd nativeCallResult = r_Instance[linkTypeEndName];
                IWorkItemLinkTypeEnd wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IWorkItemLinkTypeEndCollection.TryGetById(Int32 id, out IWorkItemLinkTypeEnd linkTypeEnd)
        {
            WorkItemLinkTypeEnd tmp_linkTypeEnd;
            bool nativeCallResult = r_Instance.TryGetById(id, out tmp_linkTypeEnd);
            linkTypeEnd = WorkItemLinkTypeEndWrapper.GetWrapper(tmp_linkTypeEnd);
            return nativeCallResult;
        }


        Boolean IWorkItemLinkTypeEndCollection.TryGetByName(String linkTypeEndName, out IWorkItemLinkTypeEnd linkTypeEnd)
        {
            WorkItemLinkTypeEnd tmp_linkTypeEnd;
            bool nativeCallResult = r_Instance.TryGetByName(linkTypeEndName, out tmp_linkTypeEnd);
            linkTypeEnd = WorkItemLinkTypeEndWrapper.GetWrapper(tmp_linkTypeEnd);
            return nativeCallResult;
        }

        protected WorkItemLinkTypeEndCollectionWrapper(WorkItemLinkTypeEndCollection instance) { r_Instance = instance; }
        protected readonly WorkItemLinkTypeEndCollection r_Instance;
    }
}