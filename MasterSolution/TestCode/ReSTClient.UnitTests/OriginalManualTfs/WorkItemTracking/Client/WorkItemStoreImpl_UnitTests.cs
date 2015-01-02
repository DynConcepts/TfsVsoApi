using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemStoreImpl_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemStoreImpl_UnitTests : UnitTestBase
    {
        /// <summary>
        ///     Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context)
        {
            var api = new JsonWitAPI();
            Assert.IsNotNull(api);
        }

        /// <summary>
        ///     Alls the properties_ unit test.
        /// </summary>
        [TestMethod]
        public void AllProperties_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            ReadAllProperties(typeof (IWorkItemStore), instance);
        }

        /// <summary>
        ///     Batches the save_ unit test.
        /// </summary>
        [TestMethod]
        public void BatchSave_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IBatchSaveError[] actual = instance.BatchSave(new IWorkItem[] {});
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Batches the save_ unit test1.
        /// </summary>
        [TestMethod]
        public void BatchSave_UnitTest1()
        {
            IWorkItemStore instance = GetTestInstance();
            IBatchSaveError[] actual = instance.BatchSave(new IWorkItem[] {}, ISaveFlags.None);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Caches the constant strings_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void CacheConstantStrings_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.CacheConstantStrings();
        }

        /// <summary>
        ///     Destroys the work items_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void DestroyWorkItems_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IEnumerable<IWorkItemOperationError> actual = instance.DestroyWorkItems(new int[] {});
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Exports the global lists_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void ExportGlobalLists_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.ExportGlobalLists();
        }

        /// <summary>
        ///     Gets the global and project groups_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetGlobalAndProjectGroups_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            List<string> actual = instance.GetGlobalAndProjectGroups(0, false);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the node permissions_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetNodePermissions_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IPsUserRightsMask actual = instance.GetNodePermissions(0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the person name by id_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetPersonNameById_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            string actual = instance.GetPersonNameById(0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the query definition_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetQueryDefinition_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IQueryDefinition actual = instance.GetQueryDefinition(Guid.Empty);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the query hierarchy_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetQueryHierarchy_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IQueryHierarchy actual = instance.GetQueryHierarchy(null);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the referencing work item uris_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetReferencingWorkItemUris_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            Uri[] actual = instance.GetReferencingWorkItemUris(new Uri(VSOClientManager.VsoCollection));
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the stored query_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetStoredQuery_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IStoredQuery actual = instance.GetStoredQuery(Guid.Empty);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item ids for artifact uris_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetWorkItemIdsForArtifactUris_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            Dictionary<string, int[]> actual = instance.GetWorkItemIdsForArtifactUris(new string[] {}, DateTime.Now);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItem_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IWorkItem actual = instance.GetWorkItem(194);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetWorkItem_UnitTest1()
        {
            IWorkItemStore instance = GetTestInstance();
            IWorkItem actual = instance.GetWorkItem(194, DateTime.Now);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetWorkItem_UnitTest2()
        {
            IWorkItemStore instance = GetTestInstance();
            CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");
            IWorkItem actual = instance.GetWorkItem(new Uri(credentials.VsoCollection));
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetWorkItem_UnitTest3()
        {
            IWorkItemStore instance = GetTestInstance();
            IWorkItem actual = instance.GetWorkItem(new Uri(VSOClientManager.VsoCollection), DateTime.Now);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item_ unit test4.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void GetWorkItem_UnitTest4()
        {
            IWorkItemStore instance = GetTestInstance();
            IWorkItem actual = instance.GetWorkItem(new Uri(VSOClientManager.VsoCollection), 0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the work item_ unit test5.
        /// </summary>
        [TestMethod]
        public void GetWorkItem_UnitTest5()
        {
            IWorkItemStore instance = GetTestInstance();
            IWorkItem actual = instance.GetWorkItem(194);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Imports the global lists_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void ImportGlobalLists_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.ImportGlobalLists((XmlElement) null);
        }

        /// <summary>
        ///     Imports the global lists_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void ImportGlobalLists_UnitTest1()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.ImportGlobalLists("");
        }


        /// <summary>
        ///     Initialize_s the unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void Initialize_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.Initialize(null);
        }

        /// <summary>
        ///     Invalidates the cache stamp_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void InvalidateCacheStamp_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.InvalidateCacheStamp();
        }

        /// <summary>
        ///     Gets the global and project groups_ unit test.
        /// </summary>
        [TestMethod]
        public void Projects_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            IProjectCollection actual = instance.Projects;
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Queries the count_ unit test.
        /// </summary>
        [TestMethod]
        public void QueryCount_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            int actual = instance.QueryCount(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Queries the count_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void QueryCount_UnitTest1()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            int actual = instance.QueryCount(wiql, null);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Query_s the unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void Query_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";

            IWorkItemCollection actual = instance.Query(new int[] {}, wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Query_s the unit test1.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest1()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            IWorkItemCollection actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Query_s the unit test2.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest2()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            IWorkItemCollection actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Query_s the unit test3.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest3()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            IWorkItemCollection actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Query_s the unit test4.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest4()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            IWorkItemCollection actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Query_s the unit test5.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest5()
        {
            IWorkItemStore instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            IWorkItemCollection actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Refreshes the cache_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void RefreshCache_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.RefreshCache();
        }

        /// <summary>
        ///     Refreshes the cache_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void RefreshCache_UnitTest1()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.RefreshCache();
        }

        /// <summary>
        ///     Resets the cached data_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void ResetCachedData_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.ResetCachedData();
        }

        /// <summary>
        ///     Resets the constant string cache_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void ResetConstantStringCache_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            instance.ResetConstantStringCache();
        }

        /// <summary>
        ///     Sends the update package_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void SendUpdatePackage_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            XmlElement result;
            instance.SendUpdatePackage(null, out result, false);
        }

        /// <summary>
        ///     Synchronizes to cache_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void SyncToCache_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            bool actual = instance.SyncToCache();
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Trees the identifier to path_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof (ToBeImplementedException))]
        public void TreeIdToPath_UnitTest()
        {
            IWorkItemStore instance = GetTestInstance();
            string actual = instance.TreeIdToPath(0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///     Gets the test instance.
        /// </summary>
        /// <returns>IWorkItemStore.</returns>
        internal static IWorkItemStore GetTestInstance() { return new WorkItemStoreImpl(); }
    }
}