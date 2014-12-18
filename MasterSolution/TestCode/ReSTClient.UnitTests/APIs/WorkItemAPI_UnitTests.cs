using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.APIs.UnitTests
{
    [TestClass()]
    public class WorkItemAPI_UnitTests
    {
        /// <summary>
        /// Assemblies the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            // TODO:  These must be filled in in order to run unit tests!!!!
            RestClientManager.BasicAuthorizationUsername = "******";
            RestClientManager.BasicAuthorizationPassword = "******";
            VSOClientManager.VsoCollection = "*****";
        }


        [TestMethod()]
        public void GetWorkItems_UnitTest()
        {
            var api = new WorkItemAPI();
            var idList = new List<int> { 62 };
            var task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            var result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
        }
    }
}
