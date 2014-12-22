using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemTypeWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemType real, string callerName)
        {
            WorkItemTypeCollection workItemTypes = WorkItemTypeCollectionWrapper_UnitTests.GetRealInstance();
            real = workItemTypes["Task"];
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetNextState_UnitTest",
        };
    }
}