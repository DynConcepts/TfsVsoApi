using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class WorkItemServerImpl.
    /// </summary>
    internal class WorkItemServerImpl : IWorkItemServer, IITfsTeamProjectCollectionObject, IITfsRequestListener
    {
        /// <summary>
        ///     Afters the receive reply.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="response">The response.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsRequestListener.AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Befores the send request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="request">The request.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsRequestListener.BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the request.
        /// </summary>
        /// <returns>Int64.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int64 IITfsRequestListener.BeginRequest() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Bulks the update.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemServer.BulkUpdate(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Destroys the attachments.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="workItemIds">The work item ids.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.DestroyAttachments(String requestId, Int32[] workItemIds) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Downloads the file.
        /// </summary>
        /// <param name="fileAttachmentId">The file attachment identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IWorkItemServer.DownloadFile(Int32 fileAttachmentId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Ends the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="exception">The exception.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsRequestListener.EndRequest(Int64 requestId, Exception exception) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the changed work item ids.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <returns>IEnumerable&lt;IWorkItemId&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IWorkItemId> IWorkItemServer.GetChangedWorkItemIds(String requestId, Int64 rowVersion) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the destroyed work item ids.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <returns>IEnumerable&lt;IWorkItemId&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IWorkItemId> IWorkItemServer.GetDestroyedWorkItemIds(String requestId, Int64 rowVersion) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the metadata.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="comparisonStyle">The comparison style.</param>
        /// <param name="callerIdentity">The caller identity.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetMetadata(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the metadata ex.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="comparisonStyle">The comparison style.</param>
        /// <param name="callerIdentity">The caller identity.</param>
        /// <param name="callerIdentitySid">The caller identity sid.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetMetadataEx(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity, out String callerIdentitySid) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the metadata ex2.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="comparisonStyle">The comparison style.</param>
        /// <param name="displayMode">The display mode.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetMetadataEx2(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out Int32 displayMode) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the referencing workitem uris.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="artifactUri">The artifact URI.</param>
        /// <returns>String[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String[] IWorkItemServer.GetReferencingWorkitemUris(String requestId, String artifactUri) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the stored queries.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="queriesDataSet">The queries data set.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetStoredQueries(String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the stored query.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="queryId">The query identifier.</param>
        /// <param name="queryDataSet">The query data set.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetStoredQuery(String requestId, Boolean useMaster, Guid queryId, out IRowSetCollection queryDataSet) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the stored query item access control list.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="queryItemId">The query item identifier.</param>
        /// <param name="getMetadata">The get metadata.</param>
        /// <returns>IExtendedAccessControlListData.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IExtendedAccessControlListData IWorkItemServer.GetStoredQueryItemAccessControlList(String requestId, Guid queryItemId, Boolean getMetadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the stored query items.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="queriesDataSet">The queries data set.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetStoredQueryItems(String requestId, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="workItemId">The work item identifier.</param>
        /// <param name="revisionId">The revision identifier.</param>
        /// <param name="minimumRevisionId">The minimum revision identifier.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="workItem">The work item.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.GetWorkItem(String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, DateTime? asOfDate, Boolean useMaster, out IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item ids for artifact uris.
        /// </summary>
        /// <param name="artifactUris">The artifact uris.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <returns>IIResultCollection&lt;IArtifactWorkItemIds&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIResultCollection<IArtifactWorkItemIds> IWorkItemServer.GetWorkItemIdsForArtifactUris(String[] artifactUris, DateTime? asOfDate) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item link changes.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <returns>IEnumerable&lt;IWorkItemLinkChange&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IWorkItemLinkChange> IWorkItemServer.GetWorkItemLinkChanges(String requestId, Int64 rowVersion) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the workitem tracking version.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IWorkItemServer.GetWorkitemTrackingVersion(String requestId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Initializes the specified project collection.
        /// </summary>
        /// <param name="projectCollection">The project collection.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the maximum size of the attachment.
        /// </summary>
        /// <value>The maximum size of the attachment.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int64 IWorkItemServer.MaxAttachmentSize { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Pages the workitems by identifier revs.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="pairs">The pairs.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="longTextColumns">The long text columns.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="pageDate">The page date.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="items">The items.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.PageWorkitemsByIdRevs(String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, out DateTime pageDate, Boolean useMaster, out IIPagedItemsRowSets items) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Pages the workitems by ids.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="ids">The ids.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="longTextColumns">The long text columns.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="items">The items.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.PageWorkitemsByIds(String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, Boolean useMaster, out IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the linked workitems.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="psQuery">The ps query.</param>
        /// <param name="sort">The sort.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="relations">The relations.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.QueryLinkedWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IWorkItemRelation[] relations, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the workitem count.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="psQuery">The ps query.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="count">The count.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.QueryWorkitemCount(String requestId, XmlElement psQuery, Boolean useMaster, out Int32 count, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the workitem revisions.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="psQuery">The ps query.</param>
        /// <param name="sort">The sort.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="pairs">The pairs.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.QueryWorkitemRevisions(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IIdRevisionPair[] pairs, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the workitems.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="psQuery">The ps query.</param>
        /// <param name="sort">The sort.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="ids">The ids.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.QueryWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out Int32[] ids, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Requests the cancel.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="cancelRequestId">The cancel request identifier.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.RequestCancel(String requestId, String cancelRequestId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Stamps the workitem cache.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.StampWorkitemCache(String requestId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Synchronizes the bis groups and users.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="projectUri">The project URI.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.SyncBisGroupsAndUsers(String requestId, String projectUri) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Synchronizes the external structures.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="projectURI">The project URI.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.SyncExternalStructures(String requestId, String projectURI) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Updates the specified request identifier.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.Update(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Updates the maximum size of the attachment.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.UpdateMaxAttachmentSize() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Uploads the file.
        /// </summary>
        /// <param name="fileAttachment">The file attachment.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemServer.UploadFile(IFileAttachment fileAttachment) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the work item server version.
        /// </summary>
        /// <value>The work item server version.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemServerVersion IWorkItemServer.WorkItemServerVersion { get { throw new ToBeImplementedException(); } }
    }
}