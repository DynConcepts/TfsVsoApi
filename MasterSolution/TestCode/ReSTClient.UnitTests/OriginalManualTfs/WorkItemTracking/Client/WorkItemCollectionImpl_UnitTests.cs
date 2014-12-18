using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.WorkItemTracking.Client
{
    /// <summary>
    /// Class WorkItemCollectionImpl_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemCollectionImpl_UnitTests : UnitTestBase
    {
        /// <summary>
        /// Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context)
        {
            var api = new JsonWorkItemAPI();
        }


        /// <summary>
        /// Alls the properties_ unit test.
        /// </summary>
        [TestMethod]
        public void AllProperties_UnitTest()
        {
            var instance = GetTestInstance();
            ReadAllProperties(typeof(IWorkItemCollection),instance);
        }

        /// <summary>
        /// Works the item collection impl_ unit test.
        /// </summary>
        [TestMethod]
        public void WorkItemCollectionImpl_UnitTest()
        {
            var initialItems = new List<WorkItemImpl>();
            var instance = new WorkItemCollectionImpl(null,initialItems);
            Assert.IsNotNull(instance);
        }
        /// <summary>
        /// Contains_s the unit test.
        /// </summary>
        [TestMethod]
        public void Contains_UnitTest()
        {
            IWorkItemCollection instance = GetTestInstance();
            bool actual = instance.Contains(null);
        }

        /// <summary>
        /// Copies the to_ unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DynCon.OSI.Core.Helpers.ToBeImplementedException))]
        public void CopyTo_UnitTest()
        {
            IWorkItemCollection instance = GetTestInstance();
            instance.CopyTo(null, 0);
        }

        /// <summary>
        /// Gets the enumerator_ unit test.
        /// </summary>
        [TestMethod]
        public void GetEnumerator_UnitTest()
        {
            IWorkItemCollection instance = GetTestInstance();
            IEnumerator actual = instance.GetEnumerator();
        }

        /// <summary>
        /// Gets the id_ unit test.
        /// </summary>
        [TestMethod]
        public void GetId_UnitTest()
        {
            IWorkItemCollection instance = GetTestInstance();
            int actual = instance.GetId(0);
        }

        /// <summary>
        /// Indexes the of_ unit test.
        /// </summary>
        [TestMethod]
        public void IndexOf_UnitTest()
        {
            IWorkItemCollection instance = GetTestInstance();
            int actual = instance.IndexOf(null);
        }

        /// <summary>
        /// Indexes the of_ unit test1.
        /// </summary>
        [TestMethod]
        public void IndexOf_UnitTest1()
        {
            IWorkItemCollection instance = GetTestInstance();
            int actual = instance.IndexOf(1);
        }

        /// <summary>
        /// Resort_s the unit test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DynCon.OSI.Core.Helpers.ToBeImplementedException))]
        public void Resort_UnitTest()
        {
            IWorkItemCollection instance = GetTestInstance();
            instance.Resort();
        }

        /// <summary>
        /// Gets the test instance.
        /// </summary>
        /// <returns>IWorkItemCollection.</returns>
        private IWorkItemCollection GetTestInstance()
        {
            var initialItems = new List<WorkItemImpl>();
            initialItems.Add(JsonWorkItem.APIFactory().GetWorkItem(195, WorkItemImpl.FromToken).Result);
            var instance = new WorkItemCollectionImpl(null,initialItems);
            Assert.IsNotNull(instance); ;
            return instance;
        }
    }
}
