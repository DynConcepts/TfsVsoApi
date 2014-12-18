using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryImpl : IQuery
    {
        DateTime IQuery.AsOf { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        DateTime IQuery.AsOfUTC { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IICancelableAsyncResult IQuery.BeginCountOnlyQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginCountOnlyQuery(AsyncCallback callBack) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginLinkQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginLinkQuery(AsyncCallback callback) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginQuery(AsyncCallback callBack) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginRegularQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IICancelableAsyncResult IQuery.BeginRegularQuery(AsyncCallback callback) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IDisplayFieldList IQuery.DisplayFieldList { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IQuery.EndCountOnlyQuery(IICancelableAsyncResult car) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemLinkInfo[] IQuery.EndLinkQuery(IICancelableAsyncResult car) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemCollection IQuery.EndQuery(IICancelableAsyncResult car) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32[] IQuery.EndRegularQuery(IICancelableAsyncResult car) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemLinkTypeEnd[] IQuery.GetLinkTypes() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQuery.IsBatchReadMode { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQuery.IsLinkQuery { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQuery.IsTreeQuery { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IQuery.QueryString { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IQuery.RunCountQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemLinkInfo[] IQuery.RunLinkQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemCollection IQuery.RunQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32[] IQuery.RunRegularQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IRevision> IQuery.RunRevisionQuery() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ISortFieldList IQuery.SortFieldList { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IWorkItemStore IQuery.WorkItemStore { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}