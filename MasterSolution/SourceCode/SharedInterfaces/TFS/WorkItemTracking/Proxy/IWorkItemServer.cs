using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
  public interface IWorkItemServer : IITfsTeamProjectCollectionObject ,IITfsRequestListener
  {
    String GetWorkitemTrackingVersion( String requestId);
    void StampWorkitemCache( String requestId);
    void GetWorkItem( String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, Nullable<DateTime> asOfDate, Boolean useMaster,out IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void QueryWorkitemRevisions( String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster,out IIdRevisionPair[] pairs,out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void QueryWorkitems( String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster,out Int32[] ids,out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void QueryLinkedWorkitems( String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster,out IWorkItemRelation[] relations,out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void PageWorkitemsByIds( String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, Nullable<DateTime> asOfDate, Boolean useMaster,out IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave,out IIMetadataRowSets metadata);
    void PageWorkitemsByIdRevs( String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, Nullable<DateTime> asOfDate,out DateTime pageDate, Boolean useMaster,out IIPagedItemsRowSets items);
    void QueryWorkitemCount( String requestId, XmlElement psQuery, Boolean useMaster,out Int32 count,out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void GetMetadata( String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata,out Int32 locale,out Int32 comparisonStyle,out String callerIdentity);
    void GetMetadataEx( String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata,out Int32 locale,out Int32 comparisonStyle,out String callerIdentity,out String callerIdentitySid);
    void GetMetadataEx2( String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata,out Int32 locale,out Int32 comparisonStyle,out Int32 displayMode);
    Boolean BulkUpdate( String requestId, XmlElement package,out XmlElement result, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void Update( String requestId, XmlElement package,out XmlElement result, IMetadataTableHaveEntry[] metadataHave,out String dbStamp,out IIMetadataRowSets metadata);
    void UpdateMaxAttachmentSize();
    void UploadFile( IFileAttachment fileAttachment);
    String DownloadFile( Int32 fileAttachmentId);
    void GetStoredQuery( String requestId, Boolean useMaster, Guid queryId,out IRowSetCollection queryDataSet);
    void GetStoredQueries( String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId,out IRowSetCollection queriesDataSet);
    void GetStoredQueryItems( String requestId, Int64 rowVersion, Int32 projectId,out IRowSetCollection queriesDataSet);
    IEnumerable<IWorkItemId> GetDestroyedWorkItemIds( String requestId, Int64 rowVersion);
    IEnumerable<IWorkItemId> GetChangedWorkItemIds( String requestId, Int64 rowVersion);
    IEnumerable<IWorkItemLinkChange> GetWorkItemLinkChanges( String requestId, Int64 rowVersion);
    IExtendedAccessControlListData GetStoredQueryItemAccessControlList( String requestId, Guid queryItemId, Boolean getMetadata);
    void RequestCancel( String requestId, String cancelRequestId);
    void SyncExternalStructures( String requestId, String projectURI);
    void SyncBisGroupsAndUsers( String requestId, String projectUri);
    String[] GetReferencingWorkitemUris( String requestId, String artifactUri);
    IIResultCollection<IArtifactWorkItemIds> GetWorkItemIdsForArtifactUris( String[] artifactUris, Nullable<DateTime> asOfDate);
    void DestroyAttachments( String requestId, Int32[] workItemIds);
    IWorkItemServerVersion WorkItemServerVersion  { get;   }
    Int64 MaxAttachmentSize  { get;   }
  }
}
