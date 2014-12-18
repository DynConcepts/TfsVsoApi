using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.WrapperImplementations
{
    /// <summary>
    /// Class WorkItemCollectionWrapper_UnitTests.
    /// </summary>
    [TestClass]
    public class WorkItemCollectionWrapper_UnitTests : Wrapper_UnitTestsBase
    {
        /// <summary>
        /// Reads all properties_ unit test.
        /// </summary>
        [TestMethod]
        public void ReadAllProperties_UnitTest()
        {
            var uri = new Uri("*****");  // TODO Put in appropriate value, then refactor
            var tpc = new TfsTeamProjectCollection(uri);
            tpc.EnsureAuthenticated();
            var workItemStore = tpc.GetService<WorkItemStore>();
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            var real = workItemStore.Query(wiql);
             var instance = WorkItemCollectionWrapper.GetWrapper(real);
            ReadAllProperties(typeof(IWorkItemCollection), instance);
        }
    }
}
