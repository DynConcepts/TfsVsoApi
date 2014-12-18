using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemLinkCollectionWrapper : WorkItemLinkCollectionWrapper<IWorkItemLinkCollection, WorkItemLinkCollection>, IWorkItemLinkCollection
    {
        protected WorkItemLinkCollectionWrapper(WorkItemLinkCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemLinkCollection, WorkItemLinkCollection>(src => src==null ? null : ((WorkItemLinkCollectionWrapper) src).r_Instance, src => new WorkItemLinkCollectionWrapper(src)); }
    }


    internal class WorkItemLinkCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IWorkItemLinkCollection where TInterface : class where TWrapper : class
    {

        Int32 IWorkItemLinkCollection.Add(IWorkItemLink link)
        {
            int nativeCallResult = r_Instance.Add(WorkItemLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }



        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.AddedLinks
        {
            get
            {
                IEnumerable<WorkItemLink> nativeCallResult = r_Instance.AddedLinks;
                IEnumerable<IWorkItemLink> wrappedCallResult = WorkItemLinkWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IWorkItemLinkCollection.Contains(IWorkItemLink link)
        {
            bool nativeCallResult = r_Instance.Contains(WorkItemLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        IEnumerable<IWorkItemLink> IWorkItemLinkCollection.DeletedLinks
        {
            get
            {
                IEnumerable<WorkItemLink> nativeCallResult = r_Instance.DeletedLinks;
                IEnumerable<IWorkItemLink> wrappedCallResult = WorkItemLinkWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Int32 IWorkItemLinkCollection.IndexOf(IWorkItemLink link)
        {
            int nativeCallResult = r_Instance.IndexOf(WorkItemLinkWrapper.GetInstance(link));
            return nativeCallResult;
        }

        IWorkItemLink IWorkItemLinkCollection.this[Int32 index]
        {
            get
            {
                WorkItemLink nativeCallResult = r_Instance[index];
                IWorkItemLink wrappedCallResult = WorkItemLinkWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IWorkItemLinkCollection.Refresh() { r_Instance.Refresh(); }
        void IWorkItemLinkCollection.Remove(IWorkItemLink link) { r_Instance.Remove(WorkItemLinkWrapper.GetInstance(link)); }
        protected WorkItemLinkCollectionWrapper(WorkItemLinkCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly WorkItemLinkCollection r_Instance;
    }
}