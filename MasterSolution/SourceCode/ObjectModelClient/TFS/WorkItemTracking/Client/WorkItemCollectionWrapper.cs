using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemCollectionWrapper : WorkItemCollectionWrapper<IWorkItemCollection, WorkItemCollection>, IWorkItemCollection
    {
        protected WorkItemCollectionWrapper(WorkItemCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemCollection, WorkItemCollection>(src => src == null ? null : ((WorkItemCollectionWrapper) src).r_Instance, src => new WorkItemCollectionWrapper(src)); }
    }


    internal class WorkItemCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, WorkItem, IWorkItem>, IWorkItemCollection
        where TInterface : class
        where TWrapper : class
    {
        DateTime IWorkItemCollection.AsOf
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AsOf;
                return nativeCallResult;
            }
            set { r_Instance.AsOf = value; }
        }

        DateTime IWorkItemCollection.AsOfUTC
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AsOfUTC;
                return nativeCallResult;
            }
            set { r_Instance.AsOfUTC = value; }
        }

        Boolean IWorkItemCollection.Contains(IWorkItem value)
        {
            bool nativeCallResult = r_Instance.Contains(WorkItemWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 IWorkItemCollection.DefaultProjectHint
        {
            get
            {
                int nativeCallResult = r_Instance.DefaultProjectHint;
                return nativeCallResult;
            }
            set { r_Instance.DefaultProjectHint = value; }
        }

        IDisplayFieldList IWorkItemCollection.DisplayFields
        {
            get
            {
                DisplayFieldList nativeCallResult = r_Instance.DisplayFields;
                IDisplayFieldList wrappedCallResult = DisplayFieldListWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Int32 IWorkItemCollection.GetId(Int32 index)
        {
            int nativeCallResult = r_Instance.GetId(index);
            return nativeCallResult;
        }


        Int32 IWorkItemCollection.IndexOf(Int32 id)
        {
            int nativeCallResult = r_Instance.IndexOf(id);
            return nativeCallResult;
        }


        Int32 IWorkItemCollection.IndexOf(IWorkItem value)
        {
            int nativeCallResult = r_Instance.IndexOf(WorkItemWrapper.GetInstance(value));
            return nativeCallResult;
        }


        IWorkItem IWorkItemCollection.this[Int32 index]
        {
            get
            {
                WorkItem nativeCallResult = r_Instance[index];
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Int32 IWorkItemCollection.PageSize
        {
            get
            {
                int nativeCallResult = r_Instance.PageSize;
                return nativeCallResult;
            }
            set { r_Instance.PageSize = value; }
        }

        IQuery IWorkItemCollection.Query
        {
            get
            {
                Query nativeCallResult = r_Instance.Query;
                IQuery wrappedCallResult = QueryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IWorkItemCollection.Resort() { r_Instance.Resort(); }

        ISortFieldList IWorkItemCollection.SortFields
        {
            get
            {
                SortFieldList nativeCallResult = r_Instance.SortFields;
                ISortFieldList wrappedCallResult = SortFieldListWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemStore IWorkItemCollection.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemCollectionWrapper(WorkItemCollection instance)
            : base(instance, o => WorkItemWrapper.GetWrapper((WorkItem) o)) { r_Instance = instance; }

        protected new readonly WorkItemCollection r_Instance;
    }
}