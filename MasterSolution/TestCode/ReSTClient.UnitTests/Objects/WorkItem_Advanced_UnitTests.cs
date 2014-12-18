using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>
    /// Class WorkItem_Advanced_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItem_Advanced_UnitTests
    {
        /// <summary>
        /// Links_s the unit test.
        /// </summary>
        [TestMethod]
        public void Links_UnitTest() 
        {
            var workItem = GetTargetWorkItem(194);
            JsonLinkCollection links = workItem.Links;
            foreach (var link in links)
            {
                var asWorkItemLink = link as JsonWorkItemLink;
                if (asWorkItemLink != null)
                {
                    var other = asWorkItemLink.OtherWorkItem;
                    Assert.IsNotNull(other);
                    var backLinks = other.Links;
                    Assert.IsTrue(backLinks.Count > 0);
                }
            }
        }

        private static JsonWorkItem GetTargetWorkItem(int item)
        {
            var api = new JsonWorkItemAPI();
            var idList = new List<int> {item};
            Task<IReadOnlyList<JsonWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<JsonWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
            return result[0];
        }
    }
}
