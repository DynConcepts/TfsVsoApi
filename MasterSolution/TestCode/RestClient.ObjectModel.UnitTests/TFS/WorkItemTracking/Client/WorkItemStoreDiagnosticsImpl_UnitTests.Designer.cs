using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemStoreDiagnosticsImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<WorkItemStoreDiagnosticsImpl> GetIEnumerableInstance() { return new List<WorkItemStoreDiagnosticsImpl> {GetInstance()}; }

        internal static WorkItemStoreDiagnosticsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemStoreDiagnosticsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemStoreDiagnosticsImpl instance, [CallerMemberName] string callerName = "");

        partial void RoundTripCount_SetCondition(ref IWorkItemStoreDiagnostics instance, ref Int32 setValue);

        partial void RoundTripTime_SetCondition(ref IWorkItemStoreDiagnostics instance, ref Int64 setValue);
    }
}