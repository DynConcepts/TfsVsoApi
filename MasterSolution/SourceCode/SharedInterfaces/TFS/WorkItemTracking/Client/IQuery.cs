using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQuery
    {
        IICancelableAsyncResult BeginCountOnlyQuery();
        IICancelableAsyncResult BeginCountOnlyQuery(AsyncCallback callBack);
        IICancelableAsyncResult BeginLinkQuery();
        IICancelableAsyncResult BeginLinkQuery(AsyncCallback callback);
        IICancelableAsyncResult BeginQuery();
        IICancelableAsyncResult BeginQuery(AsyncCallback callBack);
        IICancelableAsyncResult BeginRegularQuery();
        IICancelableAsyncResult BeginRegularQuery(AsyncCallback callback);
        Int32 EndCountOnlyQuery(IICancelableAsyncResult car);
        IWorkItemLinkInfo[] EndLinkQuery(IICancelableAsyncResult car);
        IWorkItemCollection EndQuery(IICancelableAsyncResult car);
        Int32[] EndRegularQuery(IICancelableAsyncResult car);
        IWorkItemLinkTypeEnd[] GetLinkTypes();
        Int32 RunCountQuery();
        IWorkItemLinkInfo[] RunLinkQuery();
        IWorkItemCollection RunQuery();
        Int32[] RunRegularQuery();
        IEnumerable<IRevision> RunRevisionQuery();
        DateTime AsOf { get; }
        DateTime AsOfUTC { get; }
        IDisplayFieldList DisplayFieldList { get; }
        Boolean IsBatchReadMode { get; }
        Boolean IsLinkQuery { get; }
        Boolean IsTreeQuery { get; }
        String QueryString { get; }
        ISortFieldList SortFieldList { get; }
        IWorkItemStore WorkItemStore { get; }
    }
}