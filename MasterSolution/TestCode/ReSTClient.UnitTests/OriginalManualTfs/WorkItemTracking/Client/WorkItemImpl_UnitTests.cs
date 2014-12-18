using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Objects;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.WorkItemTracking.Client
{
    /// <summary>
    /// Class WorkItemImpl_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemImpl_UnitTests : UnitTestBase
    {
        /// <summary>
        /// Links_s the unit test.
        /// </summary>
        [TestMethod]
        public void Links_UnitTest()
        {
            WorkItemImpl instance = GetTestInstance();
            JsonWorkItem_UnitTests.LinkClassValidation<WorkItemImpl, LinkCollectionImpl, RelatedLinkImpl>(instance);
        }

        /// <summary>
        /// Alls the properties_ unit test.
        /// </summary>
        [TestMethod]
        public void AllProperties_UnitTest()
        {
            var instance = GetTestInstance();
            ReadAllProperties(typeof(IWorkItem), instance);
        }


        /// <summary>
        /// Save_s the unit test.
        /// </summary>
        [TestMethod]
        public void Save_UnitTest()
        {
            var api = new WorkItemAPI();
            var fieldValues = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("System.Title", "Save Testing")

            };
            IWorkItem instance = api.BuildWorkItem("RestPlaypen", "Task", fieldValues);
            Assert.AreEqual(-1, instance.Id);
            Assert.AreEqual(-1, instance.Rev);

            var originalIdField = instance.Fields["System.Id"];
            var originalRevField = instance.Fields["System.Rev"];
            Assert.AreEqual(-1, originalRevField.Value);

            instance.Save();

            Assert.IsTrue(instance.Id > 0);
            Assert.AreEqual(1, instance.Rev);

            var updatedIdField = instance.Fields["System.Id"];
            Assert.AreEqual(instance.Id, (int)(Int64)updatedIdField.Value);
            Assert.AreSame(originalIdField, updatedIdField);
            
            var updatedRevField = instance.Fields["System.Rev"];
            Assert.AreEqual(instance.Rev, (int)(Int64)updatedRevField.Value);
            Assert.AreSame(originalRevField, updatedRevField);
        }

        /// <summary>
        /// Initializes static members of the <see cref="WorkItemImpl_UnitTests" /> class.
        /// </summary>
        static WorkItemImpl_UnitTests() { sr_TestInstance = new LazyWithReset<WorkItemImpl>(TestInstanceCreator); }

        /// <summary>
        /// Gets the test instance.
        /// </summary>
        /// <returns>WorkItemImpl.</returns>
        private static WorkItemImpl GetTestInstance() { return sr_TestInstance.Value; }

        /// <summary>
        /// Tests the instance creator.
        /// </summary>
        /// <returns>WorkItemImpl.</returns>
        private static WorkItemImpl TestInstanceCreator()
        {
            var api = new JsonWorkItemAPI();
            var idList = new List<int> {194};
            Task<IReadOnlyList<WorkItemImpl>> task = api.GetWorkItems(idList, WorkItemImpl.FromToken);
            Assert.IsNotNull(task);
            IReadOnlyList<WorkItemImpl> result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
            return result[0];
        }

        /// <summary>
        /// The s_ test instance
        /// </summary>
        private static readonly LazyWithReset<WorkItemImpl> sr_TestInstance;
    }
}