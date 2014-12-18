using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryImpl : IQuery
    {
        DateTime IQuery.AsOf { get { throw new ToBeImplementedException(); } }
        DateTime IQuery.AsOfUTC { get { throw new ToBeImplementedException(); } }
        IICancelableAsyncResult IQuery.BeginCountOnlyQuery() { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginCountOnlyQuery(AsyncCallback callBack) { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginLinkQuery() { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginLinkQuery(AsyncCallback callback) { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginQuery() { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginQuery(AsyncCallback callBack) { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginRegularQuery() { throw new ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginRegularQuery(AsyncCallback callback) { throw new ToBeImplementedException(); }
        IDisplayFieldList IQuery.DisplayFieldList { get { throw new ToBeImplementedException(); } }
        Int32 IQuery.EndCountOnlyQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }
        IWorkItemLinkInfo[] IQuery.EndLinkQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }
        IWorkItemCollection IQuery.EndQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }
        Int32[] IQuery.EndRegularQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }
        IWorkItemLinkTypeEnd[] IQuery.GetLinkTypes() { throw new ToBeImplementedException(); }
        Boolean IQuery.IsBatchReadMode { get { throw new ToBeImplementedException(); } }
        Boolean IQuery.IsLinkQuery { get { throw new ToBeImplementedException(); } }
        Boolean IQuery.IsTreeQuery { get { throw new ToBeImplementedException(); } }
        String IQuery.QueryString { get { throw new ToBeImplementedException(); } }
        Int32 IQuery.RunCountQuery() { throw new ToBeImplementedException(); }
        IWorkItemLinkInfo[] IQuery.RunLinkQuery() { throw new ToBeImplementedException(); }
        IWorkItemCollection IQuery.RunQuery() { throw new ToBeImplementedException(); }
        Int32[] IQuery.RunRegularQuery() { throw new ToBeImplementedException(); }
        IEnumerable<IRevision> IQuery.RunRevisionQuery() { throw new ToBeImplementedException(); }
        ISortFieldList IQuery.SortFieldList { get { throw new ToBeImplementedException(); } }
        IWorkItemStore IQuery.WorkItemStore { get { throw new ToBeImplementedException(); } }
    }
}