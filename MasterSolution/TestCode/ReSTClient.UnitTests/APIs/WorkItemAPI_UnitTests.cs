using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Factories;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>
    ///     Class WorkItemAPI_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemAPI_UnitTests
    {
        /// <summary>
        ///     Assemblies the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            RestClientManager.BasicAuthorizationUsername = "*****";  // TODO Put in appropriate value, then refactor
            RestClientManager.BasicAuthorizationPassword = "*****";  // TODO Put in appropriate value, then refactor
            VSOClientManager.VsoCollection = "*****";  // TODO Put in appropriate value, then refactor
        }


        /// <summary>
        ///     Builds the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void BuildWorkItem_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;
            var fieldValues = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("System.Title", "Sample Title"),
   
            };
            JsonWorkItem workItem = api.BuildWorkItem("RestPlaypen", "Task", fieldValues);
            Assert.IsNotNull(workItem);
        }

        /// <summary>
        ///     Creates the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void CreateWorkItem_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;

            const string project = "RestPlaypen";
            const string workItemType = "Task";
            var fieldValues = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("System.Title", "WorkItem Created by Unit Testing")
//                new KeyValuePair<string, object>("System.Project", "RestPlaypen"),
//                new KeyValuePair<string, object>("System.WorkItemType", "Task")

            };
            JsonWorkItem workItem = api.BuildWorkItem(project,workItemType, fieldValues);
            Task<JsonWorkItem> createTask = api.CreateWorkItem(project, workItemType, workItem, false);
            JsonWorkItem finalResult = createTask.Result;
            Assert.IsNotNull(finalResult);
        }


        /// <summary>
        ///     Gets the areas_ unit test.
        /// </summary>
        [TestMethod]
        public void GetAreas_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<JsonArea>> task = api.GetAreas(project, 999);
            IReadOnlyList<JsonArea> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the fields_ unit test.
        /// </summary>
        [TestMethod]
        public void GetFieldDefinitions_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;

            Task<IReadOnlyList<JsonFieldDefinition>> task = api.GetFieldDefinitions();
            IReadOnlyList<JsonFieldDefinition> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the iterations_ unit test.
        /// </summary>
        [TestMethod]
        public void GetIterations_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;
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
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<JsonWorkItemTypeCategory>> task = api.GetWorkItemTypeCategories(project);
            IReadOnlyList<JsonWorkItemTypeCategory> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        ///     Gets the work item types_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItemTypes_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyDictionary<string, JsonWorkItemType>> task = api.GetWorkItemTypes(project);
            IReadOnlyDictionary<string, JsonWorkItemType> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }
        /// <summary>
        /// Gets the relation types_ unit test.
        /// </summary>
        [TestMethod]
        public void GetRelationTypes_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;
            Task<IReadOnlyList<JsonRelationType>> task = api.GetRelationTypes();
            IReadOnlyList<JsonRelationType> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        ///     Gets the work items_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItems_UnitTest()
        {
            var api = new JsonWorkItemAPI();
            var idList = new List<int> {62};
            Task<IReadOnlyList<JsonWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<JsonWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
        }

        /// <summary>
        ///     Wiqls the query_ unit test.
        /// </summary>
        [TestMethod]
        public void WiqlQuery_UnitTest()
        {
            JsonWorkItemAPI api = APIFactory.JsonWorkItemAPI;

            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            Task<IReadOnlyList<JsonWorkItem>> task = api.WiqlQuery(wiql, true);
            IReadOnlyList<JsonWorkItem> result = task.Result;
            Debug.WriteLine("WIQL Query returned {0} ItemDictionary", result.Count);
            Assert.IsNotNull(result);
        }
    }
}