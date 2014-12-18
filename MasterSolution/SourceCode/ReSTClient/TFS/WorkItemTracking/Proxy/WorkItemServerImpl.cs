using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class WorkItemServerImpl : IWorkItemServer, IITfsTeamProjectCollectionObject, IITfsRequestListener
    {
        void IITfsRequestListener.AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsRequestListener.BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int64 IITfsRequestListener.BeginRequest() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IWorkItemServer.BulkUpdate(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.DestroyAttachments(String requestId, Int32[] workItemIds) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IWorkItemServer.DownloadFile(Int32 fileAttachmentId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsRequestListener.EndRequest(Int64 requestId, Exception exception) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IWorkItemId> IWorkItemServer.GetChangedWorkItemIds(String requestId, Int64 rowVersion) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IWorkItemId> IWorkItemServer.GetDestroyedWorkItemIds(String requestId, Int64 rowVersion) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetMetadata(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetMetadataEx(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity, out String callerIdentitySid) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetMetadataEx2(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out Int32 displayMode) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String[] IWorkItemServer.GetReferencingWorkitemUris(String requestId, String artifactUri) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetStoredQueries(String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetStoredQuery(String requestId, Boolean useMaster, Guid queryId, out IRowSetCollection queryDataSet) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IExtendedAccessControlListData IWorkItemServer.GetStoredQueryItemAccessControlList(String requestId, Guid queryItemId, Boolean getMetadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetStoredQueryItems(String requestId, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.GetWorkItem(String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, DateTime? asOfDate, Boolean useMaster, out IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIResultCollection<IArtifactWorkItemIds> IWorkItemServer.GetWorkItemIdsForArtifactUris(String[] artifactUris, DateTime? asOfDate) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerable<IWorkItemLinkChange> IWorkItemServer.GetWorkItemLinkChanges(String requestId, Int64 rowVersion) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String IWorkItemServer.GetWorkitemTrackingVersion(String requestId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int64 IWorkItemServer.MaxAttachmentSize { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IWorkItemServer.PageWorkitemsByIdRevs(String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, out DateTime pageDate, Boolean useMaster, out IIPagedItemsRowSets items) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.PageWorkitemsByIds(String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, Boolean useMaster, out IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.QueryLinkedWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IWorkItemRelation[] relations, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.QueryWorkitemCount(String requestId, XmlElement psQuery, Boolean useMaster, out Int32 count, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.QueryWorkitemRevisions(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IIdRevisionPair[] pairs, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.QueryWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out Int32[] ids, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.RequestCancel(String requestId, String cancelRequestId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.StampWorkitemCache(String requestId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.SyncBisGroupsAndUsers(String requestId, String projectUri) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.SyncExternalStructures(String requestId, String projectURI) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.Update(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.UpdateMaxAttachmentSize() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IWorkItemServer.UploadFile(IFileAttachment fileAttachment) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWorkItemServerVersion IWorkItemServer.WorkItemServerVersion { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}