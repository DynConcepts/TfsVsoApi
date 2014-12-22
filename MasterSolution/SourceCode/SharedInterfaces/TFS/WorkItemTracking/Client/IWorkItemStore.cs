using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemStore : IITfsTeamProjectCollectionObject
    {
        IBatchSaveError[] BatchSave(IWorkItem[] workitems);
        IBatchSaveError[] BatchSave(IWorkItem[] workitems, ISaveFlags saveFlags);
        void CacheConstantStrings();
        IEnumerable<IWorkItemOperationError> DestroyWorkItems(IEnumerable<Int32> ids);
        XmlDocument ExportGlobalLists();
        List<String> GetGlobalAndProjectGroups(Int32 projectId, Boolean includeGlobal);
        IPsUserRightsMask GetNodePermissions(Int32 nodeId);
        String GetPersonNameById(Int32 id);
        IQueryDefinition GetQueryDefinition(Guid guid);
        IQueryHierarchy GetQueryHierarchy(IProject project);
        Uri[] GetReferencingWorkItemUris(Uri referencedUri);
        IStoredQuery GetStoredQuery(Guid guid);
        IWorkItem GetWorkItem(Int32 id);
        IWorkItem GetWorkItem(Int32 id, DateTime at);
        IWorkItem GetWorkItem(Int32 id, Int32 revision);
        IWorkItem GetWorkItem(Uri uri);
        IWorkItem GetWorkItem(Uri uri, DateTime at);
        IWorkItem GetWorkItem(Uri uri, Int32 revision);
        Dictionary<String, Int32[]> GetWorkItemIdsForArtifactUris(String[] artifactUriList, DateTime asOfDate);
        void ImportGlobalLists(String lists);
        void ImportGlobalLists(XmlElement listsElement);
        void InvalidateCacheStamp();
        IWorkItemCollection Query(String wiql);
        IWorkItemCollection Query(String wiql, IDictionary context);
        IWorkItemCollection Query(Int32[] ids, String wiql);
        IWorkItemCollection Query(Int32[] ids, Int32[] revs, String wiql);
        IWorkItemCollection Query(Int32[] ids, String wiql, DateTime asof);
        IWorkItemCollection Query(IBatchReadParameterCollection batchReadParams, String wiql);
        Int32 QueryCount(String wiql);
        Int32 QueryCount(String wiql, IDictionary context);
        void RefreshCache(Boolean forceRefresh);
        void RefreshCache();
        void ResetCachedData();
        void ResetConstantStringCache();
        void SendUpdatePackage(XmlElement package, out XmlElement result, Boolean bulk);
        Boolean SyncToCache();
        String TreeIdToPath(Int32 id);
        Boolean BypassRules { get; }
        String CallingProcessIdentity { get; set; }
        IWorkItemServer ClientService { get; }
        CultureInfo CultureInfo { get; }
        IWorkItemStoreDiagnostics Diagnostics { get; }
        IFieldDefinitionCollection FieldDefinitions { get; }
        Int32 MaxBulkUpdateBatchSize { get; }
        ICache Metadata { get; }
        IProjectCollection Projects { get; }
        IQueryHierarchyProvider QueryHierarchyProvider { get; }
        IRegisteredLinkTypeCollection RegisteredLinkTypes { get; }
        IServerInfo ServerInfo { get; }
        StringComparer ServerStringComparer { get; }
        ITeamFoundationServer TeamFoundationServer { get; }
        ITfsTeamProjectCollection TeamProjectCollection { get; }
        TimeZone TimeZone { get; }
        IUserDisplayMode UserDisplayMode { get; }
        String UserDisplayName { get; }
        String UserSid { get; }
        String WebServiceUrl { get; }
        IWorkItemLinkTypeCollection WorkItemLinkTypes { get; }
    }
}