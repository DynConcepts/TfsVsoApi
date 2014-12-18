using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemStoreWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemStore real, string callerName) { real = GetRealInstance(); }

        internal static WorkItemStore GetRealInstance()
        {
            var uri = new Uri("*****");// TODO Put in appropriate value, then refactor
            var tpc = new TfsTeamProjectCollection(uri);
            var real = tpc.GetService<WorkItemStore>();
            return real;
        }

        private static readonly List<String> sr_DisabledTests = new List<string>()
      {
          "DestroyWorkItems_UnitTest",
          "SendUpdatePackage_UnitTest",
          "ImportGlobalLists_UnitTest",
          "GetReferencingWorkItemUris_UnitTest"
      };
        /// <summary>
        /// Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        const string DefaultWiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
        partial void Query_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String wiql)
        {
            wiql = DefaultWiql;
        }

        partial void QueryCount_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore instance, ref System.String wiql)
        {
            wiql = DefaultWiql;
        }

    }
}
