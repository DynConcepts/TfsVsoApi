using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class WorkItemStoreDiagnosticsWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref WorkItemStoreDiagnostics real, string callerName)
        {
            real = (WorkItemStoreDiagnostics)FormatterServices.GetUninitializedObject(typeof(WorkItemStoreDiagnostics));
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "RoundTripCount_UnitTest",
            "RoundTripTime_UnitTest",
        };

    }
}