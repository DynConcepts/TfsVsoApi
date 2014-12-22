using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemStoreDiagnosticsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RoundTripCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStoreDiagnostics) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RoundTripCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RoundTripTime_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemStoreDiagnostics) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RoundTripTime; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<WorkItemStoreDiagnosticsWrapper> GetIEnumerableInstance() { return new List<WorkItemStoreDiagnosticsWrapper> {GetInstance()}; }

        internal static WorkItemStoreDiagnosticsWrapper GetInstance()
        {
            WorkItemStoreDiagnostics real = default(WorkItemStoreDiagnostics);
            RealInstanceFactory(ref real);
            var instance = (WorkItemStoreDiagnosticsWrapper) WorkItemStoreDiagnosticsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemStoreDiagnosticsWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemStoreDiagnostics real, [CallerMemberName] string callerName = "");

        partial void RoundTripCount_SetCondition(ref IWorkItemStoreDiagnostics instance, ref Int32 setValue);

        partial void RoundTripTime_SetCondition(ref IWorkItemStoreDiagnostics instance, ref Int64 setValue);
    }
}