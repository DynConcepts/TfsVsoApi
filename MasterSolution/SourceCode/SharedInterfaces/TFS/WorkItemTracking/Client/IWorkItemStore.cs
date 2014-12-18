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
    void InvalidateCacheStamp();
    IWorkItemCollection Query( String wiql);
    IWorkItemCollection Query( String wiql, IDictionary context);
    IWorkItemCollection Query( Int32[] ids, String wiql);
    IWorkItemCollection Query( Int32[] ids, Int32[] revs, String wiql);
    IWorkItemCollection Query( Int32[] ids, String wiql, DateTime asof);
    IWorkItemCollection Query( IBatchReadParameterCollection batchReadParams, String wiql);
    Int32 QueryCount( String wiql);
    Int32 QueryCount( String wiql, IDictionary context);
    IWorkItem GetWorkItem( Int32 id);
    IWorkItem GetWorkItem( Int32 id, DateTime at);
    IWorkItem GetWorkItem( Int32 id, Int32 revision);
    IWorkItem GetWorkItem( Uri uri);
    IWorkItem GetWorkItem( Uri uri, DateTime at);
    IWorkItem GetWorkItem( Uri uri, Int32 revision);
    Uri[] GetReferencingWorkItemUris( Uri referencedUri);
    Dictionary<String,Int32[]> GetWorkItemIdsForArtifactUris( String[] artifactUriList, DateTime asOfDate);
    IBatchSaveError[] BatchSave( IWorkItem[] workitems);
    IBatchSaveError[] BatchSave( IWorkItem[] workitems, ISaveFlags saveFlags);
    void RefreshCache( Boolean forceRefresh);
    void RefreshCache();
    Boolean SyncToCache();
    IStoredQuery GetStoredQuery( Guid guid);
    IQueryDefinition GetQueryDefinition( Guid guid);
    void ImportGlobalLists( String lists);
    void ImportGlobalLists( XmlElement listsElement);
    XmlDocument ExportGlobalLists();
    IEnumerable<IWorkItemOperationError> DestroyWorkItems( IEnumerable<Int32> ids);
    void ResetCachedData();
    IQueryHierarchy GetQueryHierarchy( IProject project);
    String TreeIdToPath( Int32 id);
    String GetPersonNameById( Int32 id);
    IPsUserRightsMask GetNodePermissions( Int32 nodeId);
    void CacheConstantStrings();
    void ResetConstantStringCache();
    void SendUpdatePackage( XmlElement package,out XmlElement result, Boolean bulk);
    List<String> GetGlobalAndProjectGroups( Int32 projectId, Boolean includeGlobal);
    CultureInfo CultureInfo  { get;   }
    TimeZone TimeZone  { get;   }
    StringComparer ServerStringComparer  { get;   }
    IProjectCollection Projects  { get;   }
    IFieldDefinitionCollection FieldDefinitions  { get;   }
    ITeamFoundationServer TeamFoundationServer  { get;   }
    ITfsTeamProjectCollection TeamProjectCollection  { get;   }
    IWorkItemServer ClientService  { get;   }
    IRegisteredLinkTypeCollection RegisteredLinkTypes  { get;   }
    IWorkItemLinkTypeCollection WorkItemLinkTypes  { get;   }
    IWorkItemStoreDiagnostics Diagnostics  { get;   }
    String CallingProcessIdentity  { get; set;   }
    IUserDisplayMode UserDisplayMode  { get;   }
    IServerInfo ServerInfo  { get;   }
    Int32 MaxBulkUpdateBatchSize  { get;   }
    Boolean BypassRules  { get;   }
    IQueryHierarchyProvider QueryHierarchyProvider  { get;   }
    String WebServiceUrl  { get;   }
    String UserDisplayName  { get;   }
    String UserSid  { get;   }
    ICache Metadata  { get;   }
  }
}
