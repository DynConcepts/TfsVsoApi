using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkTypeWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemLinkType real, string callerName) { real = GetRealInstance(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "Deactivate_UnitTest",
        };

        /// <summary>
        /// Gets the real instance.
        /// </summary>
        /// <returns>WorkItemLinkType.</returns>
        public static WorkItemLinkType GetRealInstance()
        {
            var workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
            return workItemStore.WorkItemLinkTypes["System.LinkTypes.Related"];
        }
    };
}