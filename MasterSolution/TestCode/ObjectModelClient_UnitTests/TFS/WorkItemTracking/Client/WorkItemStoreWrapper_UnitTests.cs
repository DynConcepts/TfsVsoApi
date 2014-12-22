using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemStoreWrapper_UnitTests
    {
        internal static WorkItemStore GetRealInstance()
        {
            CredentialsStore credentials = CredentialsProvider.Read(@"..\..\..\RestCredentials.xml");
            var uri = new Uri(credentials.VsoCollection);
            var tpc = new TfsTeamProjectCollection(uri);
            var real = tpc.GetService<WorkItemStore>();
            return real;
        }

        partial void QueryCount_PreCondition(ref IWorkItemStore instance, ref String wiql) { wiql = DefaultWiql; }
        partial void Query_PreCondition(ref IWorkItemStore instance, ref String wiql) { wiql = DefaultWiql; }
        static partial void RealInstanceFactory(ref WorkItemStore real, string callerName) { real = GetRealInstance(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private const string DefaultWiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "DestroyWorkItems_UnitTest",
            "SendUpdatePackage_UnitTest",
            "ImportGlobalLists_UnitTest",
            "GetReferencingWorkItemUris_UnitTest"
        };
    }
}