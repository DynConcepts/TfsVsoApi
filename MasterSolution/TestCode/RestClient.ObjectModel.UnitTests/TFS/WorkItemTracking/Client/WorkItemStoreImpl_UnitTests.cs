using System;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemStoreImpl_UnitTests
    {
        /// <summary>
        ///     Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context) { var api = new JsonWitAPI(); }

        partial void QueryCount_PreCondition(IWorkItemStore instance, ref String wiql) { wiql = DefaultWiql; }
        partial void Query_PreCondition(IWorkItemStore instance, ref String wiql) { wiql = DefaultWiql; }
        private const string DefaultWiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
    }
}