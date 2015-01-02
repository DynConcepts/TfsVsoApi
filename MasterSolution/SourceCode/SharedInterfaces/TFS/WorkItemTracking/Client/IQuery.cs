using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQuery
    /// </summary>
    public interface IQuery
    {
        /// <summary>
        /// Begins the count only query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginCountOnlyQuery();
        /// <summary>
        /// Begins the count only query.
        /// </summary>
        /// <param name="callBack">The call back.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginCountOnlyQuery(AsyncCallback callBack);
        /// <summary>
        /// Begins the link query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginLinkQuery();
        /// <summary>
        /// Begins the link query.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginLinkQuery(AsyncCallback callback);
        /// <summary>
        /// Begins the query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginQuery();
        /// <summary>
        /// Begins the query.
        /// </summary>
        /// <param name="callBack">The call back.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginQuery(AsyncCallback callBack);
        /// <summary>
        /// Begins the regular query.
        /// </summary>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginRegularQuery();
        /// <summary>
        /// Begins the regular query.
        /// </summary>
        /// <param name="callback">The callback.</param>
        /// <returns>IICancelableAsyncResult.</returns>
        IICancelableAsyncResult BeginRegularQuery(AsyncCallback callback);
        /// <summary>
        /// Ends the count only query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>Int32.</returns>
        Int32 EndCountOnlyQuery(IICancelableAsyncResult car);
        /// <summary>
        /// Ends the link query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>IWorkItemLinkInfo[].</returns>
        IWorkItemLinkInfo[] EndLinkQuery(IICancelableAsyncResult car);
        /// <summary>
        /// Ends the query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection EndQuery(IICancelableAsyncResult car);
        /// <summary>
        /// Ends the regular query.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>Int32[].</returns>
        Int32[] EndRegularQuery(IICancelableAsyncResult car);
        /// <summary>
        /// Gets the link types.
        /// </summary>
        /// <returns>IWorkItemLinkTypeEnd[].</returns>
        IWorkItemLinkTypeEnd[] GetLinkTypes();
        /// <summary>
        /// Runs the count query.
        /// </summary>
        /// <returns>Int32.</returns>
        Int32 RunCountQuery();
        /// <summary>
        /// Runs the link query.
        /// </summary>
        /// <returns>IWorkItemLinkInfo[].</returns>
        IWorkItemLinkInfo[] RunLinkQuery();
        /// <summary>
        /// Runs the query.
        /// </summary>
        /// <returns>IWorkItemCollection.</returns>
        IWorkItemCollection RunQuery();
        /// <summary>
        /// Runs the regular query.
        /// </summary>
        /// <returns>Int32[].</returns>
        Int32[] RunRegularQuery();
        /// <summary>
        /// Runs the revision query.
        /// </summary>
        /// <returns>IEnumerable&lt;IRevision&gt;.</returns>
        IEnumerable<IRevision> RunRevisionQuery();
        /// <summary>
        /// Gets as of.
        /// </summary>
        /// <value>As of.</value>
        DateTime AsOf { get; }
        /// <summary>
        /// Gets as of UTC.
        /// </summary>
        /// <value>As of UTC.</value>
        DateTime AsOfUTC { get; }
        /// <summary>
        /// Gets the display field list.
        /// </summary>
        /// <value>The display field list.</value>
        IDisplayFieldList DisplayFieldList { get; }
        /// <summary>
        /// Gets the is batch read mode.
        /// </summary>
        /// <value>The is batch read mode.</value>
        Boolean IsBatchReadMode { get; }
        /// <summary>
        /// Gets the is link query.
        /// </summary>
        /// <value>The is link query.</value>
        Boolean IsLinkQuery { get; }
        /// <summary>
        /// Gets the is tree query.
        /// </summary>
        /// <value>The is tree query.</value>
        Boolean IsTreeQuery { get; }
        /// <summary>
        /// Gets the query string.
        /// </summary>
        /// <value>The query string.</value>
        String QueryString { get; }
        /// <summary>
        /// Gets the sort field list.
        /// </summary>
        /// <value>The sort field list.</value>
        ISortFieldList SortFieldList { get; }
        /// <summary>
        /// Gets the work item store.
        /// </summary>
        /// <value>The work item store.</value>
        IWorkItemStore WorkItemStore { get; }
    }
}