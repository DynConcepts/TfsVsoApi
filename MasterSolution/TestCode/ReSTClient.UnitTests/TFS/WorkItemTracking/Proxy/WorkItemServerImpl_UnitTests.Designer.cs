using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemServerImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BulkUpdate_UnitTest()
        {
            String requestId = default(String);
            XmlElement package = default(XmlElement);
            XmlElement result = default(XmlElement);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    package = default(XmlElement); //No Type
                    result = default(XmlElement); //No Type
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    BulkUpdate_PreCondition(ref instance, ref requestId, ref package, ref result, ref metadataHave, ref dbStamp, ref metadata);
                },
                instance => { instance.BulkUpdate(requestId, package, out result, metadataHave, out dbStamp, out metadata); },
                instance => { BulkUpdate_PostValidate(instance, requestId, package, result, metadataHave, dbStamp, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DestroyAttachments_UnitTest()
        {
            String requestId = default(String);
            Int32[] workItemIds = default(Int32[]);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    workItemIds = default(Int32[]); //No Constructor
                    DestroyAttachments_PreCondition(ref instance, ref requestId, ref workItemIds);
                },
                instance => { instance.DestroyAttachments(requestId, workItemIds); },
                instance => { DestroyAttachments_PostValidate(instance, requestId, workItemIds); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DownloadFile_UnitTest()
        {
            Int32 fileAttachmentId = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    fileAttachmentId = default(Int32); //No Constructor
                    DownloadFile_PreCondition(ref instance, ref fileAttachmentId);
                },
                instance => { instance.DownloadFile(fileAttachmentId); },
                instance => { DownloadFile_PostValidate(instance, fileAttachmentId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetChangedWorkItemIds_UnitTest()
        {
            String requestId = default(String);
            Int64 rowVersion = default(Int64);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    rowVersion = default(Int64); //No Constructor
                    GetChangedWorkItemIds_PreCondition(ref instance, ref requestId, ref rowVersion);
                },
                instance => { instance.GetChangedWorkItemIds(requestId, rowVersion); },
                instance => { GetChangedWorkItemIds_PostValidate(instance, requestId, rowVersion); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDestroyedWorkItemIds_UnitTest()
        {
            String requestId = default(String);
            Int64 rowVersion = default(Int64);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    rowVersion = default(Int64); //No Constructor
                    GetDestroyedWorkItemIds_PreCondition(ref instance, ref requestId, ref rowVersion);
                },
                instance => { instance.GetDestroyedWorkItemIds(requestId, rowVersion); },
                instance => { GetDestroyedWorkItemIds_PostValidate(instance, requestId, rowVersion); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetMetadataEx2_UnitTest()
        {
            String requestId = default(String);
            Boolean useMaster = default(Boolean);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            Int32 locale = default(Int32);
            Int32 comparisonStyle = default(Int32);
            Int32 displayMode = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    useMaster = default(Boolean); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    locale = default(Int32); //No Constructor
                    comparisonStyle = default(Int32); //No Constructor
                    displayMode = default(Int32); //No Constructor
                    GetMetadataEx2_PreCondition(ref instance, ref requestId, ref useMaster, ref metadataHave, ref dbStamp, ref metadata, ref locale, ref comparisonStyle, ref displayMode);
                },
                instance => { instance.GetMetadataEx2(requestId, useMaster, metadataHave, out dbStamp, out metadata, out locale, out comparisonStyle, out displayMode); },
                instance => { GetMetadataEx2_PostValidate(instance, requestId, useMaster, metadataHave, dbStamp, metadata, locale, comparisonStyle, displayMode); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetMetadataEx_UnitTest()
        {
            String requestId = default(String);
            Boolean useMaster = default(Boolean);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            Int32 locale = default(Int32);
            Int32 comparisonStyle = default(Int32);
            String callerIdentity = default(String);
            String callerIdentitySid = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    useMaster = default(Boolean); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    locale = default(Int32); //No Constructor
                    comparisonStyle = default(Int32); //No Constructor
                    callerIdentity = default(String); //No Constructor
                    callerIdentitySid = default(String); //No Constructor
                    GetMetadataEx_PreCondition(ref instance, ref requestId, ref useMaster, ref metadataHave, ref dbStamp, ref metadata, ref locale, ref comparisonStyle, ref callerIdentity, ref callerIdentitySid);
                },
                instance => { instance.GetMetadataEx(requestId, useMaster, metadataHave, out dbStamp, out metadata, out locale, out comparisonStyle, out callerIdentity, out callerIdentitySid); },
                instance => { GetMetadataEx_PostValidate(instance, requestId, useMaster, metadataHave, dbStamp, metadata, locale, comparisonStyle, callerIdentity, callerIdentitySid); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetMetadata_UnitTest()
        {
            String requestId = default(String);
            Boolean useMaster = default(Boolean);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            Int32 locale = default(Int32);
            Int32 comparisonStyle = default(Int32);
            String callerIdentity = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    useMaster = default(Boolean); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    locale = default(Int32); //No Constructor
                    comparisonStyle = default(Int32); //No Constructor
                    callerIdentity = default(String); //No Constructor
                    GetMetadata_PreCondition(ref instance, ref requestId, ref useMaster, ref metadataHave, ref dbStamp, ref metadata, ref locale, ref comparisonStyle, ref callerIdentity);
                },
                instance => { instance.GetMetadata(requestId, useMaster, metadataHave, out dbStamp, out metadata, out locale, out comparisonStyle, out callerIdentity); },
                instance => { GetMetadata_PostValidate(instance, requestId, useMaster, metadataHave, dbStamp, metadata, locale, comparisonStyle, callerIdentity); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetReferencingWorkitemUris_UnitTest()
        {
            String requestId = default(String);
            String artifactUri = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    artifactUri = default(String); //No Constructor
                    GetReferencingWorkitemUris_PreCondition(ref instance, ref requestId, ref artifactUri);
                },
                instance => { instance.GetReferencingWorkitemUris(requestId, artifactUri); },
                instance => { GetReferencingWorkitemUris_PostValidate(instance, requestId, artifactUri); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetStoredQueries_UnitTest()
        {
            String requestId = default(String);
            Boolean useMaster = default(Boolean);
            Int64 rowVersion = default(Int64);
            Int32 projectId = default(Int32);
            IRowSetCollection queriesDataSet = default(IRowSetCollection);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    useMaster = default(Boolean); //No Constructor
                    rowVersion = default(Int64); //No Constructor
                    projectId = default(Int32); //No Constructor
                    queriesDataSet = RowSetCollectionImpl_UnitTests.GetInstance();
                    GetStoredQueries_PreCondition(ref instance, ref requestId, ref useMaster, ref rowVersion, ref projectId, ref queriesDataSet);
                },
                instance => { instance.GetStoredQueries(requestId, useMaster, rowVersion, projectId, out queriesDataSet); },
                instance => { GetStoredQueries_PostValidate(instance, requestId, useMaster, rowVersion, projectId, queriesDataSet); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetStoredQueryItemAccessControlList_UnitTest()
        {
            String requestId = default(String);
            Guid queryItemId = default(Guid);
            Boolean getMetadata = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    queryItemId = default(Guid); //No Constructor
                    getMetadata = default(Boolean); //No Constructor
                    GetStoredQueryItemAccessControlList_PreCondition(ref instance, ref requestId, ref queryItemId, ref getMetadata);
                },
                instance => { instance.GetStoredQueryItemAccessControlList(requestId, queryItemId, getMetadata); },
                instance => { GetStoredQueryItemAccessControlList_PostValidate(instance, requestId, queryItemId, getMetadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetStoredQueryItems_UnitTest()
        {
            String requestId = default(String);
            Int64 rowVersion = default(Int64);
            Int32 projectId = default(Int32);
            IRowSetCollection queriesDataSet = default(IRowSetCollection);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    rowVersion = default(Int64); //No Constructor
                    projectId = default(Int32); //No Constructor
                    queriesDataSet = RowSetCollectionImpl_UnitTests.GetInstance();
                    GetStoredQueryItems_PreCondition(ref instance, ref requestId, ref rowVersion, ref projectId, ref queriesDataSet);
                },
                instance => { instance.GetStoredQueryItems(requestId, rowVersion, projectId, out queriesDataSet); },
                instance => { GetStoredQueryItems_PostValidate(instance, requestId, rowVersion, projectId, queriesDataSet); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetStoredQuery_UnitTest()
        {
            String requestId = default(String);
            Boolean useMaster = default(Boolean);
            Guid queryId = default(Guid);
            IRowSetCollection queryDataSet = default(IRowSetCollection);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    useMaster = default(Boolean); //No Constructor
                    queryId = default(Guid); //No Constructor
                    queryDataSet = RowSetCollectionImpl_UnitTests.GetInstance();
                    GetStoredQuery_PreCondition(ref instance, ref requestId, ref useMaster, ref queryId, ref queryDataSet);
                },
                instance => { instance.GetStoredQuery(requestId, useMaster, queryId, out queryDataSet); },
                instance => { GetStoredQuery_PostValidate(instance, requestId, useMaster, queryId, queryDataSet); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItemIdsForArtifactUris_UnitTest()
        {
            String[] artifactUris = default(String[]);
            DateTime? asOfDate = default(DateTime?);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    artifactUris = default(String[]); //No Constructor
                    asOfDate = default(DateTime?); //No Type
                    GetWorkItemIdsForArtifactUris_PreCondition(ref instance, ref artifactUris, ref asOfDate);
                },
                instance => { instance.GetWorkItemIdsForArtifactUris(artifactUris, asOfDate); },
                instance => { GetWorkItemIdsForArtifactUris_PostValidate(instance, artifactUris, asOfDate); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItemLinkChanges_UnitTest()
        {
            String requestId = default(String);
            Int64 rowVersion = default(Int64);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    rowVersion = default(Int64); //No Constructor
                    GetWorkItemLinkChanges_PreCondition(ref instance, ref requestId, ref rowVersion);
                },
                instance => { instance.GetWorkItemLinkChanges(requestId, rowVersion); },
                instance => { GetWorkItemLinkChanges_PostValidate(instance, requestId, rowVersion); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkItem_UnitTest()
        {
            String requestId = default(String);
            Int32 workItemId = default(Int32);
            Int32 revisionId = default(Int32);
            Int32 minimumRevisionId = default(Int32);
            DateTime? asOfDate = default(DateTime?);
            Boolean useMaster = default(Boolean);
            IIWorkItemRowSets workItem = default(IIWorkItemRowSets);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    workItemId = default(Int32); //No Constructor
                    revisionId = default(Int32); //No Constructor
                    minimumRevisionId = default(Int32); //No Constructor
                    asOfDate = default(DateTime?); //No Type
                    useMaster = default(Boolean); //No Constructor
                    workItem = IWorkItemRowSetsImpl_UnitTests.GetInstance();
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    GetWorkItem_PreCondition(ref instance, ref requestId, ref workItemId, ref revisionId, ref minimumRevisionId, ref asOfDate, ref useMaster, ref workItem, ref metadataHave, ref dbStamp, ref metadata);
                },
                instance => { instance.GetWorkItem(requestId, workItemId, revisionId, minimumRevisionId, asOfDate, useMaster, out workItem, metadataHave, out dbStamp, out metadata); },
                instance => { GetWorkItem_PostValidate(instance, requestId, workItemId, revisionId, minimumRevisionId, asOfDate, useMaster, workItem, metadataHave, dbStamp, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetWorkitemTrackingVersion_UnitTest()
        {
            String requestId = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    GetWorkitemTrackingVersion_PreCondition(ref instance, ref requestId);
                },
                instance => { instance.GetWorkitemTrackingVersion(requestId); },
                instance => { GetWorkitemTrackingVersion_PostValidate(instance, requestId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MaxAttachmentSize_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.MaxAttachmentSize; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PageWorkitemsByIdRevs_UnitTest()
        {
            String requestId = default(String);
            IIdRevisionPair[] pairs = default(IIdRevisionPair[]);
            String[] columns = default(String[]);
            Int32[] longTextColumns = default(Int32[]);
            DateTime? asOfDate = default(DateTime?);
            DateTime pageDate = default(DateTime);
            Boolean useMaster = default(Boolean);
            IIPagedItemsRowSets items = default(IIPagedItemsRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    pairs = new[] {(IIdRevisionPair) IdRevisionPairImpl_UnitTests.GetInstance()};
                    columns = default(String[]); //No Constructor
                    longTextColumns = default(Int32[]); //No Constructor
                    asOfDate = default(DateTime?); //No Type
                    pageDate = default(DateTime); //No Constructor
                    useMaster = default(Boolean); //No Constructor
                    items = IPagedItemsRowSetsImpl_UnitTests.GetInstance();
                    PageWorkitemsByIdRevs_PreCondition(ref instance, ref requestId, ref pairs, ref columns, ref longTextColumns, ref asOfDate, ref pageDate, ref useMaster, ref items);
                },
                instance => { instance.PageWorkitemsByIdRevs(requestId, pairs, columns, longTextColumns, asOfDate, out pageDate, useMaster, out items); },
                instance => { PageWorkitemsByIdRevs_PostValidate(instance, requestId, pairs, columns, longTextColumns, asOfDate, pageDate, useMaster, items); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PageWorkitemsByIds_UnitTest()
        {
            String requestId = default(String);
            Int32[] ids = default(Int32[]);
            String[] columns = default(String[]);
            Int32[] longTextColumns = default(Int32[]);
            DateTime? asOfDate = default(DateTime?);
            Boolean useMaster = default(Boolean);
            IIPagedItemsRowSets items = default(IIPagedItemsRowSets);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    ids = default(Int32[]); //No Constructor
                    columns = default(String[]); //No Constructor
                    longTextColumns = default(Int32[]); //No Constructor
                    asOfDate = default(DateTime?); //No Type
                    useMaster = default(Boolean); //No Constructor
                    items = IPagedItemsRowSetsImpl_UnitTests.GetInstance();
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    PageWorkitemsByIds_PreCondition(ref instance, ref requestId, ref ids, ref columns, ref longTextColumns, ref asOfDate, ref useMaster, ref items, ref metadataHave, ref metadata);
                },
                instance => { instance.PageWorkitemsByIds(requestId, ids, columns, longTextColumns, asOfDate, useMaster, out items, metadataHave, out metadata); },
                instance => { PageWorkitemsByIds_PostValidate(instance, requestId, ids, columns, longTextColumns, asOfDate, useMaster, items, metadataHave, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryLinkedWorkitems_UnitTest()
        {
            String requestId = default(String);
            XmlElement psQuery = default(XmlElement);
            IQuerySortOrderEntry[] sort = default(IQuerySortOrderEntry[]);
            Boolean useMaster = default(Boolean);
            IWorkItemRelation[] relations = default(IWorkItemRelation[]);
            DateTime asOfDate = default(DateTime);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    psQuery = default(XmlElement); //No Type
                    sort = new[] {(IQuerySortOrderEntry) QuerySortOrderEntryImpl_UnitTests.GetInstance()};
                    useMaster = default(Boolean); //No Constructor
                    relations = new[] {(IWorkItemRelation) WorkItemRelationImpl_UnitTests.GetInstance()};
                    asOfDate = default(DateTime); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    QueryLinkedWorkitems_PreCondition(ref instance, ref requestId, ref psQuery, ref sort, ref useMaster, ref relations, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
                },
                instance => { instance.QueryLinkedWorkitems(requestId, psQuery, sort, useMaster, out relations, out asOfDate, metadataHave, out dbStamp, out metadata); },
                instance => { QueryLinkedWorkitems_PostValidate(instance, requestId, psQuery, sort, useMaster, relations, asOfDate, metadataHave, dbStamp, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryWorkitemCount_UnitTest()
        {
            String requestId = default(String);
            XmlElement psQuery = default(XmlElement);
            Boolean useMaster = default(Boolean);
            Int32 count = default(Int32);
            DateTime asOfDate = default(DateTime);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    psQuery = default(XmlElement); //No Type
                    useMaster = default(Boolean); //No Constructor
                    count = default(Int32); //No Constructor
                    asOfDate = default(DateTime); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    QueryWorkitemCount_PreCondition(ref instance, ref requestId, ref psQuery, ref useMaster, ref count, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
                },
                instance => { instance.QueryWorkitemCount(requestId, psQuery, useMaster, out count, out asOfDate, metadataHave, out dbStamp, out metadata); },
                instance => { QueryWorkitemCount_PostValidate(instance, requestId, psQuery, useMaster, count, asOfDate, metadataHave, dbStamp, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryWorkitemRevisions_UnitTest()
        {
            String requestId = default(String);
            XmlElement psQuery = default(XmlElement);
            IQuerySortOrderEntry[] sort = default(IQuerySortOrderEntry[]);
            Boolean useMaster = default(Boolean);
            IIdRevisionPair[] pairs = default(IIdRevisionPair[]);
            DateTime asOfDate = default(DateTime);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    psQuery = default(XmlElement); //No Type
                    sort = new[] {(IQuerySortOrderEntry) QuerySortOrderEntryImpl_UnitTests.GetInstance()};
                    useMaster = default(Boolean); //No Constructor
                    pairs = new[] {(IIdRevisionPair) IdRevisionPairImpl_UnitTests.GetInstance()};
                    asOfDate = default(DateTime); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    QueryWorkitemRevisions_PreCondition(ref instance, ref requestId, ref psQuery, ref sort, ref useMaster, ref pairs, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
                },
                instance => { instance.QueryWorkitemRevisions(requestId, psQuery, sort, useMaster, out pairs, out asOfDate, metadataHave, out dbStamp, out metadata); },
                instance => { QueryWorkitemRevisions_PostValidate(instance, requestId, psQuery, sort, useMaster, pairs, asOfDate, metadataHave, dbStamp, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryWorkitems_UnitTest()
        {
            String requestId = default(String);
            XmlElement psQuery = default(XmlElement);
            IQuerySortOrderEntry[] sort = default(IQuerySortOrderEntry[]);
            Boolean useMaster = default(Boolean);
            Int32[] ids = default(Int32[]);
            DateTime asOfDate = default(DateTime);
            IMetadataTableHaveEntry[] metadataHave = default(IMetadataTableHaveEntry[]);
            String dbStamp = default(String);
            IIMetadataRowSets metadata = default(IIMetadataRowSets);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    psQuery = default(XmlElement); //No Type
                    sort = new[] {(IQuerySortOrderEntry) QuerySortOrderEntryImpl_UnitTests.GetInstance()};
                    useMaster = default(Boolean); //No Constructor
                    ids = default(Int32[]); //No Constructor
                    asOfDate = default(DateTime); //No Constructor
                    metadataHave = new[] {(IMetadataTableHaveEntry) MetadataTableHaveEntryImpl_UnitTests.GetInstance()};
                    dbStamp = default(String); //No Constructor
                    metadata = IMetadataRowSetsImpl_UnitTests.GetInstance();
                    QueryWorkitems_PreCondition(ref instance, ref requestId, ref psQuery, ref sort, ref useMaster, ref ids, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
                },
                instance => { instance.QueryWorkitems(requestId, psQuery, sort, useMaster, out ids, out asOfDate, metadataHave, out dbStamp, out metadata); },
                instance => { QueryWorkitems_PostValidate(instance, requestId, psQuery, sort, useMaster, ids, asOfDate, metadataHave, dbStamp, metadata); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RequestCancel_UnitTest()
        {
            String requestId = default(String);
            String cancelRequestId = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    cancelRequestId = default(String); //No Constructor
                    RequestCancel_PreCondition(ref instance, ref requestId, ref cancelRequestId);
                },
                instance => { instance.RequestCancel(requestId, cancelRequestId); },
                instance => { RequestCancel_PostValidate(instance, requestId, cancelRequestId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void StampWorkitemCache_UnitTest()
        {
            String requestId = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    StampWorkitemCache_PreCondition(ref instance, ref requestId);
                },
                instance => { instance.StampWorkitemCache(requestId); },
                instance => { StampWorkitemCache_PostValidate(instance, requestId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncBisGroupsAndUsers_UnitTest()
        {
            String requestId = default(String);
            String projectUri = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    projectUri = default(String); //No Constructor
                    SyncBisGroupsAndUsers_PreCondition(ref instance, ref requestId, ref projectUri);
                },
                instance => { instance.SyncBisGroupsAndUsers(requestId, projectUri); },
                instance => { SyncBisGroupsAndUsers_PostValidate(instance, requestId, projectUri); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncExternalStructures_UnitTest()
        {
            String requestId = default(String);
            String projectURI = default(String);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    requestId = default(String); //No Constructor
                    projectURI = default(String); //No Constructor
                    SyncExternalStructures_PreCondition(ref instance, ref requestId, ref projectURI);
                },
                instance => { instance.SyncExternalStructures(requestId, projectURI); },
                instance => { SyncExternalStructures_PostValidate(instance, requestId, projectURI); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UpdateMaxAttachmentSize_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance => { UpdateMaxAttachmentSize_PreCondition(ref instance); },
                instance => { instance.UpdateMaxAttachmentSize(); },
                instance => { UpdateMaxAttachmentSize_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UploadFile_UnitTest()
        {
            IFileAttachment fileAttachment = default(IFileAttachment);
            ExecuteMethod(
                () => { return (IWorkItemServer) GetInstance(); },
                instance =>
                {
                    fileAttachment = FileAttachmentImpl_UnitTests.GetInstance();
                    UploadFile_PreCondition(ref instance, ref fileAttachment);
                },
                instance => { instance.UploadFile(fileAttachment); },
                instance => { UploadFile_PostValidate(instance, fileAttachment); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemServerVersion_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemServer) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemServerVersion; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void BulkUpdate_PostValidate(IWorkItemServer instance, String requestId, XmlElement package, XmlElement result, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata);
        partial void BulkUpdate_PreCondition(ref IWorkItemServer instance, ref String requestId, ref XmlElement package, ref XmlElement result, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata);
        partial void DestroyAttachments_PostValidate(IWorkItemServer instance, String requestId, Int32[] workItemIds);
        partial void DestroyAttachments_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int32[] workItemIds);

        partial void DownloadFile_PostValidate(IWorkItemServer instance, Int32 fileAttachmentId);
        partial void DownloadFile_PreCondition(ref IWorkItemServer instance, ref Int32 fileAttachmentId);
        partial void GetChangedWorkItemIds_PostValidate(IWorkItemServer instance, String requestId, Int64 rowVersion);
        partial void GetChangedWorkItemIds_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int64 rowVersion);
        partial void GetDestroyedWorkItemIds_PostValidate(IWorkItemServer instance, String requestId, Int64 rowVersion);
        partial void GetDestroyedWorkItemIds_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int64 rowVersion);
        internal static IEnumerable<WorkItemServerImpl> GetIEnumerableInstance() { return new List<WorkItemServerImpl> {GetInstance()}; }

        internal static WorkItemServerImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemServerImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetMetadataEx2_PostValidate(IWorkItemServer instance, String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata, Int32 locale, Int32 comparisonStyle, Int32 displayMode);
        partial void GetMetadataEx2_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Boolean useMaster, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata, ref Int32 locale, ref Int32 comparisonStyle, ref Int32 displayMode);
        partial void GetMetadataEx_PostValidate(IWorkItemServer instance, String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata, Int32 locale, Int32 comparisonStyle, String callerIdentity, String callerIdentitySid);
        partial void GetMetadataEx_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Boolean useMaster, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata, ref Int32 locale, ref Int32 comparisonStyle, ref String callerIdentity, ref String callerIdentitySid);
        partial void GetMetadata_PostValidate(IWorkItemServer instance, String requestId, Boolean useMaster, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata, Int32 locale, Int32 comparisonStyle, String callerIdentity);
        partial void GetMetadata_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Boolean useMaster, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata, ref Int32 locale, ref Int32 comparisonStyle, ref String callerIdentity);
        partial void GetReferencingWorkitemUris_PostValidate(IWorkItemServer instance, String requestId, String artifactUri);
        partial void GetReferencingWorkitemUris_PreCondition(ref IWorkItemServer instance, ref String requestId, ref String artifactUri);

        partial void GetStoredQueries_PostValidate(IWorkItemServer instance, String requestId, Boolean useMaster, Int64 rowVersion, Int32 projectId, IRowSetCollection queriesDataSet);
        partial void GetStoredQueries_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Boolean useMaster, ref Int64 rowVersion, ref Int32 projectId, ref IRowSetCollection queriesDataSet);
        partial void GetStoredQueryItemAccessControlList_PostValidate(IWorkItemServer instance, String requestId, Guid queryItemId, Boolean getMetadata);
        partial void GetStoredQueryItemAccessControlList_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Guid queryItemId, ref Boolean getMetadata);

        partial void GetStoredQueryItems_PostValidate(IWorkItemServer instance, String requestId, Int64 rowVersion, Int32 projectId, IRowSetCollection queriesDataSet);
        partial void GetStoredQueryItems_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int64 rowVersion, ref Int32 projectId, ref IRowSetCollection queriesDataSet);
        partial void GetStoredQuery_PostValidate(IWorkItemServer instance, String requestId, Boolean useMaster, Guid queryId, IRowSetCollection queryDataSet);
        partial void GetStoredQuery_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Boolean useMaster, ref Guid queryId, ref IRowSetCollection queryDataSet);
        partial void GetWorkItemIdsForArtifactUris_PostValidate(IWorkItemServer instance, String[] artifactUris, DateTime? asOfDate);
        partial void GetWorkItemIdsForArtifactUris_PreCondition(ref IWorkItemServer instance, ref String[] artifactUris, ref DateTime? asOfDate);

        partial void GetWorkItemLinkChanges_PostValidate(IWorkItemServer instance, String requestId, Int64 rowVersion);
        partial void GetWorkItemLinkChanges_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int64 rowVersion);
        partial void GetWorkItem_PostValidate(IWorkItemServer instance, String requestId, Int32 workItemId, Int32 revisionId, Int32 minimumRevisionId, DateTime? asOfDate, Boolean useMaster, IIWorkItemRowSets workItem, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata);
        partial void GetWorkItem_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int32 workItemId, ref Int32 revisionId, ref Int32 minimumRevisionId, ref DateTime? asOfDate, ref Boolean useMaster, ref IIWorkItemRowSets workItem, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata);
        partial void GetWorkitemTrackingVersion_PostValidate(IWorkItemServer instance, String requestId);
        partial void GetWorkitemTrackingVersion_PreCondition(ref IWorkItemServer instance, ref String requestId);
        static partial void InstanceFactory(ref WorkItemServerImpl instance, [CallerMemberName] string callerName = "");
        partial void MaxAttachmentSize_SetCondition(ref IWorkItemServer instance, ref Int64 setValue);
        partial void PageWorkitemsByIdRevs_PostValidate(IWorkItemServer instance, String requestId, IIdRevisionPair[] pairs, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, DateTime pageDate, Boolean useMaster, IIPagedItemsRowSets items);
        partial void PageWorkitemsByIdRevs_PreCondition(ref IWorkItemServer instance, ref String requestId, ref IIdRevisionPair[] pairs, ref String[] columns, ref Int32[] longTextColumns, ref DateTime? asOfDate, ref DateTime pageDate, ref Boolean useMaster, ref IIPagedItemsRowSets items);
        partial void PageWorkitemsByIds_PostValidate(IWorkItemServer instance, String requestId, Int32[] ids, String[] columns, Int32[] longTextColumns, DateTime? asOfDate, Boolean useMaster, IIPagedItemsRowSets items, IMetadataTableHaveEntry[] metadataHave, IIMetadataRowSets metadata);
        partial void PageWorkitemsByIds_PreCondition(ref IWorkItemServer instance, ref String requestId, ref Int32[] ids, ref String[] columns, ref Int32[] longTextColumns, ref DateTime? asOfDate, ref Boolean useMaster, ref IIPagedItemsRowSets items, ref IMetadataTableHaveEntry[] metadataHave, ref IIMetadataRowSets metadata);
        partial void QueryLinkedWorkitems_PostValidate(IWorkItemServer instance, String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, IWorkItemRelation[] relations, DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata);
        partial void QueryLinkedWorkitems_PreCondition(ref IWorkItemServer instance, ref String requestId, ref XmlElement psQuery, ref IQuerySortOrderEntry[] sort, ref Boolean useMaster, ref IWorkItemRelation[] relations, ref DateTime asOfDate, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata);
        partial void QueryWorkitemCount_PostValidate(IWorkItemServer instance, String requestId, XmlElement psQuery, Boolean useMaster, Int32 count, DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata);
        partial void QueryWorkitemCount_PreCondition(ref IWorkItemServer instance, ref String requestId, ref XmlElement psQuery, ref Boolean useMaster, ref Int32 count, ref DateTime asOfDate, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata);
        partial void QueryWorkitemRevisions_PostValidate(IWorkItemServer instance, String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, IIdRevisionPair[] pairs, DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata);
        partial void QueryWorkitemRevisions_PreCondition(ref IWorkItemServer instance, ref String requestId, ref XmlElement psQuery, ref IQuerySortOrderEntry[] sort, ref Boolean useMaster, ref IIdRevisionPair[] pairs, ref DateTime asOfDate, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata);
        partial void QueryWorkitems_PostValidate(IWorkItemServer instance, String requestId, XmlElement psQuery, IQuerySortOrderEntry[] sort, Boolean useMaster, Int32[] ids, DateTime asOfDate, IMetadataTableHaveEntry[] metadataHave, String dbStamp, IIMetadataRowSets metadata);
        partial void QueryWorkitems_PreCondition(ref IWorkItemServer instance, ref String requestId, ref XmlElement psQuery, ref IQuerySortOrderEntry[] sort, ref Boolean useMaster, ref Int32[] ids, ref DateTime asOfDate, ref IMetadataTableHaveEntry[] metadataHave, ref String dbStamp, ref IIMetadataRowSets metadata);

        partial void RequestCancel_PostValidate(IWorkItemServer instance, String requestId, String cancelRequestId);
        partial void RequestCancel_PreCondition(ref IWorkItemServer instance, ref String requestId, ref String cancelRequestId);
        partial void StampWorkitemCache_PostValidate(IWorkItemServer instance, String requestId);
        partial void StampWorkitemCache_PreCondition(ref IWorkItemServer instance, ref String requestId);

        partial void SyncBisGroupsAndUsers_PostValidate(IWorkItemServer instance, String requestId, String projectUri);
        partial void SyncBisGroupsAndUsers_PreCondition(ref IWorkItemServer instance, ref String requestId, ref String projectUri);
        partial void SyncExternalStructures_PostValidate(IWorkItemServer instance, String requestId, String projectURI);
        partial void SyncExternalStructures_PreCondition(ref IWorkItemServer instance, ref String requestId, ref String projectURI);
        partial void UpdateMaxAttachmentSize_PostValidate(IWorkItemServer instance);
        partial void UpdateMaxAttachmentSize_PreCondition(ref IWorkItemServer instance);
        partial void UploadFile_PostValidate(IWorkItemServer instance, IFileAttachment fileAttachment);
        partial void UploadFile_PreCondition(ref IWorkItemServer instance, ref IFileAttachment fileAttachment);

        partial void WorkItemServerVersion_SetCondition(ref IWorkItemServer instance, ref IWorkItemServerVersion setValue);
    }
}