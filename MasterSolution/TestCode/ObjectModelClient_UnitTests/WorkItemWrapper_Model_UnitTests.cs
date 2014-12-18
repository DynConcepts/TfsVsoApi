using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.Factories;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests
{
    /// <summary>
    /// Class WorkItemWrapper_Model_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemWrapper_Model_UnitTests
    {
        /// <summary>
        /// Objects the properties_ unit test.
        /// </summary>
        [TestMethod]
        public void ObjectProperties_UnitTest()
        {
            var workItem = GetTargetWorkItem(194);
            var links1 = ((IWorkItem)workItem).Links;
            var links2 = ((IWorkItem)workItem).Links;
            Assert.AreEqual(links1.GetType(), links2.GetType());
        }

        private static WorkItemWrapper GetTargetWorkItem(int id)
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            var idList = new List<int> {id};
            Task<IReadOnlyList<IWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<IWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            var workItem = (WorkItemWrapper) result[0];
            return workItem;
        }


        /// <summary>
        /// Links_s the unit test.
        /// </summary>
        [TestMethod]
        public void Links_UnitTest()
        {
            IWorkItem workItem = GetTargetWorkItem(194);
            ILinkCollection links = workItem.Links;
            foreach (var link in links)
            {
                Debug.WriteLine("x");
            }
        }

    }
}
