using System;
using System.Collections.Generic;
using System.Net;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.TeamFoundation.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class WorkItemServerWrapper : WorkItemServerWrapper<IWorkItemServer, WorkItemServer>, IWorkItemServer, IITfsTeamProjectCollectionObject, IITfsRequestListener
    {
        protected WorkItemServerWrapper(WorkItemServer instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemServer, WorkItemServer>(src => src==null ? null : ((WorkItemServerWrapper) src).r_Instance, src => new WorkItemServerWrapper(src)); }
    }


    internal class WorkItemServerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemServer where TInterface : class where TWrapper : class
    {

        void IITfsRequestListener.AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response) { ((ITfsRequestListener) r_Instance).AfterReceiveReply(requestId, methodName, response); }

        void IITfsRequestListener.BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request) { ((ITfsRequestListener) r_Instance).BeforeSendRequest(requestId, methodName, request); }

        Int64 IITfsRequestListener.BeginRequest()
        {
            long nativeCallResult = ((ITfsRequestListener) r_Instance).BeginRequest();
            return nativeCallResult;
        }

        Boolean IWorkItemServer.BulkUpdate(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            XmlElement tmp_result;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            bool nativeCallResult = r_Instance.BulkUpdate(requestId, package, out tmp_result, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            result = tmp_result;
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
            return nativeCallResult;
        }

        void IWorkItemServer.DestroyAttachments(String requestId, Int32[] workItemIds) { r_Instance.DestroyAttachments(requestId, workItemIds); }

        String IWorkItemServer.DownloadFile(Int32 fileAttachmentId)
        {
            string nativeCallResult = r_Instance.DownloadFile(fileAttachmentId);
            return nativeCallResult;
        }

        void IITfsRequestListener.EndRequest(Int64 requestId, Exception exception) { ((ITfsRequestListener) r_Instance).EndRequest(requestId, exception); }

        IEnumerable<IWorkItemId> IWorkItemServer.GetChangedWorkItemIds(String requestId, Int64 rowVersion)
        {
            IEnumerable<WorkItemId> nativeCallResult = r_Instance.GetChangedWorkItemIds(requestId, rowVersion);
            IEnumerable<IWorkItemId> wrappedCallResult = WorkItemIdWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IEnumerable<IWorkItemId> IWorkItemServer.GetDestroyedWorkItemIds(String requestId, Int64 rowVersion)
        {
            IEnumerable<WorkItemId> nativeCallResult = r_Instance.GetDestroyedWorkItemIds(requestId, rowVersion);
            IEnumerable<IWorkItemId> wrappedCallResult = WorkItemIdWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        void IWorkItemServer.GetMetadata(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity)
        {
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            Int32 tmp_locale;
            Int32 tmp_comparisonStyle;
            String tmp_callerIdentity;
            r_Instance.GetMetadata(requestId, useMaster, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata, out tmp_locale, out tmp_comparisonStyle, out tmp_callerIdentity);
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
            locale = tmp_locale;
            comparisonStyle = tmp_comparisonStyle;
            callerIdentity = tmp_callerIdentity;
        }


        void IWorkItemServer.GetMetadataEx(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out String callerIdentity, out String callerIdentitySid)
        {
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            Int32 tmp_locale;
            Int32 tmp_comparisonStyle;
            String tmp_callerIdentity;
            String tmp_callerIdentitySid;
            r_Instance.GetMetadataEx(requestId, useMaster, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata, out tmp_locale, out tmp_comparisonStyle, out tmp_callerIdentity, out tmp_callerIdentitySid);
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
            locale = tmp_locale;
            comparisonStyle = tmp_comparisonStyle;
            callerIdentity = tmp_callerIdentity;
            callerIdentitySid = tmp_callerIdentitySid;
        }


        void IWorkItemServer.GetMetadataEx2(String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata, out Int32 locale, out Int32 comparisonStyle, out Int32 displayMode)
        {
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            Int32 tmp_locale;
            Int32 tmp_comparisonStyle;
            Int32 tmp_displayMode;
            r_Instance.GetMetadataEx2(requestId, useMaster, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata, out tmp_locale, out tmp_comparisonStyle, out tmp_displayMode);
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
            locale = tmp_locale;
            comparisonStyle = tmp_comparisonStyle;
            displayMode = tmp_displayMode;
        }

        String[] IWorkItemServer.GetReferencingWorkitemUris(String requestId, String artifactUri)
        {
            string[] nativeCallResult = r_Instance.GetReferencingWorkitemUris(requestId, artifactUri);
            return nativeCallResult;
        }




        void IWorkItemServer.GetStoredQueries(String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet)
        {
            RowSetCollection tmp_queriesDataSet;
            r_Instance.GetStoredQueries(requestId, useMaster, rowVersion, projectId, out tmp_queriesDataSet);
            queriesDataSet = RowSetCollectionWrapper.GetWrapper(tmp_queriesDataSet);
        }

        void IWorkItemServer.GetStoredQuery(String requestId, Boolean useMaster, Guid queryId, out IRowSetCollection queryDataSet)
        {
            RowSetCollection tmp_queryDataSet;
            r_Instance.GetStoredQuery(requestId, useMaster, queryId, out tmp_queryDataSet);
            queryDataSet = RowSetCollectionWrapper.GetWrapper(tmp_queryDataSet);
        }

        IExtendedAccessControlListData IWorkItemServer.GetStoredQueryItemAccessControlList(String requestId, Guid queryItemId, Boolean getMetadata)
        {
            ExtendedAccessControlListData nativeCallResult = r_Instance.GetStoredQueryItemAccessControlList(requestId, queryItemId, getMetadata);
            IExtendedAccessControlListData wrappedCallResult = ExtendedAccessControlListDataWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        void IWorkItemServer.GetStoredQueryItems(String requestId, Int64 rowVersion, Int32 projectId, out IRowSetCollection queriesDataSet)
        {
            RowSetCollection tmp_queriesDataSet;
            r_Instance.GetStoredQueryItems(requestId, rowVersion, projectId, out tmp_queriesDataSet);
            queriesDataSet = RowSetCollectionWrapper.GetWrapper(tmp_queriesDataSet);
        }

        void IWorkItemServer.GetWorkItem(String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, DateTime? asOfDate, Boolean useMaster, out IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            IWorkItemRowSets tmp_workItem;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            r_Instance.GetWorkItem(requestId, workItemId, revisionId, minimumRevisionId, asOfDate, useMaster, out tmp_workItem, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            workItem = IWorkItemRowSetsWrapper.GetWrapper(tmp_workItem);
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }

        IIResultCollection<IArtifactWorkItemIds> IWorkItemServer.GetWorkItemIdsForArtifactUris(String[] artifactUris, DateTime? asOfDate)
        {
            IResultCollection<ArtifactWorkItemIds> nativeCallResult = r_Instance.GetWorkItemIdsForArtifactUris(artifactUris, asOfDate);
            IIResultCollection<IArtifactWorkItemIds> wrappedCallResult = ArtifactWorkItemIdsWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }




        IEnumerable<IWorkItemLinkChange> IWorkItemServer.GetWorkItemLinkChanges(String requestId, Int64 rowVersion)
        {
            IEnumerable<WorkItemLinkChange> nativeCallResult = r_Instance.GetWorkItemLinkChanges(requestId, rowVersion);
            IEnumerable<IWorkItemLinkChange> wrappedCallResult = WorkItemLinkChangeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        String IWorkItemServer.GetWorkitemTrackingVersion(String requestId)
        {
            string nativeCallResult = r_Instance.GetWorkitemTrackingVersion(requestId);
            return nativeCallResult;
        }

        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { ((ITfsTeamProjectCollectionObject) r_Instance).Initialize(TfsTeamProjectCollectionWrapper.GetInstance(projectCollection)); }

        Int64 IWorkItemServer.MaxAttachmentSize
        {
            get
            {
                long nativeCallResult = r_Instance.MaxAttachmentSize;
                return nativeCallResult;
            }
        }

        void IWorkItemServer.PageWorkitemsByIdRevs(String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, out DateTime pageDate, Boolean useMaster, out IIPagedItemsRowSets items)
        {
            DateTime tmp_pageDate;
            IPagedItemsRowSets tmp_items;
            r_Instance.PageWorkitemsByIdRevs(requestId, IdRevisionPairWrapper.GetInstance(pairs), columns, longTextColumns, asOfDate, out tmp_pageDate, useMaster, out tmp_items);
            pageDate = tmp_pageDate;
            items = IPagedItemsRowSetsWrapper.GetWrapper(tmp_items);
        }

        void IWorkItemServer.PageWorkitemsByIds(String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, Boolean useMaster, out IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave, out IIMetadataRowSets metadata)
        {
            IPagedItemsRowSets tmp_items;
            IMetadataRowSets tmp_metadata;
            r_Instance.PageWorkitemsByIds(requestId, ids, columns, longTextColumns, asOfDate, useMaster, out tmp_items, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_metadata);
            items = IPagedItemsRowSetsWrapper.GetWrapper(tmp_items);
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }

        void IWorkItemServer.QueryLinkedWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IWorkItemRelation[] relations, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            WorkItemRelation[] tmp_relations;
            DateTime tmp_asOfDate;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            r_Instance.QueryLinkedWorkitems(requestId, psQuery, QuerySortOrderEntryWrapper.GetInstance(sort), useMaster, out tmp_relations, out tmp_asOfDate, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            relations = WorkItemRelationWrapper.GetWrapper(tmp_relations);
            asOfDate = tmp_asOfDate;
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }

        void IWorkItemServer.QueryWorkitemCount(String requestId, XmlElement psQuery, Boolean useMaster, out Int32 count, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            Int32 tmp_count;
            DateTime tmp_asOfDate;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            r_Instance.QueryWorkitemCount(requestId, psQuery, useMaster, out tmp_count, out tmp_asOfDate, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            count = tmp_count;
            asOfDate = tmp_asOfDate;
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }

        void IWorkItemServer.QueryWorkitemRevisions(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out IIdRevisionPair[] pairs, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            IdRevisionPair[] tmp_pairs;
            DateTime tmp_asOfDate;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            r_Instance.QueryWorkitemRevisions(requestId, psQuery, QuerySortOrderEntryWrapper.GetInstance(sort), useMaster, out tmp_pairs, out tmp_asOfDate, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            pairs = IdRevisionPairWrapper.GetWrapper(tmp_pairs);
            asOfDate = tmp_asOfDate;
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }


        void IWorkItemServer.QueryWorkitems(String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, out Int32[] ids, out DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            Int32[] tmp_ids;
            DateTime tmp_asOfDate;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            r_Instance.QueryWorkitems(requestId, psQuery, QuerySortOrderEntryWrapper.GetInstance(sort), useMaster, out tmp_ids, out tmp_asOfDate, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            ids = tmp_ids;
            asOfDate = tmp_asOfDate;
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }




        void IWorkItemServer.RequestCancel(String requestId, String cancelRequestId) { r_Instance.RequestCancel(requestId, cancelRequestId); }
        void IWorkItemServer.StampWorkitemCache(String requestId) { r_Instance.StampWorkitemCache(requestId); }


        void IWorkItemServer.SyncBisGroupsAndUsers(String requestId, String projectUri) { r_Instance.SyncBisGroupsAndUsers(requestId, projectUri); }
        void IWorkItemServer.SyncExternalStructures(String requestId, String projectURI) { r_Instance.SyncExternalStructures(requestId, projectURI); }

        void IWorkItemServer.Update(String requestId, XmlElement package, out XmlElement result, IMetadataTableHaveEntry[] metadataHave, out String dbStamp, out IIMetadataRowSets metadata)
        {
            XmlElement tmp_result;
            String tmp_dbStamp;
            IMetadataRowSets tmp_metadata;
            r_Instance.Update(requestId, package, out tmp_result, MetadataTableHaveEntryWrapper.GetInstance(metadataHave), out tmp_dbStamp, out tmp_metadata);
            result = tmp_result;
            dbStamp = tmp_dbStamp;
            metadata = IMetadataRowSetsWrapper.GetWrapper(tmp_metadata);
        }


        void IWorkItemServer.UpdateMaxAttachmentSize() { r_Instance.UpdateMaxAttachmentSize(); }

        void IWorkItemServer.UploadFile(IFileAttachment fileAttachment) { r_Instance.UploadFile(FileAttachmentWrapper.GetInstance(fileAttachment)); }


        IWorkItemServerVersion IWorkItemServer.WorkItemServerVersion
        {
            get
            {
                WorkItemServerVersion nativeCallResult = r_Instance.WorkItemServerVersion;
                IWorkItemServerVersion wrappedCallResult = WorkItemServerVersionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemServerWrapper(WorkItemServer instance) { r_Instance = instance; }
        protected readonly WorkItemServer r_Instance;
    }
}