using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryImpl.
    /// </summary>
    internal class QueryImpl : IQuery
    {
        /// <summary>
        ///     Gets as of.
        /// </summary>
        /// <value>As of.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IQuery.AsOf { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets as of UTC.
        /// </summary>
        /// <value>As of UTC.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IQuery.AsOfUTC { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Begins the count only query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginCountOnlyQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the count only query.
        /// </summary>
        /// <param name="callBack">The call back.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginCountOnlyQuery(AsyncCallback callBack) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the link query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginLinkQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the link query.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginLinkQuery(AsyncCallback callback) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the query.
        /// </summary>
        /// <param name="callBack">The call back.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginQuery(AsyncCallback callBack) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the regular query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginRegularQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the regular query.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IICancelableAsyncResult IQuery.BeginRegularQuery(AsyncCallback callback) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the display field list.
        /// </summary>
        /// <value>The display field list.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IDisplayFieldList IQuery.DisplayFieldList { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Ends the count only query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IQuery.EndCountOnlyQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Ends the link query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>IWorkItemLinkInfo[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkInfo[] IQuery.EndLinkQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Ends the query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemCollection IQuery.EndQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Ends the regular query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>Int32[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32[] IQuery.EndRegularQuery(IICancelableAsyncResult car) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the link types.
        /// </summary>
        /// <returns>IWorkItemLinkTypeEnd[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd[] IQuery.GetLinkTypes() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the is batch read mode.
        /// </summary>
        /// <value>The is batch read mode.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQuery.IsBatchReadMode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is link query.
        /// </summary>
        /// <value>The is link query.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQuery.IsLinkQuery { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is tree query.
        /// </summary>
        /// <value>The is tree query.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQuery.IsTreeQuery { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the query string.
        /// </summary>
        /// <value>The query string.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IQuery.QueryString { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Runs the count query.
        /// </summary>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IQuery.RunCountQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Runs the link query.
        /// </summary>
        /// <returns>IWorkItemLinkInfo[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkInfo[] IQuery.RunLinkQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Runs the query.
        /// </summary>
        /// <returns>IWorkItemCollection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemCollection IQuery.RunQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Runs the regular query.
        /// </summary>
        /// <returns>Int32[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32[] IQuery.RunRegularQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Runs the revision query.
        /// </summary>
        /// <returns>IEnumerable&lt;IRevision&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IRevision> IQuery.RunRevisionQuery() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the sort field list.
        /// </summary>
        /// <value>The sort field list.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ISortFieldList IQuery.SortFieldList { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item store.
        /// </summary>
        /// <value>The work item store.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemStore IQuery.WorkItemStore { get { throw new ToBeImplementedException(); } }
    }
}