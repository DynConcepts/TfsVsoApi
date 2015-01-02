using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IWorkItemServer
    /// </summary>
    public interface IWorkItemServer : IITfsTeamProjectCollectionObject, IITfsRequestListener
    {
        /// <summary>
        /// Bulks the update.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <returns>Boolean.</returns>
        Boolean BulkUpdate(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Destroys the attachments.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="workItemIds">The work item ids.</param>
        void DestroyAttachments(String requestId, Int32[] workItemIds);
        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="fileAttachmentId">The file attachment identifier.</param>
        /// <returns>String.</returns>
        String DownloadFile(Int32 fileAttachmentId);
        /// <summary>
        /// Gets the changed work item ids.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <returns>IEnumerable&lt;IWorkItemId&gt;.</returns>
        IEnumerable<IWorkItemId> GetChangedWorkItemIds(String requestId, Int64 rowVersion);
        /// <summary>
        /// Gets the destroyed work item ids.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <returns>IEnumerable&lt;IWorkItemId&gt;.</returns>
        IEnumerable<IWorkItemId> GetDestroyedWorkItemIds(String requestId, Int64 rowVersion);
        /// <summary>
        /// Gets the metadata.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="comparisonStyle">The comparison style.</param>
        /// <param name="callerIdentity">The caller identity.</param>
        void GetMetadata(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity);
        /// <summary>
        /// Gets the metadata ex.
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
        void GetMetadataEx(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity, out String callerIdentitySid);
        /// <summary>
        /// Gets the metadata ex2.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="locale">The locale.</param>
        /// <param name="comparisonStyle">The comparison style.</param>
        /// <param name="displayMode">The display mode.</param>
        void GetMetadataEx2(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out Int32 displayMode);
        /// <summary>
        /// Gets the referencing workitem uris.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="artifactUri">The artifact URI.</param>
        /// <returns>String[].</returns>
        String[] GetReferencingWorkitemUris(String requestId, String artifactUri);
        /// <summary>
        /// Gets the stored queries.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="queriesDataSet">The queries data set.</param>
        void GetStoredQueries(String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet);
        /// <summary>
        /// Gets the stored query.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="queryId">The query identifier.</param>
        /// <param name="queryDataSet">The query data set.</param>
        void GetStoredQuery(String requestId, Boolean useMaster, Guid queryId, out IRowSetCollection queryDataSet);
        /// <summary>
        /// Gets the stored query item access control list.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="queryItemId">The query item identifier.</param>
        /// <param name="getMetadata">The get metadata.</param>
        /// <returns>IExtendedAccessControlListData.</returns>
        IExtendedAccessControlListData GetStoredQueryItemAccessControlList(String requestId, Guid queryItemId, Boolean getMetadata);
        /// <summary>
        /// Gets the stored query items.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="queriesDataSet">The queries data set.</param>
        void GetStoredQueryItems(String requestId, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet);
        /// <summary>
        /// Gets the work item.
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
        void GetWorkItem(String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, DateTime? asOfDate, Boolean useMaster, out IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Gets the work item ids for artifact uris.
        /// </summary>
        /// <param name="artifactUris">The artifact uris.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <returns>IIResultCollection&lt;IArtifactWorkItemIds&gt;.</returns>
        IIResultCollection<IArtifactWorkItemIds> GetWorkItemIdsForArtifactUris(String[] artifactUris, DateTime? asOfDate);
        /// <summary>
        /// Gets the work item link changes.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="rowVersion">The row version.</param>
        /// <returns>IEnumerable&lt;IWorkItemLinkChange&gt;.</returns>
        IEnumerable<IWorkItemLinkChange> GetWorkItemLinkChanges(String requestId, Int64 rowVersion);
        /// <summary>
        /// Gets the workitem tracking version.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <returns>String.</returns>
        String GetWorkitemTrackingVersion(String requestId);
        /// <summary>
        /// Pages the workitems by identifier revs.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="pairs">The pairs.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="longTextColumns">The long text columns.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="pageDate">The page date.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="items">The items.</param>
        void PageWorkitemsByIdRevs(String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, out DateTime pageDate, Boolean useMaster, out IIPagedItemsRowSets items);
        /// <summary>
        /// Pages the workitems by ids.
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
        void PageWorkitemsByIds(String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, Boolean useMaster, out IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave, out IIMetadataRowSets metadata);
        /// <summary>
        /// Queries the linked workitems.
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
        void QueryLinkedWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IWorkItemRelation[] relations, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Queries the workitem count.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="psQuery">The ps query.</param>
        /// <param name="useMaster">The use master.</param>
        /// <param name="count">The count.</param>
        /// <param name="asOfDate">As of date.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        void QueryWorkitemCount(String requestId, XmlElement psQuery, Boolean useMaster, out Int32 count, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Queries the workitem revisions.
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
        void QueryWorkitemRevisions(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IIdRevisionPair[] pairs, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Queries the workitems.
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
        void QueryWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out Int32[] ids, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Requests the cancel.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="cancelRequestId">The cancel request identifier.</param>
        void RequestCancel(String requestId, String cancelRequestId);
        /// <summary>
        /// Stamps the workitem cache.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        void StampWorkitemCache(String requestId);
        /// <summary>
        /// Synchronizes the bis groups and users.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="projectUri">The project URI.</param>
        void SyncBisGroupsAndUsers(String requestId, String projectUri);
        /// <summary>
        /// Synchronizes the external structures.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="projectURI">The project URI.</param>
        void SyncExternalStructures(String requestId, String projectURI);
        /// <summary>
        /// Updates the specified request identifier.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="package">The package.</param>
        /// <param name="result">The result.</param>
        /// <param name="metadataHave">The metadata have.</param>
        /// <param name="dbStamp">The database stamp.</param>
        /// <param name="metadata">The metadata.</param>
        void Update(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        /// <summary>
        /// Updates the maximum size of the attachment.
        /// </summary>
        void UpdateMaxAttachmentSize();
        /// <summary>
        /// Uploads the file.
        /// </summary>
        /// <param name="fileAttachment">The file attachment.</param>
        void UploadFile(IFileAttachment fileAttachment);
        /// <summary>
        /// Gets the maximum size of the attachment.
        /// </summary>
        /// <value>The maximum size of the attachment.</value>
        Int64 MaxAttachmentSize { get; }
        /// <summary>
        /// Gets the work item server version.
        /// </summary>
        /// <value>The work item server version.</value>
        IWorkItemServerVersion WorkItemServerVersion { get; }
    }
}