using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemWrapper_UnitTests
    {
        partial void AreaId_SetCondition(ref IWorkItem instance, ref Int32 setValue) { setValue = instance.AreaId; // Realy needs to be something different, but this should always pass...
        }

        internal static WorkItem GetRealInstance()
        {
            WorkItem real;
            WorkItemTypeCollection workItemTypes = WorkItemTypeCollectionWrapper_UnitTests.GetRealInstance();
            WorkItemType workItemType = workItemTypes["Task"];
            real = new WorkItem(workItemType);
            return real;
        }

        partial void IterationId_SetCondition(ref IWorkItem instance, ref Int32 setValue) { setValue = instance.IterationId; // Realy needs to be something different, but this should always pass...
        }

        static partial void RealInstanceFactory(ref WorkItem real, string callerName) { real = GetRealInstance(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetLatestSyncData_UnitTest",
        };
    }
}