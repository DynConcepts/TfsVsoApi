using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemServerWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.WorkItemServerWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.WorkItemServerWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Proxy.WorkItemServer);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.WorkItemServerWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.WorkItemServerWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Proxy.WorkItemServer real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.WorkItemServerWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.WorkItemServerWrapper>{ GetInstance() }; }

    partial void GetWorkitemTrackingVersion_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId);
    partial void GetWorkitemTrackingVersion_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetWorkitemTrackingVersion_UnitTest()
  {
    System.String requestId = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          GetWorkitemTrackingVersion_PreCondition(ref instance, ref requestId);
        },
       (instance) =>
       {
             instance.GetWorkitemTrackingVersion(requestId);
       },
      (instance) =>
      {
              GetWorkitemTrackingVersion_PostValidate(instance, requestId);
      });
  }
    partial void StampWorkitemCache_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId);
    partial void StampWorkitemCache_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void StampWorkitemCache_UnitTest()
  {
    System.String requestId = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          StampWorkitemCache_PreCondition(ref instance, ref requestId);
        },
       (instance) =>
       {
             instance.StampWorkitemCache(requestId);
       },
      (instance) =>
      {
              StampWorkitemCache_PostValidate(instance, requestId);
      });
  }
    partial void GetWorkItem_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int32 workItemId, ref System.Int32 revisionId, ref System.Int32 minimumRevisionId, ref System.Nullable<System.DateTime> asOfDate, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIWorkItemRowSets workItem, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void GetWorkItem_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int32 workItemId, System.Int32 revisionId, System.Int32 minimumRevisionId, System.Nullable<System.DateTime> asOfDate, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIWorkItemRowSets workItem, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetWorkItem_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int32 workItemId = default(System.Int32);
    System.Int32 revisionId = default(System.Int32);
    System.Int32 minimumRevisionId = default(System.Int32);
    System.Nullable<System.DateTime> asOfDate = default(System.Nullable<System.DateTime>);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIWorkItemRowSets workItem = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIWorkItemRowSets);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          workItemId = default(System.Int32); //No Constructor
          revisionId = default(System.Int32); //No Constructor
          minimumRevisionId = default(System.Int32); //No Constructor
          asOfDate = default(System.Nullable<System.DateTime>); //No Type
          useMaster = default(System.Boolean); //No Constructor
          workItem = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IWorkItemRowSetsWrapper_UnitTests.GetInstance();
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          GetWorkItem_PreCondition(ref instance, ref requestId, ref workItemId, ref revisionId, ref minimumRevisionId, ref asOfDate, ref useMaster, ref workItem, ref metadataHave, ref dbStamp, ref metadata);
        },
       (instance) =>
       {
             instance.GetWorkItem(requestId,workItemId,revisionId,minimumRevisionId,asOfDate,useMaster, out workItem,metadataHave, out dbStamp, out metadata);
       },
      (instance) =>
      {
              GetWorkItem_PostValidate(instance, requestId, workItemId, revisionId, minimumRevisionId, asOfDate, useMaster, workItem, metadataHave, dbStamp, metadata);
      });
  }
    partial void QueryWorkitemRevisions_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Xml.XmlElement psQuery, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[] pairs, ref System.DateTime asOfDate, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void QueryWorkitemRevisions_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Xml.XmlElement psQuery, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[] pairs, System.DateTime asOfDate, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryWorkitemRevisions_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Xml.XmlElement psQuery = default(System.Xml.XmlElement);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[]);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[] pairs = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[]);
    System.DateTime asOfDate = default(System.DateTime);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          psQuery = default(System.Xml.XmlElement); //No Type
          sort = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.QuerySortOrderEntryWrapper_UnitTests.GetInstance()};
          useMaster = default(System.Boolean); //No Constructor
          pairs = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IdRevisionPairWrapper_UnitTests.GetInstance()};
          asOfDate = default(System.DateTime); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          QueryWorkitemRevisions_PreCondition(ref instance, ref requestId, ref psQuery, ref sort, ref useMaster, ref pairs, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
        },
       (instance) =>
       {
             instance.QueryWorkitemRevisions(requestId,psQuery,sort,useMaster, out pairs, out asOfDate,metadataHave, out dbStamp, out metadata);
       },
      (instance) =>
      {
              QueryWorkitemRevisions_PostValidate(instance, requestId, psQuery, sort, useMaster, pairs, asOfDate, metadataHave, dbStamp, metadata);
      });
  }
    partial void QueryWorkitems_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Xml.XmlElement psQuery, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort, ref System.Boolean useMaster, ref System.Int32[] ids, ref System.DateTime asOfDate, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void QueryWorkitems_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Xml.XmlElement psQuery, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort, System.Boolean useMaster, System.Int32[] ids, System.DateTime asOfDate, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryWorkitems_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Xml.XmlElement psQuery = default(System.Xml.XmlElement);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[]);
    System.Boolean useMaster = default(System.Boolean);
    System.Int32[] ids = default(System.Int32[]);
    System.DateTime asOfDate = default(System.DateTime);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          psQuery = default(System.Xml.XmlElement); //No Type
          sort = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.QuerySortOrderEntryWrapper_UnitTests.GetInstance()};
          useMaster = default(System.Boolean); //No Constructor
          ids = default(System.Int32[]); //No Constructor
          asOfDate = default(System.DateTime); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          QueryWorkitems_PreCondition(ref instance, ref requestId, ref psQuery, ref sort, ref useMaster, ref ids, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
        },
       (instance) =>
       {
             instance.QueryWorkitems(requestId,psQuery,sort,useMaster, out ids, out asOfDate,metadataHave, out dbStamp, out metadata);
       },
      (instance) =>
      {
              QueryWorkitems_PostValidate(instance, requestId, psQuery, sort, useMaster, ids, asOfDate, metadataHave, dbStamp, metadata);
      });
  }
    partial void QueryLinkedWorkitems_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Xml.XmlElement psQuery, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemRelation[] relations, ref System.DateTime asOfDate, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void QueryLinkedWorkitems_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Xml.XmlElement psQuery, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemRelation[] relations, System.DateTime asOfDate, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryLinkedWorkitems_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Xml.XmlElement psQuery = default(System.Xml.XmlElement);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[] sort = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry[]);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemRelation[] relations = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemRelation[]);
    System.DateTime asOfDate = default(System.DateTime);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          psQuery = default(System.Xml.XmlElement); //No Type
          sort = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IQuerySortOrderEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.QuerySortOrderEntryWrapper_UnitTests.GetInstance()};
          useMaster = default(System.Boolean); //No Constructor
          relations = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemRelation)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.WorkItemRelationWrapper_UnitTests.GetInstance()};
          asOfDate = default(System.DateTime); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          QueryLinkedWorkitems_PreCondition(ref instance, ref requestId, ref psQuery, ref sort, ref useMaster, ref relations, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
        },
       (instance) =>
       {
             instance.QueryLinkedWorkitems(requestId,psQuery,sort,useMaster, out relations, out asOfDate,metadataHave, out dbStamp, out metadata);
       },
      (instance) =>
      {
              QueryLinkedWorkitems_PostValidate(instance, requestId, psQuery, sort, useMaster, relations, asOfDate, metadataHave, dbStamp, metadata);
      });
  }
    partial void PageWorkitemsByIds_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int32[] ids, ref System.String[] columns, ref System.Int32[] longTextColumns, ref System.Nullable<System.DateTime> asOfDate, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets items, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void PageWorkitemsByIds_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int32[] ids, System.String[] columns, System.Int32[] longTextColumns, System.Nullable<System.DateTime> asOfDate, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets items, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void PageWorkitemsByIds_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int32[] ids = default(System.Int32[]);
    System.String[] columns = default(System.String[]);
    System.Int32[] longTextColumns = default(System.Int32[]);
    System.Nullable<System.DateTime> asOfDate = default(System.Nullable<System.DateTime>);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets items = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          ids = default(System.Int32[]); //No Constructor
          columns = default(System.String[]); //No Constructor
          longTextColumns = default(System.Int32[]); //No Constructor
          asOfDate = default(System.Nullable<System.DateTime>); //No Type
          useMaster = default(System.Boolean); //No Constructor
          items = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IPagedItemsRowSetsWrapper_UnitTests.GetInstance();
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          PageWorkitemsByIds_PreCondition(ref instance, ref requestId, ref ids, ref columns, ref longTextColumns, ref asOfDate, ref useMaster, ref items, ref metadataHave, ref metadata);
        },
       (instance) =>
       {
             instance.PageWorkitemsByIds(requestId,ids,columns,longTextColumns,asOfDate,useMaster, out items,metadataHave, out metadata);
       },
      (instance) =>
      {
              PageWorkitemsByIds_PostValidate(instance, requestId, ids, columns, longTextColumns, asOfDate, useMaster, items, metadataHave, metadata);
      });
  }
    partial void PageWorkitemsByIdRevs_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[] pairs, ref System.String[] columns, ref System.Int32[] longTextColumns, ref System.Nullable<System.DateTime> asOfDate, ref System.DateTime pageDate, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets items);
    partial void PageWorkitemsByIdRevs_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[] pairs, System.String[] columns, System.Int32[] longTextColumns, System.Nullable<System.DateTime> asOfDate, System.DateTime pageDate, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets items);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void PageWorkitemsByIdRevs_UnitTest()
  {
    System.String requestId = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[] pairs = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair[]);
    System.String[] columns = default(System.String[]);
    System.Int32[] longTextColumns = default(System.Int32[]);
    System.Nullable<System.DateTime> asOfDate = default(System.Nullable<System.DateTime>);
    System.DateTime pageDate = default(System.DateTime);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets items = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIPagedItemsRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          pairs = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIdRevisionPair)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IdRevisionPairWrapper_UnitTests.GetInstance()};
          columns = default(System.String[]); //No Constructor
          longTextColumns = default(System.Int32[]); //No Constructor
          asOfDate = default(System.Nullable<System.DateTime>); //No Type
          pageDate = default(System.DateTime); //No Constructor
          useMaster = default(System.Boolean); //No Constructor
          items = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IPagedItemsRowSetsWrapper_UnitTests.GetInstance();
          PageWorkitemsByIdRevs_PreCondition(ref instance, ref requestId, ref pairs, ref columns, ref longTextColumns, ref asOfDate, ref pageDate, ref useMaster, ref items);
        },
       (instance) =>
       {
             instance.PageWorkitemsByIdRevs(requestId,pairs,columns,longTextColumns,asOfDate, out pageDate,useMaster, out items);
       },
      (instance) =>
      {
              PageWorkitemsByIdRevs_PostValidate(instance, requestId, pairs, columns, longTextColumns, asOfDate, pageDate, useMaster, items);
      });
  }
    partial void QueryWorkitemCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Xml.XmlElement psQuery, ref System.Boolean useMaster, ref System.Int32 count, ref System.DateTime asOfDate, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void QueryWorkitemCount_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Xml.XmlElement psQuery, System.Boolean useMaster, System.Int32 count, System.DateTime asOfDate, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueryWorkitemCount_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Xml.XmlElement psQuery = default(System.Xml.XmlElement);
    System.Boolean useMaster = default(System.Boolean);
    System.Int32 count = default(System.Int32);
    System.DateTime asOfDate = default(System.DateTime);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          psQuery = default(System.Xml.XmlElement); //No Type
          useMaster = default(System.Boolean); //No Constructor
          count = default(System.Int32); //No Constructor
          asOfDate = default(System.DateTime); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          QueryWorkitemCount_PreCondition(ref instance, ref requestId, ref psQuery, ref useMaster, ref count, ref asOfDate, ref metadataHave, ref dbStamp, ref metadata);
        },
       (instance) =>
       {
             instance.QueryWorkitemCount(requestId,psQuery,useMaster, out count, out asOfDate,metadataHave, out dbStamp, out metadata);
       },
      (instance) =>
      {
              QueryWorkitemCount_PostValidate(instance, requestId, psQuery, useMaster, count, asOfDate, metadataHave, dbStamp, metadata);
      });
  }
    partial void GetMetadata_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata, ref System.Int32 locale, ref System.Int32 comparisonStyle, ref System.String callerIdentity);
    partial void GetMetadata_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata, System.Int32 locale, System.Int32 comparisonStyle, System.String callerIdentity);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetMetadata_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
    System.Int32 locale = default(System.Int32);
    System.Int32 comparisonStyle = default(System.Int32);
    System.String callerIdentity = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          useMaster = default(System.Boolean); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          locale = default(System.Int32); //No Constructor
          comparisonStyle = default(System.Int32); //No Constructor
          callerIdentity = default(System.String); //No Constructor
          GetMetadata_PreCondition(ref instance, ref requestId, ref useMaster, ref metadataHave, ref dbStamp, ref metadata, ref locale, ref comparisonStyle, ref callerIdentity);
        },
       (instance) =>
       {
             instance.GetMetadata(requestId,useMaster,metadataHave, out dbStamp, out metadata, out locale, out comparisonStyle, out callerIdentity);
       },
      (instance) =>
      {
              GetMetadata_PostValidate(instance, requestId, useMaster, metadataHave, dbStamp, metadata, locale, comparisonStyle, callerIdentity);
      });
  }
    partial void GetMetadataEx_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata, ref System.Int32 locale, ref System.Int32 comparisonStyle, ref System.String callerIdentity, ref System.String callerIdentitySid);
    partial void GetMetadataEx_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata, System.Int32 locale, System.Int32 comparisonStyle, System.String callerIdentity, System.String callerIdentitySid);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetMetadataEx_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
    System.Int32 locale = default(System.Int32);
    System.Int32 comparisonStyle = default(System.Int32);
    System.String callerIdentity = default(System.String);
    System.String callerIdentitySid = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          useMaster = default(System.Boolean); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          locale = default(System.Int32); //No Constructor
          comparisonStyle = default(System.Int32); //No Constructor
          callerIdentity = default(System.String); //No Constructor
          callerIdentitySid = default(System.String); //No Constructor
          GetMetadataEx_PreCondition(ref instance, ref requestId, ref useMaster, ref metadataHave, ref dbStamp, ref metadata, ref locale, ref comparisonStyle, ref callerIdentity, ref callerIdentitySid);
        },
       (instance) =>
       {
             instance.GetMetadataEx(requestId,useMaster,metadataHave, out dbStamp, out metadata, out locale, out comparisonStyle, out callerIdentity, out callerIdentitySid);
       },
      (instance) =>
      {
              GetMetadataEx_PostValidate(instance, requestId, useMaster, metadataHave, dbStamp, metadata, locale, comparisonStyle, callerIdentity, callerIdentitySid);
      });
  }
    partial void GetMetadataEx2_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Boolean useMaster, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata, ref System.Int32 locale, ref System.Int32 comparisonStyle, ref System.Int32 displayMode);
    partial void GetMetadataEx2_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Boolean useMaster, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata, System.Int32 locale, System.Int32 comparisonStyle, System.Int32 displayMode);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetMetadataEx2_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Boolean useMaster = default(System.Boolean);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
    System.Int32 locale = default(System.Int32);
    System.Int32 comparisonStyle = default(System.Int32);
    System.Int32 displayMode = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          useMaster = default(System.Boolean); //No Constructor
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          locale = default(System.Int32); //No Constructor
          comparisonStyle = default(System.Int32); //No Constructor
          displayMode = default(System.Int32); //No Constructor
          GetMetadataEx2_PreCondition(ref instance, ref requestId, ref useMaster, ref metadataHave, ref dbStamp, ref metadata, ref locale, ref comparisonStyle, ref displayMode);
        },
       (instance) =>
       {
             instance.GetMetadataEx2(requestId,useMaster,metadataHave, out dbStamp, out metadata, out locale, out comparisonStyle, out displayMode);
       },
      (instance) =>
      {
              GetMetadataEx2_PostValidate(instance, requestId, useMaster, metadataHave, dbStamp, metadata, locale, comparisonStyle, displayMode);
      });
  }
    partial void BulkUpdate_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Xml.XmlElement package, ref System.Xml.XmlElement result, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, ref System.String dbStamp, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
    partial void BulkUpdate_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Xml.XmlElement package, System.Xml.XmlElement result, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave, System.String dbStamp, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BulkUpdate_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Xml.XmlElement package = default(System.Xml.XmlElement);
    System.Xml.XmlElement result = default(System.Xml.XmlElement);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[] metadataHave = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry[]);
    System.String dbStamp = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets metadata = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIMetadataRowSets);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          package = default(System.Xml.XmlElement); //No Type
          result = default(System.Xml.XmlElement); //No Type
          metadataHave = new [] { (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IMetadataTableHaveEntry)DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.MetadataTableHaveEntryWrapper_UnitTests.GetInstance()};
          dbStamp = default(System.String); //No Constructor
          metadata = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.IMetadataRowSetsWrapper_UnitTests.GetInstance();
          BulkUpdate_PreCondition(ref instance, ref requestId, ref package, ref result, ref metadataHave, ref dbStamp, ref metadata);
        },
       (instance) =>
       {
             instance.BulkUpdate(requestId,package, out result,metadataHave, out dbStamp, out metadata);
       },
      (instance) =>
      {
              BulkUpdate_PostValidate(instance, requestId, package, result, metadataHave, dbStamp, metadata);
      });
  }
    partial void UpdateMaxAttachmentSize_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance);
    partial void UpdateMaxAttachmentSize_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UpdateMaxAttachmentSize_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          UpdateMaxAttachmentSize_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.UpdateMaxAttachmentSize();
       },
      (instance) =>
      {
              UpdateMaxAttachmentSize_PostValidate(instance);
      });
  }
    partial void UploadFile_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment fileAttachment);
    partial void UploadFile_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment fileAttachment);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void UploadFile_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment fileAttachment = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IFileAttachment);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          fileAttachment = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.FileAttachmentWrapper_UnitTests.GetInstance();
          UploadFile_PreCondition(ref instance, ref fileAttachment);
        },
       (instance) =>
       {
             instance.UploadFile(fileAttachment);
       },
      (instance) =>
      {
              UploadFile_PostValidate(instance, fileAttachment);
      });
  }
    partial void DownloadFile_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.Int32 fileAttachmentId);
    partial void DownloadFile_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.Int32 fileAttachmentId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DownloadFile_UnitTest()
  {
    System.Int32 fileAttachmentId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          fileAttachmentId = default(System.Int32); //No Constructor
          DownloadFile_PreCondition(ref instance, ref fileAttachmentId);
        },
       (instance) =>
       {
             instance.DownloadFile(fileAttachmentId);
       },
      (instance) =>
      {
              DownloadFile_PostValidate(instance, fileAttachmentId);
      });
  }
    partial void GetStoredQuery_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Boolean useMaster, ref System.Guid queryId, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queryDataSet);
    partial void GetStoredQuery_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Boolean useMaster, System.Guid queryId, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queryDataSet);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetStoredQuery_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Boolean useMaster = default(System.Boolean);
    System.Guid queryId = default(System.Guid);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queryDataSet = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          useMaster = default(System.Boolean); //No Constructor
          queryId = default(System.Guid); //No Constructor
          queryDataSet = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper_UnitTests.GetInstance();
          GetStoredQuery_PreCondition(ref instance, ref requestId, ref useMaster, ref queryId, ref queryDataSet);
        },
       (instance) =>
       {
             instance.GetStoredQuery(requestId,useMaster,queryId, out queryDataSet);
       },
      (instance) =>
      {
              GetStoredQuery_PostValidate(instance, requestId, useMaster, queryId, queryDataSet);
      });
  }
    partial void GetStoredQueries_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Boolean useMaster, ref System.Int64 rowVersion, ref System.Int32 projectId, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queriesDataSet);
    partial void GetStoredQueries_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Boolean useMaster, System.Int64 rowVersion, System.Int32 projectId, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queriesDataSet);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetStoredQueries_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Boolean useMaster = default(System.Boolean);
    System.Int64 rowVersion = default(System.Int64);
    System.Int32 projectId = default(System.Int32);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queriesDataSet = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          useMaster = default(System.Boolean); //No Constructor
          rowVersion = default(System.Int64); //No Constructor
          projectId = default(System.Int32); //No Constructor
          queriesDataSet = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper_UnitTests.GetInstance();
          GetStoredQueries_PreCondition(ref instance, ref requestId, ref useMaster, ref rowVersion, ref projectId, ref queriesDataSet);
        },
       (instance) =>
       {
             instance.GetStoredQueries(requestId,useMaster,rowVersion,projectId, out queriesDataSet);
       },
      (instance) =>
      {
              GetStoredQueries_PostValidate(instance, requestId, useMaster, rowVersion, projectId, queriesDataSet);
      });
  }
    partial void GetStoredQueryItems_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int64 rowVersion, ref System.Int32 projectId, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queriesDataSet);
    partial void GetStoredQueryItems_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int64 rowVersion, System.Int32 projectId, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queriesDataSet);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetStoredQueryItems_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int64 rowVersion = default(System.Int64);
    System.Int32 projectId = default(System.Int32);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection queriesDataSet = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          rowVersion = default(System.Int64); //No Constructor
          projectId = default(System.Int32); //No Constructor
          queriesDataSet = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper_UnitTests.GetInstance();
          GetStoredQueryItems_PreCondition(ref instance, ref requestId, ref rowVersion, ref projectId, ref queriesDataSet);
        },
       (instance) =>
       {
             instance.GetStoredQueryItems(requestId,rowVersion,projectId, out queriesDataSet);
       },
      (instance) =>
      {
              GetStoredQueryItems_PostValidate(instance, requestId, rowVersion, projectId, queriesDataSet);
      });
  }
    partial void GetDestroyedWorkItemIds_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int64 rowVersion);
    partial void GetDestroyedWorkItemIds_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int64 rowVersion);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetDestroyedWorkItemIds_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int64 rowVersion = default(System.Int64);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          rowVersion = default(System.Int64); //No Constructor
          GetDestroyedWorkItemIds_PreCondition(ref instance, ref requestId, ref rowVersion);
        },
       (instance) =>
       {
             instance.GetDestroyedWorkItemIds(requestId,rowVersion);
       },
      (instance) =>
      {
              GetDestroyedWorkItemIds_PostValidate(instance, requestId, rowVersion);
      });
  }
    partial void GetChangedWorkItemIds_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int64 rowVersion);
    partial void GetChangedWorkItemIds_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int64 rowVersion);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetChangedWorkItemIds_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int64 rowVersion = default(System.Int64);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          rowVersion = default(System.Int64); //No Constructor
          GetChangedWorkItemIds_PreCondition(ref instance, ref requestId, ref rowVersion);
        },
       (instance) =>
       {
             instance.GetChangedWorkItemIds(requestId,rowVersion);
       },
      (instance) =>
      {
              GetChangedWorkItemIds_PostValidate(instance, requestId, rowVersion);
      });
  }
    partial void GetWorkItemLinkChanges_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int64 rowVersion);
    partial void GetWorkItemLinkChanges_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int64 rowVersion);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetWorkItemLinkChanges_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int64 rowVersion = default(System.Int64);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          rowVersion = default(System.Int64); //No Constructor
          GetWorkItemLinkChanges_PreCondition(ref instance, ref requestId, ref rowVersion);
        },
       (instance) =>
       {
             instance.GetWorkItemLinkChanges(requestId,rowVersion);
       },
      (instance) =>
      {
              GetWorkItemLinkChanges_PostValidate(instance, requestId, rowVersion);
      });
  }
    partial void GetStoredQueryItemAccessControlList_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Guid queryItemId, ref System.Boolean getMetadata);
    partial void GetStoredQueryItemAccessControlList_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Guid queryItemId, System.Boolean getMetadata);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetStoredQueryItemAccessControlList_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Guid queryItemId = default(System.Guid);
    System.Boolean getMetadata = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          queryItemId = default(System.Guid); //No Constructor
          getMetadata = default(System.Boolean); //No Constructor
          GetStoredQueryItemAccessControlList_PreCondition(ref instance, ref requestId, ref queryItemId, ref getMetadata);
        },
       (instance) =>
       {
             instance.GetStoredQueryItemAccessControlList(requestId,queryItemId,getMetadata);
       },
      (instance) =>
      {
              GetStoredQueryItemAccessControlList_PostValidate(instance, requestId, queryItemId, getMetadata);
      });
  }
    partial void RequestCancel_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.String cancelRequestId);
    partial void RequestCancel_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.String cancelRequestId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RequestCancel_UnitTest()
  {
    System.String requestId = default(System.String);
    System.String cancelRequestId = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          cancelRequestId = default(System.String); //No Constructor
          RequestCancel_PreCondition(ref instance, ref requestId, ref cancelRequestId);
        },
       (instance) =>
       {
             instance.RequestCancel(requestId,cancelRequestId);
       },
      (instance) =>
      {
              RequestCancel_PostValidate(instance, requestId, cancelRequestId);
      });
  }
    partial void SyncExternalStructures_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.String projectURI);
    partial void SyncExternalStructures_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.String projectURI);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SyncExternalStructures_UnitTest()
  {
    System.String requestId = default(System.String);
    System.String projectURI = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          projectURI = default(System.String); //No Constructor
          SyncExternalStructures_PreCondition(ref instance, ref requestId, ref projectURI);
        },
       (instance) =>
       {
             instance.SyncExternalStructures(requestId,projectURI);
       },
      (instance) =>
      {
              SyncExternalStructures_PostValidate(instance, requestId, projectURI);
      });
  }
    partial void SyncBisGroupsAndUsers_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.String projectUri);
    partial void SyncBisGroupsAndUsers_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.String projectUri);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SyncBisGroupsAndUsers_UnitTest()
  {
    System.String requestId = default(System.String);
    System.String projectUri = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          projectUri = default(System.String); //No Constructor
          SyncBisGroupsAndUsers_PreCondition(ref instance, ref requestId, ref projectUri);
        },
       (instance) =>
       {
             instance.SyncBisGroupsAndUsers(requestId,projectUri);
       },
      (instance) =>
      {
              SyncBisGroupsAndUsers_PostValidate(instance, requestId, projectUri);
      });
  }
    partial void GetReferencingWorkitemUris_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.String artifactUri);
    partial void GetReferencingWorkitemUris_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.String artifactUri);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetReferencingWorkitemUris_UnitTest()
  {
    System.String requestId = default(System.String);
    System.String artifactUri = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          artifactUri = default(System.String); //No Constructor
          GetReferencingWorkitemUris_PreCondition(ref instance, ref requestId, ref artifactUri);
        },
       (instance) =>
       {
             instance.GetReferencingWorkitemUris(requestId,artifactUri);
       },
      (instance) =>
      {
              GetReferencingWorkitemUris_PostValidate(instance, requestId, artifactUri);
      });
  }
    partial void GetWorkItemIdsForArtifactUris_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String[] artifactUris, ref System.Nullable<System.DateTime> asOfDate);
    partial void GetWorkItemIdsForArtifactUris_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String[] artifactUris, System.Nullable<System.DateTime> asOfDate);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetWorkItemIdsForArtifactUris_UnitTest()
  {
    System.String[] artifactUris = default(System.String[]);
    System.Nullable<System.DateTime> asOfDate = default(System.Nullable<System.DateTime>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          artifactUris = default(System.String[]); //No Constructor
          asOfDate = default(System.Nullable<System.DateTime>); //No Type
          GetWorkItemIdsForArtifactUris_PreCondition(ref instance, ref artifactUris, ref asOfDate);
        },
       (instance) =>
       {
             instance.GetWorkItemIdsForArtifactUris(artifactUris,asOfDate);
       },
      (instance) =>
      {
              GetWorkItemIdsForArtifactUris_PostValidate(instance, artifactUris, asOfDate);
      });
  }
    partial void DestroyAttachments_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.String requestId, ref System.Int32[] workItemIds);
    partial void DestroyAttachments_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, System.String requestId, System.Int32[] workItemIds);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DestroyAttachments_UnitTest()
  {
    System.String requestId = default(System.String);
    System.Int32[] workItemIds = default(System.Int32[]);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
        },
        (instance) =>
        {
          requestId = default(System.String); //No Constructor
          workItemIds = default(System.Int32[]); //No Constructor
          DestroyAttachments_PreCondition(ref instance, ref requestId, ref workItemIds);
        },
       (instance) =>
       {
             instance.DestroyAttachments(requestId,workItemIds);
       },
      (instance) =>
      {
              DestroyAttachments_PostValidate(instance, requestId, workItemIds);
      });
  }
   partial void WorkItemServerVersion_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IWorkItemServerVersion setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void WorkItemServerVersion_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.WorkItemServerVersion;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void MaxAttachmentSize_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer instance, ref System.Int64 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void MaxAttachmentSize_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.MaxAttachmentSize;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
