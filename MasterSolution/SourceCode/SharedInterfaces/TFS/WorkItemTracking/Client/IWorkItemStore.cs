namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemStore : DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsTeamProjectCollectionObject
  {
    void InvalidateCacheStamp();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Query( System.String wiql);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Query( System.String wiql, System.Collections.IDictionary context);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Query( System.Int32[] ids, System.String wiql);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Query( System.Int32[] ids, System.Int32[] revs, System.String wiql);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Query( System.Int32[] ids, System.String wiql, System.DateTime asof);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Query( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameterCollection batchReadParams, System.String wiql);
    System.Int32 QueryCount( System.String wiql);
    System.Int32 QueryCount( System.String wiql, System.Collections.IDictionary context);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem GetWorkItem( System.Int32 id);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem GetWorkItem( System.Int32 id, System.DateTime at);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem GetWorkItem( System.Int32 id, System.Int32 revision);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem GetWorkItem( System.Uri uri);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem GetWorkItem( System.Uri uri, System.DateTime at);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem GetWorkItem( System.Uri uri, System.Int32 revision);
    System.Uri[] GetReferencingWorkItemUris( System.Uri referencedUri);
    System.Collections.Generic.Dictionary<System.String,System.Int32[]> GetWorkItemIdsForArtifactUris( System.String[] artifactUriList, System.DateTime asOfDate);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchSaveError[] BatchSave( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem[] workitems);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchSaveError[] BatchSave( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem[] workitems, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISaveFlags saveFlags);
    void RefreshCache( System.Boolean forceRefresh);
    void RefreshCache();
    System.Boolean SyncToCache();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IStoredQuery GetStoredQuery( System.Guid guid);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryDefinition GetQueryDefinition( System.Guid guid);
    void ImportGlobalLists( System.String lists);
    void ImportGlobalLists( System.Xml.XmlElement listsElement);
    System.Xml.XmlDocument ExportGlobalLists();
    System.Collections.Generic.IEnumerable<DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemOperationError> DestroyWorkItems( System.Collections.Generic.IEnumerable<System.Int32> ids);
    void ResetCachedData();
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy GetQueryHierarchy( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
    System.String TreeIdToPath( System.Int32 id);
    System.String GetPersonNameById( System.Int32 id);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore.IPsUserRightsMask GetNodePermissions( System.Int32 nodeId);
    void CacheConstantStrings();
    void ResetConstantStringCache();
    void SendUpdatePackage( System.Xml.XmlElement package,out System.Xml.XmlElement result, System.Boolean bulk);
    System.Collections.Generic.List<System.String> GetGlobalAndProjectGroups( System.Int32 projectId, System.Boolean includeGlobal);
    System.Globalization.CultureInfo CultureInfo  { get;   }
    System.TimeZone TimeZone  { get;   }
    System.StringComparer ServerStringComparer  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProjectCollection Projects  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection FieldDefinitions  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer TeamFoundationServer  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection TeamProjectCollection  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IWorkItemServer ClientService  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkTypeCollection RegisteredLinkTypes  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkTypeCollection WorkItemLinkTypes  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStoreDiagnostics Diagnostics  { get;   }
    System.String CallingProcessIdentity  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IUserDisplayMode UserDisplayMode  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IServerInfo ServerInfo  { get;   }
    System.Int32 MaxBulkUpdateBatchSize  { get;   }
    System.Boolean BypassRules  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider QueryHierarchyProvider  { get;   }
    System.String WebServiceUrl  { get;   }
    System.String UserDisplayName  { get;   }
    System.String UserSid  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ICache Metadata  { get;   }
  }
}
