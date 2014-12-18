using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>
    /// Summary description for JsonWorkItem_UnitTests
    /// </summary>
    [TestClass]
    public class JsonWorkItem_UnitTests
    {
    
        /// <summary>
        /// Fieldses this instance.
        /// </summary>
        [TestMethod]
        public void Fields()
        {
            JsonWorkItem instance = GetTestInstance();
            JsonFieldCollection actual = instance.Fields;
        }
 
  
        /// <summary>
        /// Rev_s the unit test.
        /// </summary>
        [TestMethod]
        public void Rev_UnitTest()
        {
            JsonWorkItem instance = GetTestInstance();
            int actual = instance.Rev;
        }

 
  
      /// <summary>
        /// Links_s the unit test.
        /// </summary>
        [TestMethod]
        public void Links_UnitTest()
        {
            JsonWorkItem instance = GetTestInstance();
            JsonLinkCollection actual = instance.Links;
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }

        /// <summary>
        /// Initializes static members of the <see cref="JsonWorkItem_UnitTests"/> class.
        /// </summary>
        static JsonWorkItem_UnitTests()
        {
            s_TestInstance = new LazyWithReset<JsonWorkItem>(TestInstanceCreator);
        }
        /// <summary>
        /// The s_ test instance
        /// </summary>
        private static LazyWithReset<JsonWorkItem> s_TestInstance;
        /// <summary>
        /// Gets the test instance.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        private static JsonWorkItem GetTestInstance() { return s_TestInstance.Value; }
        /// <summary>
        /// Tests the instance creator.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        private static JsonWorkItem TestInstanceCreator()
        {
            var api = new JsonWorkItemAPI();
            var idList = new List<int> { 194 };
            Task<IReadOnlyList<JsonWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<JsonWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
            return result[0];
        }
    }
}