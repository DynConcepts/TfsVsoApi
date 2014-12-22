using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using ICancelableAsyncResult = Microsoft.TeamFoundation.Client.ICancelableAsyncResult;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class QueryWrapper : QueryWrapper<IQuery, Query>, IQuery
    {
        protected QueryWrapper(Query instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IQuery, Query>(src => src == null ? null : ((QueryWrapper) src).r_Instance, src => new QueryWrapper(src)); }
    }


    internal class QueryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IQuery where TInterface : class where TWrapper : class
    {
        DateTime IQuery.AsOf
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AsOf;
                return nativeCallResult;
            }
        }

        DateTime IQuery.AsOfUTC
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AsOfUTC;
                return nativeCallResult;
            }
        }

        IICancelableAsyncResult IQuery.BeginCountOnlyQuery()
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginCountOnlyQuery();
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IICancelableAsyncResult IQuery.BeginCountOnlyQuery(AsyncCallback callBack)
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginCountOnlyQuery(callBack);
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IICancelableAsyncResult IQuery.BeginLinkQuery()
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginLinkQuery();
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IICancelableAsyncResult IQuery.BeginLinkQuery(AsyncCallback callback)
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginLinkQuery(callback);
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IICancelableAsyncResult IQuery.BeginQuery()
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginQuery();
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IICancelableAsyncResult IQuery.BeginQuery(AsyncCallback callBack)
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginQuery(callBack);
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IICancelableAsyncResult IQuery.BeginRegularQuery()
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginRegularQuery();
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IICancelableAsyncResult IQuery.BeginRegularQuery(AsyncCallback callback)
        {
            ICancelableAsyncResult nativeCallResult = r_Instance.BeginRegularQuery(callback);
            IICancelableAsyncResult wrappedCallResult = ICancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IDisplayFieldList IQuery.DisplayFieldList
        {
            get
            {
                DisplayFieldList nativeCallResult = r_Instance.DisplayFieldList;
                IDisplayFieldList wrappedCallResult = DisplayFieldListWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Int32 IQuery.EndCountOnlyQuery(IICancelableAsyncResult car)
        {
            int nativeCallResult = r_Instance.EndCountOnlyQuery(ICancelableAsyncResultWrapper.GetInstance(car));
            return nativeCallResult;
        }

        IWorkItemLinkInfo[] IQuery.EndLinkQuery(IICancelableAsyncResult car)
        {
            WorkItemLinkInfo[] nativeCallResult = r_Instance.EndLinkQuery(ICancelableAsyncResultWrapper.GetInstance(car));
            IWorkItemLinkInfo[] wrappedCallResult = WorkItemLinkInfoWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItemCollection IQuery.EndQuery(IICancelableAsyncResult car)
        {
            WorkItemCollection nativeCallResult = r_Instance.EndQuery(ICancelableAsyncResultWrapper.GetInstance(car));
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Int32[] IQuery.EndRegularQuery(IICancelableAsyncResult car)
        {
            int[] nativeCallResult = r_Instance.EndRegularQuery(ICancelableAsyncResultWrapper.GetInstance(car));
            return nativeCallResult;
        }

        IWorkItemLinkTypeEnd[] IQuery.GetLinkTypes()
        {
            WorkItemLinkTypeEnd[] nativeCallResult = r_Instance.GetLinkTypes();
            IWorkItemLinkTypeEnd[] wrappedCallResult = WorkItemLinkTypeEndWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Boolean IQuery.IsBatchReadMode
        {
            get
            {
                bool nativeCallResult = r_Instance.IsBatchReadMode;
                return nativeCallResult;
            }
        }

        Boolean IQuery.IsLinkQuery
        {
            get
            {
                bool nativeCallResult = r_Instance.IsLinkQuery;
                return nativeCallResult;
            }
        }

        Boolean IQuery.IsTreeQuery
        {
            get
            {
                bool nativeCallResult = r_Instance.IsTreeQuery;
                return nativeCallResult;
            }
        }

        String IQuery.QueryString
        {
            get
            {
                string nativeCallResult = r_Instance.QueryString;
                return nativeCallResult;
            }
        }

        Int32 IQuery.RunCountQuery()
        {
            int nativeCallResult = r_Instance.RunCountQuery();
            return nativeCallResult;
        }

        IWorkItemLinkInfo[] IQuery.RunLinkQuery()
        {
            WorkItemLinkInfo[] nativeCallResult = r_Instance.RunLinkQuery();
            IWorkItemLinkInfo[] wrappedCallResult = WorkItemLinkInfoWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IWorkItemCollection IQuery.RunQuery()
        {
            WorkItemCollection nativeCallResult = r_Instance.RunQuery();
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Int32[] IQuery.RunRegularQuery()
        {
            int[] nativeCallResult = r_Instance.RunRegularQuery();
            return nativeCallResult;
        }

        IEnumerable<IRevision> IQuery.RunRevisionQuery()
        {
            IEnumerable<Revision> nativeCallResult = r_Instance.RunRevisionQuery();
            IEnumerable<IRevision> wrappedCallResult = RevisionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        ISortFieldList IQuery.SortFieldList
        {
            get
            {
                SortFieldList nativeCallResult = r_Instance.SortFieldList;
                ISortFieldList wrappedCallResult = SortFieldListWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemStore IQuery.WorkItemStore
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.WorkItemStore;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected QueryWrapper(Query instance) { r_Instance = instance; }
        protected readonly Query r_Instance;
    }
}