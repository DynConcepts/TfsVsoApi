using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.Factories;
using DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
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
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            var idList = new List<int> { 194 };
            Task<IReadOnlyList<IWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<IWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            var workItem = (WorkItemWrapper)result[0];
            var links1 = ((IWorkItem)workItem).Links;
            var links2 = ((IWorkItemOM)workItem).Links;
            Assert.AreNotEqual(links1.GetType(), links2.GetType());
        }
    }
}
