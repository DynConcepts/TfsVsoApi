using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IWorkItemServer : IITfsTeamProjectCollectionObject, IITfsRequestListener
    {
        Boolean BulkUpdate(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        void DestroyAttachments(String requestId, Int32[] workItemIds);
        String DownloadFile(Int32 fileAttachmentId);
        IEnumerable<IWorkItemId> GetChangedWorkItemIds(String requestId, Int64 rowVersion);
        IEnumerable<IWorkItemId> GetDestroyedWorkItemIds(String requestId, Int64 rowVersion);
        void GetMetadata(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity);
        void GetMetadataEx(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity, out String callerIdentitySid);
        void GetMetadataEx2(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out Int32 displayMode);
        String[] GetReferencingWorkitemUris(String requestId, String artifactUri);
        void GetStoredQueries(String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet);
        void GetStoredQuery(String requestId, Boolean useMaster, Guid queryId, out IRowSetCollection queryDataSet);
        IExtendedAccessControlListData GetStoredQueryItemAccessControlList(String requestId, Guid queryItemId, Boolean getMetadata);
        void GetStoredQueryItems(String requestId, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet);
        void GetWorkItem(String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, DateTime? asOfDate, Boolean useMaster, out IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        IIResultCollection<IArtifactWorkItemIds> GetWorkItemIdsForArtifactUris(String[] artifactUris, DateTime? asOfDate);
        IEnumerable<IWorkItemLinkChange> GetWorkItemLinkChanges(String requestId, Int64 rowVersion);
        String GetWorkitemTrackingVersion(String requestId);
        void PageWorkitemsByIdRevs(String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, out DateTime pageDate, Boolean useMaster, out IIPagedItemsRowSets items);
        void PageWorkitemsByIds(String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, Boolean useMaster, out IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave, out IIMetadataRowSets metadata);
        void QueryLinkedWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IWorkItemRelation[] relations, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        void QueryWorkitemCount(String requestId, XmlElement psQuery, Boolean useMaster, out Int32 count, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        void QueryWorkitemRevisions(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IIdRevisionPair[] pairs, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        void QueryWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out Int32[] ids, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        void RequestCancel(String requestId, String cancelRequestId);
        void StampWorkitemCache(String requestId);
        void SyncBisGroupsAndUsers(String requestId, String projectUri);
        void SyncExternalStructures(String requestId, String projectURI);
        void Update(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata);
        void UpdateMaxAttachmentSize();
        void UploadFile(IFileAttachment fileAttachment);
        Int64 MaxAttachmentSize { get; }
        IWorkItemServerVersion WorkItemServerVersion { get; }
    }
}