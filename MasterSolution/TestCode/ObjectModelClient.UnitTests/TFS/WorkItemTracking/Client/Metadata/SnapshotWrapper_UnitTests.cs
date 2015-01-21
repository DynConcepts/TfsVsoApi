using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>Generated Test Template</summary>
    public partial class SnapshotWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref Snapshot real, string callerName)
        {
            real = (Snapshot)FormatterServices.GetUninitializedObject(typeof(Snapshot));
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "LoadFieldIdsByWorkItemType_UnitTest",
        };
    }
}