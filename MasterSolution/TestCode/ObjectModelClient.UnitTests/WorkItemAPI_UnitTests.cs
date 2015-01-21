using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.Factories;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests
{
    /// <summary>
    ///     Class ClientObjectModel_UnitTests.
    /// </summary>
    [TestClass]
    public class ClientObjectModel_UnitTests
    {
        /// <summary>
        ///     Builds the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void BuildWorkItem_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            var fieldValues = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("System.Title", "Sample Title")
                //new KeyValuePair<string, object>("System.Project", "RestPlaypen"),
                //new KeyValuePair<string, object>("System.WorkItemType", "Task")
            };
            IWorkItem workItem = api.BuildWorkItem("RestPlaypen", "Task", fieldValues);
            Assert.IsNotNull(workItem);
        }

        /// <summary>
        ///     Creates the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void CreateWorkItem_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;

            var fieldValues = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("System.Title", "Sample Title")
                //new KeyValuePair<string, object>("System.Project", "RestPlaypen"),
                //new KeyValuePair<string, object>("System.WorkItemType", "Task")
            };
            IWorkItem workItem = api.BuildWorkItem("RestPlaypen", "Task", fieldValues);
            const string project = "RestPlaypen";
            Task<IWorkItem> createTask = api.CreateWorkItem(project, workItem);
            IWorkItem finalResult = createTask.Result;
            Assert.IsNotNull(finalResult);
        }


        /// <summary>
        ///     Gets the areas_ unit test.
        /// </summary>
        [TestMethod]
        public void GetAreas_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<IArea>> task = api.GetAreas(project, 999);
            IReadOnlyList<IArea> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the fields_ unit test.
        /// </summary>
        [TestMethod]
        public void GetFieldDefinitions_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;

            Task<IReadOnlyList<IFieldDefinition>> task = api.GetFieldDefinitions();
            IReadOnlyList<IFieldDefinition> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the iterations_ unit test.
        /// </summary>
        [TestMethod]
        public void GetIterations_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<IIteration>> task = api.GetIterations(project, 999);
            IReadOnlyList<IIteration> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the work item type categories_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItemTypeCategories_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<ICategory>> task = api.GetWorkItemTypeCategories(project);
            IReadOnlyList<ICategory> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        ///     Gets the work item types_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItemTypes_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyDictionary<string, IWorkItemType>> task = api.GetWorkItemTypes(project);
            IReadOnlyDictionary<string, IWorkItemType> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        ///     Gets the work items_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItems_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            var idList = new List<int> {62};
            Task<IReadOnlyList<IWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<IWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
        }

        /// <summary>
        ///     Wiqls the query_ unit test.
        /// </summary>
        [TestMethod]
        public void WiqlQuery_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;

            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            Task<IReadOnlyList<IWorkItem>> task = api.WiqlQuery(wiql, true);
            IReadOnlyList<IWorkItem> result = task.Result;
            Debug.WriteLine("WIQL Query returned {0} Items", result.Count);
            Assert.IsNotNull(result);
        }
    }
}