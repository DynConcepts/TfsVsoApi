using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
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
        public void Fields_UnitTest()
        {
            JsonWorkItem instance = GetTestInstance();
            JsonFieldCollection actual = instance.Fields;
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(JsonFieldCollection), actual.GetType());
            Assert.IsTrue(actual.Count > 0);
            var firstField = actual[0];
            Assert.IsNotNull(firstField);
            Assert.AreSame(typeof(JsonField), firstField.GetType());
        }
 
  
        /// <summary>
        /// Rev_s the unit test.
        /// </summary>
        [TestMethod]
        public void Rev_UnitTest()
        {
            JsonWorkItem instance = GetTestInstance();
            int actual = instance.Rev;
            Assert.IsNotNull(actual);
        }

 
  
      /// <summary>
        /// Links_s the unit test.
        /// </summary>
        [TestMethod]
        public void Links_UnitTest()
      {
          JsonWorkItem instance = GetTestInstance();
          LinkClassValidation<JsonWorkItem, JsonLinkCollection, JsonRelatedLink>(instance);
      }

        internal static void LinkClassValidation<TWorkItem, TLinkCollection,TLinkItem>(TWorkItem instance)
            where TWorkItem : JsonWorkItem
            where TLinkCollection : JsonLinkCollection
            where TLinkItem : JsonRelatedLink
        {
            object actual = instance.Links;
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(TLinkCollection), actual.GetType());
            var castCollection = (TLinkCollection)actual;
            Assert.IsTrue(castCollection.Count > 0);
            object firstLink = castCollection[0];
            Assert.IsNotNull(firstLink);
            Assert.AreSame(typeof(TLinkItem), firstLink.GetType());
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