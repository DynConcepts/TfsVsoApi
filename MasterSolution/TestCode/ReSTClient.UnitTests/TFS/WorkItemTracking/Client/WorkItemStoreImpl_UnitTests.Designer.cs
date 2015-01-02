using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemStoreImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BatchSave_UnitTest()
        {
            IWorkItem[] workitems = default(IWorkItem[]);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    workitems = new[] {(IWorkItem) WorkItemImpl_UnitTests.GetInstance()};
                    BatchSave_PreCondition(ref instance, ref workitems);
                },
                instance => { instance.BatchSave(workitems); },
                instance => { BatchSave_PostValidate(instance, workitems); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BypassRules_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.BypassRules; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CacheConstantStrings_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance => { CacheConstantStrings_PreCondition(ref instance); },
                instance => { instance.CacheConstantStrings(); },
                instance => { CacheConstantStrings_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CallingProcessIdentity_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    CallingProcessIdentity_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.CallingProcessIdentity = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.CallingProcessIdentity; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ClientService_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ClientService; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CultureInfo_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CultureInfo; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DestroyWorkItems_UnitTest()
        {
            IEnumerable<Int32> ids = default(IEnumerable<Int32>);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    ids = default(IEnumerable<Int32>); //No Type
                    DestroyWorkItems_PreCondition(ref instance, ref ids);
                },
                instance => { instance.DestroyWorkItems(ids); },
                instance => { DestroyWorkItems_PostValidate(instance, ids); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Diagnostics_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Diagnostics; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ExportGlobalLists_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance => { ExportGlobalLists_PreCondition(ref instance); },
                instance => { instance.ExportGlobalLists(); },
                instance => { ExportGlobalLists_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetGlobalAndProjectGroups_UnitTest()
        {
            Int32 projectId = default(Int32);
            Boolean includeGlobal = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    projectId = default(Int32); //No Constructor
                    includeGlobal = default(Boolean); //No Constructor
                    GetGlobalAndProjectGroups_PreCondition(ref instance, ref projectId, ref includeGlobal);
                },
                instance => { instance.GetGlobalAndProjectGroups(projectId, includeGlobal); },
                instance => { GetGlobalAndProjectGroups_PostValidate(instance, projectId, includeGlobal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetNodePermissions_UnitTest()
        {
            Int32 nodeId = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    nodeId = default(Int32); //No Constructor
                    GetNodePermissions_PreCondition(ref instance, ref nodeId);
                },
                instance => { instance.GetNodePermissions(nodeId); },
                instance => { GetNodePermissions_PostValidate(instance, nodeId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetPersonNameById_UnitTest()
        {
            Int32 id = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    GetPersonNameById_PreCondition(ref instance, ref id);
                },
                instance => { instance.GetPersonNameById(id); },
                instance => { GetPersonNameById_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetReferencingWorkItemUris_UnitTest()
        {
            Uri referencedUri = default(Uri);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    referencedUri = default(Uri); //No Type
                    GetReferencingWorkItemUris_PreCondition(ref instance, ref referencedUri);
                },
                instance => { instance.GetReferencingWorkItemUris(referencedUri); },
                instance => { GetReferencingWorkItemUris_PostValidate(instance, referencedUri); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ImportGlobalLists_UnitTest()
        {
            String lists = default(String);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    lists = default(String); //No Constructor
                    ImportGlobalLists_PreCondition(ref instance, ref lists);
                },
                instance => { instance.ImportGlobalLists(lists); },
                instance => { ImportGlobalLists_PostValidate(instance, lists); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InvalidateCacheStamp_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance => { InvalidateCacheStamp_PreCondition(ref instance); },
                instance => { instance.InvalidateCacheStamp(); },
                instance => { InvalidateCacheStamp_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void MaxBulkUpdateBatchSize_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.MaxBulkUpdateBatchSize; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Projects_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Projects; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryCount_UnitTest()
        {
            String wiql = default(String);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    wiql = default(String); //No Constructor
                    QueryCount_PreCondition(ref instance, ref wiql);
                },
                instance => { instance.QueryCount(wiql); },
                instance => { QueryCount_PostValidate(instance, wiql); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void QueryHierarchyProvider_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.QueryHierarchyProvider; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Query_UnitTest()
        {
            String wiql = default(String);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    wiql = default(String); //No Constructor
                    Query_PreCondition(ref instance, ref wiql);
                },
                instance => { instance.Query(wiql); },
                instance => { Query_PostValidate(instance, wiql); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RefreshCache_UnitTest()
        {
            Boolean forceRefresh = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    forceRefresh = default(Boolean); //No Constructor
                    RefreshCache_PreCondition(ref instance, ref forceRefresh);
                },
                instance => { instance.RefreshCache(forceRefresh); },
                instance => { RefreshCache_PostValidate(instance, forceRefresh); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RegisteredLinkTypes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RegisteredLinkTypes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ResetCachedData_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance => { ResetCachedData_PreCondition(ref instance); },
                instance => { instance.ResetCachedData(); },
                instance => { ResetCachedData_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ResetConstantStringCache_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance => { ResetConstantStringCache_PreCondition(ref instance); },
                instance => { instance.ResetConstantStringCache(); },
                instance => { ResetConstantStringCache_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SendUpdatePackage_UnitTest()
        {
            XmlElement package = default(XmlElement);
            XmlElement result = default(XmlElement);
            Boolean bulk = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    package = default(XmlElement); //No Type
                    result = default(XmlElement); //No Type
                    bulk = default(Boolean); //No Constructor
                    SendUpdatePackage_PreCondition(ref instance, ref package, ref result, ref bulk);
                },
                instance => { instance.SendUpdatePackage(package, out result, bulk); },
                instance => { SendUpdatePackage_PostValidate(instance, package, result, bulk); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServerInfo_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ServerInfo; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ServerStringComparer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ServerStringComparer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncToCache_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance => { SyncToCache_PreCondition(ref instance); },
                instance => { instance.SyncToCache(); },
                instance => { SyncToCache_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TeamProjectCollection_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.TeamProjectCollection; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TreeIdToPath_UnitTest()
        {
            Int32 id = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemStore) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    TreeIdToPath_PreCondition(ref instance, ref id);
                },
                instance => { instance.TreeIdToPath(id); },
                instance => { TreeIdToPath_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UserDisplayMode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.UserDisplayMode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UserDisplayName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.UserDisplayName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void UserSid_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.UserSid; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WebServiceUrl_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WebServiceUrl; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemLinkTypes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStore) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemLinkTypes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void BatchSave_PostValidate(IWorkItemStore instance, IWorkItem[] workitems);
        partial void BatchSave_PreCondition(ref IWorkItemStore instance, ref IWorkItem[] workitems);
        partial void BypassRules_SetCondition(ref IWorkItemStore instance, ref Boolean setValue);
        partial void CacheConstantStrings_PostValidate(IWorkItemStore instance);
        partial void CacheConstantStrings_PreCondition(ref IWorkItemStore instance);

        partial void CallingProcessIdentity_SetCondition(ref IWorkItemStore instance, ref String setValue);
        partial void ClientService_SetCondition(ref IWorkItemStore instance, ref IWorkItemServer setValue);
        partial void CultureInfo_SetCondition(ref IWorkItemStore instance, ref CultureInfo setValue);
        partial void DestroyWorkItems_PostValidate(IWorkItemStore instance, IEnumerable<Int32> ids);
        partial void DestroyWorkItems_PreCondition(ref IWorkItemStore instance, ref IEnumerable<Int32> ids);
        partial void Diagnostics_SetCondition(ref IWorkItemStore instance, ref IWorkItemStoreDiagnostics setValue);
        partial void ExportGlobalLists_PostValidate(IWorkItemStore instance);
        partial void ExportGlobalLists_PreCondition(ref IWorkItemStore instance);
        partial void GetGlobalAndProjectGroups_PostValidate(IWorkItemStore instance, Int32 projectId, Boolean includeGlobal);
        partial void GetGlobalAndProjectGroups_PreCondition(ref IWorkItemStore instance, ref Int32 projectId, ref Boolean includeGlobal);
        internal static IEnumerable<WorkItemStoreImpl> GetIEnumerableInstance() { return new List<WorkItemStoreImpl> {GetInstance()}; }

        internal static WorkItemStoreImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemStoreImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetNodePermissions_PostValidate(IWorkItemStore instance, Int32 nodeId);
        partial void GetNodePermissions_PreCondition(ref IWorkItemStore instance, ref Int32 nodeId);
        partial void GetPersonNameById_PostValidate(IWorkItemStore instance, Int32 id);
        partial void GetPersonNameById_PreCondition(ref IWorkItemStore instance, ref Int32 id);
        partial void GetReferencingWorkItemUris_PostValidate(IWorkItemStore instance, Uri referencedUri);
        partial void GetReferencingWorkItemUris_PreCondition(ref IWorkItemStore instance, ref Uri referencedUri);
        partial void ImportGlobalLists_PostValidate(IWorkItemStore instance, String lists);
        partial void ImportGlobalLists_PreCondition(ref IWorkItemStore instance, ref String lists);
        static partial void InstanceFactory(ref WorkItemStoreImpl instance, [CallerMemberName] string callerName = "");
        partial void InvalidateCacheStamp_PostValidate(IWorkItemStore instance);
        partial void InvalidateCacheStamp_PreCondition(ref IWorkItemStore instance);

        partial void MaxBulkUpdateBatchSize_SetCondition(ref IWorkItemStore instance, ref Int32 setValue);
        partial void Projects_SetCondition(ref IWorkItemStore instance, ref IProjectCollection setValue);
        partial void QueryCount_PostValidate(IWorkItemStore instance, String wiql);
        partial void QueryCount_PreCondition(ref IWorkItemStore instance, ref String wiql);

        partial void QueryHierarchyProvider_SetCondition(ref IWorkItemStore instance, ref IQueryHierarchyProvider setValue);
        partial void Query_PostValidate(IWorkItemStore instance, String wiql);
        partial void Query_PreCondition(ref IWorkItemStore instance, ref String wiql);
        partial void RefreshCache_PostValidate(IWorkItemStore instance, Boolean forceRefresh);
        partial void RefreshCache_PreCondition(ref IWorkItemStore instance, ref Boolean forceRefresh);
        partial void RegisteredLinkTypes_SetCondition(ref IWorkItemStore instance, ref IRegisteredLinkTypeCollection setValue);
        partial void ResetCachedData_PostValidate(IWorkItemStore instance);
        partial void ResetCachedData_PreCondition(ref IWorkItemStore instance);
        partial void ResetConstantStringCache_PostValidate(IWorkItemStore instance);
        partial void ResetConstantStringCache_PreCondition(ref IWorkItemStore instance);
        partial void SendUpdatePackage_PostValidate(IWorkItemStore instance, XmlElement package, XmlElement result, Boolean bulk);
        partial void SendUpdatePackage_PreCondition(ref IWorkItemStore instance, ref XmlElement package, ref XmlElement result, ref Boolean bulk);
        partial void ServerInfo_SetCondition(ref IWorkItemStore instance, ref IServerInfo setValue);
        partial void ServerStringComparer_SetCondition(ref IWorkItemStore instance, ref StringComparer setValue);
        partial void SyncToCache_PostValidate(IWorkItemStore instance);
        partial void SyncToCache_PreCondition(ref IWorkItemStore instance);
        partial void TeamProjectCollection_SetCondition(ref IWorkItemStore instance, ref ITfsTeamProjectCollection setValue);
        partial void TreeIdToPath_PostValidate(IWorkItemStore instance, Int32 id);
        partial void TreeIdToPath_PreCondition(ref IWorkItemStore instance, ref Int32 id);
        partial void UserDisplayMode_SetCondition(ref IWorkItemStore instance, ref IUserDisplayMode setValue);

        partial void UserDisplayName_SetCondition(ref IWorkItemStore instance, ref String setValue);

        partial void UserSid_SetCondition(ref IWorkItemStore instance, ref String setValue);
        partial void WebServiceUrl_SetCondition(ref IWorkItemStore instance, ref String setValue);
        partial void WorkItemLinkTypes_SetCondition(ref IWorkItemStore instance, ref IWorkItemLinkTypeCollection setValue);
    }
}