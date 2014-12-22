using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Common.DataStore;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemStoreWrapper : WorkItemStoreWrapper<IWorkItemStore, WorkItemStore>, IWorkItemStore, IITfsTeamProjectCollectionObject
    {
        protected WorkItemStoreWrapper(WorkItemStore instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemStore, WorkItemStore>(src => src == null ? null : ((WorkItemStoreWrapper) src).r_Instance, src => new WorkItemStoreWrapper(src)); }
    }


    internal class WorkItemStoreWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemStore where TInterface : class where TWrapper : class
    {
        IBatchSaveError[] IWorkItemStore.BatchSave(IWorkItem[] workitems)
        {
            BatchSaveError[] nativeCallResult = r_Instance.BatchSave(WorkItemWrapper.GetInstance(workitems));
            IBatchSaveError[] wrappedCallResult = BatchSaveErrorWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IBatchSaveError[] IWorkItemStore.BatchSave(IWorkItem[] workitems, ISaveFlags saveFlags)
        {
            BatchSaveError[] nativeCallResult = r_Instance.BatchSave(WorkItemWrapper.GetInstance(workitems), SaveFlagsWrapper.GetInstance(saveFlags));
            IBatchSaveError[] wrappedCallResult = BatchSaveErrorWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Boolean IWorkItemStore.BypassRules
        {
            get
            {
                bool nativeCallResult = r_Instance.BypassRules;
                return nativeCallResult;
            }
        }

        void IWorkItemStore.CacheConstantStrings() { r_Instance.CacheConstantStrings(); }

        String IWorkItemStore.CallingProcessIdentity
        {
            get
            {
                string nativeCallResult = r_Instance.CallingProcessIdentity;
                return nativeCallResult;
            }
            set { r_Instance.CallingProcessIdentity = value; }
        }

        IWorkItemServer IWorkItemStore.ClientService
        {
            get
            {
                WorkItemServer nativeCallResult = r_Instance.ClientService;
                IWorkItemServer wrappedCallResult = WorkItemServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        CultureInfo IWorkItemStore.CultureInfo
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.CultureInfo;
                return nativeCallResult;
            }
        }

        IEnumerable<IWorkItemOperationError> IWorkItemStore.DestroyWorkItems(IEnumerable<Int32> ids)
        {
            IEnumerable<WorkItemOperationError> nativeCallResult = r_Instance.DestroyWorkItems(ids);
            IEnumerable<IWorkItemOperationError> wrappedCallResult = WorkItemOperationErrorWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IWorkItemStoreDiagnostics IWorkItemStore.Diagnostics
        {
            get
            {
                WorkItemStoreDiagnostics nativeCallResult = r_Instance.Diagnostics;
                IWorkItemStoreDiagnostics wrappedCallResult = WorkItemStoreDiagnosticsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        XmlDocument IWorkItemStore.ExportGlobalLists()
        {
            XmlDocument nativeCallResult = r_Instance.ExportGlobalLists();
            return nativeCallResult;
        }

        IFieldDefinitionCollection IWorkItemStore.FieldDefinitions
        {
            get
            {
                FieldDefinitionCollection nativeCallResult = r_Instance.FieldDefinitions;
                IFieldDefinitionCollection wrappedCallResult = FieldDefinitionCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        List<String> IWorkItemStore.GetGlobalAndProjectGroups(Int32 projectId, Boolean includeGlobal)
        {
            List<string> nativeCallResult = r_Instance.GetGlobalAndProjectGroups(projectId, includeGlobal);
            return nativeCallResult;
        }

        IPsUserRightsMask IWorkItemStore.GetNodePermissions(Int32 nodeId)
        {
            PsUserRightsMask nativeCallResult = r_Instance.GetNodePermissions(nodeId);
            IPsUserRightsMask wrappedCallResult = PsUserRightsMaskWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        String IWorkItemStore.GetPersonNameById(Int32 id)
        {
            string nativeCallResult = r_Instance.GetPersonNameById(id);
            return nativeCallResult;
        }

        IQueryDefinition IWorkItemStore.GetQueryDefinition(Guid guid)
        {
            QueryDefinition nativeCallResult = r_Instance.GetQueryDefinition(guid);
            IQueryDefinition wrappedCallResult = QueryDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IQueryHierarchy IWorkItemStore.GetQueryHierarchy(IProject project)
        {
            QueryHierarchy nativeCallResult = r_Instance.GetQueryHierarchy(ProjectWrapper.GetInstance(project));
            IQueryHierarchy wrappedCallResult = QueryHierarchyWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Uri[] IWorkItemStore.GetReferencingWorkItemUris(Uri referencedUri)
        {
            Uri[] nativeCallResult = r_Instance.GetReferencingWorkItemUris(referencedUri);
            return nativeCallResult;
        }

        IStoredQuery IWorkItemStore.GetStoredQuery(Guid guid)
        {
            StoredQuery nativeCallResult = r_Instance.GetStoredQuery(guid);
            IStoredQuery wrappedCallResult = StoredQueryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IWorkItem IWorkItemStore.GetWorkItem(Int32 id)
        {
            WorkItem nativeCallResult = r_Instance.GetWorkItem(id);
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItemStore.GetWorkItem(Int32 id, DateTime at)
        {
            WorkItem nativeCallResult = r_Instance.GetWorkItem(id, at);
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItemStore.GetWorkItem(Int32 id, Int32 revision)
        {
            WorkItem nativeCallResult = r_Instance.GetWorkItem(id, revision);
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItemStore.GetWorkItem(Uri uri)
        {
            WorkItem nativeCallResult = r_Instance.GetWorkItem(uri);
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItemStore.GetWorkItem(Uri uri, DateTime at)
        {
            WorkItem nativeCallResult = r_Instance.GetWorkItem(uri, at);
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItemStore.GetWorkItem(Uri uri, Int32 revision)
        {
            WorkItem nativeCallResult = r_Instance.GetWorkItem(uri, revision);
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Dictionary<String, Int32[]> IWorkItemStore.GetWorkItemIdsForArtifactUris(String[] artifactUriList, DateTime asOfDate)
        {
            Dictionary<string, int[]> nativeCallResult = r_Instance.GetWorkItemIdsForArtifactUris(artifactUriList, asOfDate);
            return nativeCallResult;
        }

        void IWorkItemStore.ImportGlobalLists(String lists) { r_Instance.ImportGlobalLists(lists); }

        void IWorkItemStore.ImportGlobalLists(XmlElement listsElement) { r_Instance.ImportGlobalLists(listsElement); }
        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { ((ITfsTeamProjectCollectionObject) r_Instance).Initialize(TfsTeamProjectCollectionWrapper.GetInstance(projectCollection)); }

        void IWorkItemStore.InvalidateCacheStamp() { r_Instance.InvalidateCacheStamp(); }

        Int32 IWorkItemStore.MaxBulkUpdateBatchSize
        {
            get
            {
                int nativeCallResult = r_Instance.MaxBulkUpdateBatchSize;
                return nativeCallResult;
            }
        }

        ICache IWorkItemStore.Metadata
        {
            get
            {
                Cache nativeCallResult = r_Instance.Metadata;
                ICache wrappedCallResult = CacheWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IProjectCollection IWorkItemStore.Projects
        {
            get
            {
                ProjectCollection nativeCallResult = r_Instance.Projects;
                IProjectCollection wrappedCallResult = ProjectCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        IWorkItemCollection IWorkItemStore.Query(String wiql)
        {
            WorkItemCollection nativeCallResult = r_Instance.Query(wiql);
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItemCollection IWorkItemStore.Query(String wiql, IDictionary context)
        {
            WorkItemCollection nativeCallResult = r_Instance.Query(wiql, context);
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItemCollection IWorkItemStore.Query(Int32[] ids, String wiql)
        {
            WorkItemCollection nativeCallResult = r_Instance.Query(ids, wiql);
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItemCollection IWorkItemStore.Query(Int32[] ids, Int32[] revs, String wiql)
        {
            WorkItemCollection nativeCallResult = r_Instance.Query(ids, revs, wiql);
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItemCollection IWorkItemStore.Query(Int32[] ids, String wiql, DateTime asof)
        {
            WorkItemCollection nativeCallResult = r_Instance.Query(ids, wiql, asof);
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItemCollection IWorkItemStore.Query(IBatchReadParameterCollection batchReadParams, String wiql)
        {
            WorkItemCollection nativeCallResult = r_Instance.Query(BatchReadParameterCollectionWrapper.GetInstance(batchReadParams), wiql);
            IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Int32 IWorkItemStore.QueryCount(String wiql)
        {
            int nativeCallResult = r_Instance.QueryCount(wiql);
            return nativeCallResult;
        }


        Int32 IWorkItemStore.QueryCount(String wiql, IDictionary context)
        {
            int nativeCallResult = r_Instance.QueryCount(wiql, context);
            return nativeCallResult;
        }

        IQueryHierarchyProvider IWorkItemStore.QueryHierarchyProvider
        {
            get
            {
                QueryHierarchyProvider nativeCallResult = r_Instance.QueryHierarchyProvider;
                IQueryHierarchyProvider wrappedCallResult = QueryHierarchyProviderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        void IWorkItemStore.RefreshCache(Boolean forceRefresh) { r_Instance.RefreshCache(forceRefresh); }

        void IWorkItemStore.RefreshCache() { r_Instance.RefreshCache(); }

        IRegisteredLinkTypeCollection IWorkItemStore.RegisteredLinkTypes
        {
            get
            {
                RegisteredLinkTypeCollection nativeCallResult = r_Instance.RegisteredLinkTypes;
                IRegisteredLinkTypeCollection wrappedCallResult = RegisteredLinkTypeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        void IWorkItemStore.ResetCachedData() { r_Instance.ResetCachedData(); }


        void IWorkItemStore.ResetConstantStringCache() { r_Instance.ResetConstantStringCache(); }

        void IWorkItemStore.SendUpdatePackage(XmlElement package, out XmlElement result, Boolean bulk)
        {
            XmlElement tmp_result;
            r_Instance.SendUpdatePackage(package, out tmp_result, bulk);
            result = tmp_result;
        }

        IServerInfo IWorkItemStore.ServerInfo
        {
            get
            {
                ServerInfo nativeCallResult = r_Instance.ServerInfo;
                IServerInfo wrappedCallResult = ServerInfoWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        StringComparer IWorkItemStore.ServerStringComparer
        {
            get
            {
                StringComparer nativeCallResult = r_Instance.ServerStringComparer;
                return nativeCallResult;
            }
        }

        Boolean IWorkItemStore.SyncToCache()
        {
            bool nativeCallResult = r_Instance.SyncToCache();
            return nativeCallResult;
        }

        ITeamFoundationServer IWorkItemStore.TeamFoundationServer
        {
            get
            {
                TeamFoundationServer nativeCallResult = r_Instance.TeamFoundationServer;
                ITeamFoundationServer wrappedCallResult = TeamFoundationServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ITfsTeamProjectCollection IWorkItemStore.TeamProjectCollection
        {
            get
            {
                TfsTeamProjectCollection nativeCallResult = r_Instance.TeamProjectCollection;
                ITfsTeamProjectCollection wrappedCallResult = TfsTeamProjectCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        TimeZone IWorkItemStore.TimeZone
        {
            get
            {
                TimeZone nativeCallResult = r_Instance.TimeZone;
                return nativeCallResult;
            }
        }

        String IWorkItemStore.TreeIdToPath(Int32 id)
        {
            string nativeCallResult = r_Instance.TreeIdToPath(id);
            return nativeCallResult;
        }

        IUserDisplayMode IWorkItemStore.UserDisplayMode
        {
            get
            {
                UserDisplayMode nativeCallResult = r_Instance.UserDisplayMode;
                IUserDisplayMode wrappedCallResult = UserDisplayModeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IWorkItemStore.UserDisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.UserDisplayName;
                return nativeCallResult;
            }
        }

        String IWorkItemStore.UserSid
        {
            get
            {
                string nativeCallResult = r_Instance.UserSid;
                return nativeCallResult;
            }
        }

        String IWorkItemStore.WebServiceUrl
        {
            get
            {
                string nativeCallResult = r_Instance.WebServiceUrl;
                return nativeCallResult;
            }
        }

        IWorkItemLinkTypeCollection IWorkItemStore.WorkItemLinkTypes
        {
            get
            {
                WorkItemLinkTypeCollection nativeCallResult = r_Instance.WorkItemLinkTypes;
                IWorkItemLinkTypeCollection wrappedCallResult = WorkItemLinkTypeCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemStoreWrapper(WorkItemStore instance) { r_Instance = instance; }
        protected readonly WorkItemStore r_Instance;
    }
}