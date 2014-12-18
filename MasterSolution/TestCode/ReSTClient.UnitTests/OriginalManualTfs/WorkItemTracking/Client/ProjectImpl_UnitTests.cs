using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.WorkItemTracking.Client
{
    /// <summary>
    /// Summary description for ProjectImpl_UnitTests
    /// </summary>
    [TestClass]
    public class ProjectImpl_UnitTests : UnitTestBase
    {
        /// <summary>
        /// Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context)
        {
            var api = new JsonWorkItemAPI();
            Assert.IsNotNull(api);
        }

        /// <summary>
        /// Alls the properties_ unit test.
        /// </summary>
        [TestMethod]
        public void AllProperties_UnitTest()
        {
            var instance = GetTestInstance();
            ReadAllProperties(typeof(IProject), instance);
        }

        /// <summary>
        /// Queries the hierarchy_ unit test.
        /// </summary>
        [TestMethod]
        public void QueryHierarchy_UnitTest()
        {
            var instance = GetTestInstance();
            var actual = instance.QueryHierarchy;
            Assert.IsNotNull(actual);
        }


        /// <summary>
        /// Gets the test instance.
        /// </summary>
        /// <returns>IProject.</returns>
        internal static IProject GetTestInstance()
        {
            var workItemStore = WorkItemStoreImpl_UnitTests.GetTestInstance();
            var projects = workItemStore.Projects;
            var project = projects["RestPlaypen"];
            return project;
        }


     }
}
