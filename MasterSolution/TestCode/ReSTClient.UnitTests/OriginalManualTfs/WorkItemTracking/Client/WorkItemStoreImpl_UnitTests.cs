using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.WorkItemTracking.Client
{
    /// <summary>
    /// Class WorkItemStoreImpl_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemStoreImpl_UnitTests : UnitTestBase 
    {
        /// <summary>
        /// Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context)
        {
            var api = new JsonWorkItemAPI();
            Assert.IsNotNull(api);
        }

        /// <summary>
        /// Alls the properties_ unit test.
        /// </summary>
        [TestMethod]
        public void AllProperties_UnitTest()
        {
            var instance = GetTestInstance();
            ReadAllProperties(typeof(IWorkItemStore), instance);
        }


        /// <summary>
        /// Initialize_s the unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void Initialize_UnitTest()
        {
            var instance = GetTestInstance();
            instance.Initialize(null);
        }

        /// <summary>
        /// Invalidates the cache stamp_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void InvalidateCacheStamp_UnitTest()
        {
            var instance = GetTestInstance();
            instance.InvalidateCacheStamp();
        }

        /// <summary>
        /// Query_s the unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void Query_UnitTest()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";

            var actual = instance.Query(new int[] { }, wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Query_s the unit test1.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest1()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Query_s the unit test2.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest2()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Query_s the unit test3.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest3()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Query_s the unit test4.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest4()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Query_s the unit test5.
        /// </summary>
        [TestMethod]
        public void Query_UnitTest5()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.Query(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Queries the count_ unit test.
        /// </summary>
        [TestMethod]
        public void QueryCount_UnitTest()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.QueryCount(wiql);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Queries the count_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void QueryCount_UnitTest1()
        {
            var instance = GetTestInstance();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var actual = instance.QueryCount(wiql, null);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItem_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItem(194);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetWorkItem_UnitTest1()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItem(194, DateTime.Now);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item_ unit test2.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        void GetWorkItem_UnitTest2()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItem(new Uri("*****")) // TODO Put in appropriate value, then refactor
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item_ unit test3.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetWorkItem_UnitTest3()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItem(new Uri("*****"), DateTime.Now); // TODO Put in appropriate value, then refactor
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item_ unit test4.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetWorkItem_UnitTest4()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItem(new Uri("*****"), 0); // TODO Put in appropriate value, then refactor
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item_ unit test5.
        /// </summary>
        [TestMethod]
        public void GetWorkItem_UnitTest5()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItem(194);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the referencing work item uris_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetReferencingWorkItemUris_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetReferencingWorkItemUris(new Uri("*****")); // TODO Put in appropriate value, then refactor
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the work item ids for artifact uris_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetWorkItemIdsForArtifactUris_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetWorkItemIdsForArtifactUris(new string[] { }, DateTime.Now);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Batches the save_ unit test.
        /// </summary>
        [TestMethod]
        public void BatchSave_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.BatchSave(new IWorkItem[] { });
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Batches the save_ unit test1.
        /// </summary>
        [TestMethod]
        public void BatchSave_UnitTest1()
        {
            var instance = GetTestInstance();
            var actual = instance.BatchSave(new IWorkItem[] { }, ISaveFlags.None);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Refreshes the cache_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void RefreshCache_UnitTest()
        {
            var instance = GetTestInstance();
            instance.RefreshCache();
        }

        /// <summary>
        /// Refreshes the cache_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void RefreshCache_UnitTest1()
        {
            var instance = GetTestInstance();
            instance.RefreshCache();
        }

        /// <summary>
        /// Synchronizes to cache_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void SyncToCache_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.SyncToCache();
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the stored query_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetStoredQuery_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetStoredQuery(Guid.Empty);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the query definition_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetQueryDefinition_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetQueryDefinition(Guid.Empty);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Imports the global lists_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void ImportGlobalLists_UnitTest()
        {
            var instance = GetTestInstance();
            instance.ImportGlobalLists((XmlElement)null);
        }

        /// <summary>
        /// Imports the global lists_ unit test1.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void ImportGlobalLists_UnitTest1()
        {
            var instance = GetTestInstance();
            instance.ImportGlobalLists("");
        }

        /// <summary>
        /// Exports the global lists_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void ExportGlobalLists_UnitTest()
        {
            var instance = GetTestInstance();
            instance.ExportGlobalLists();
        }

        /// <summary>
        /// Destroys the work items_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void DestroyWorkItems_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.DestroyWorkItems(new int[] { });
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Resets the cached data_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void ResetCachedData_UnitTest()
        {
            var instance = GetTestInstance();
            instance.ResetCachedData();
        }

        /// <summary>
        /// Gets the query hierarchy_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetQueryHierarchy_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetQueryHierarchy(null);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Trees the identifier to path_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void TreeIdToPath_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.TreeIdToPath(0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the person name by id_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetPersonNameById_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetPersonNameById(0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the node permissions_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetNodePermissions_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetNodePermissions(0);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Caches the constant strings_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void CacheConstantStrings_UnitTest()
        {
            var instance = GetTestInstance();
            instance.CacheConstantStrings();
        }

        /// <summary>
        /// Resets the constant string cache_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void ResetConstantStringCache_UnitTest()
        {
            var instance = GetTestInstance();
            instance.ResetConstantStringCache();
        }

        /// <summary>
        /// Sends the update package_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void SendUpdatePackage_UnitTest()
        {
            var instance = GetTestInstance();
            XmlElement result;
            instance.SendUpdatePackage(null, out result, false);
        }

        /// <summary>
        /// Gets the global and project groups_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ToBeImplementedException))]
        public void GetGlobalAndProjectGroups_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.GetGlobalAndProjectGroups(0, false);
            Assert.IsNotNull(actual);
        }
        /// <summary>
        /// Gets the global and project groups_ unit test.
        /// </summary>
        [TestMethod]
        public void Projects_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.Projects;
            Assert.IsNotNull(actual);
        }

        /// <summary>
        /// Gets the test instance.
        /// </summary>
        /// <returns>IWorkItemStore.</returns>
        internal static IWorkItemStore GetTestInstance() { return new WorkItemStoreImpl(); }

    }
}
