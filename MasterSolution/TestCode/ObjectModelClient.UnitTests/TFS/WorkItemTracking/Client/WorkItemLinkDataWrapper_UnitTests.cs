using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemLinkDataWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemLinkData real, string callerName)
        {
            WorkItem workItem = WorkItemWrapper_UnitTests.GetRealInstance();
            real = workItem.LinkData;
        }

        
    /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetLinkInfo_UnitTest",
            "MarkLinkToDelete_UnitTest"
        };   }
}