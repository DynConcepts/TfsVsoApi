using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryHierarchyProviderWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref QueryHierarchyProvider real, string callerName)
        {
            WorkItemStore store = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            real = new QueryHierarchyProvider(store);
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetQueryDefinition_UnitTest"
        };
    }
}