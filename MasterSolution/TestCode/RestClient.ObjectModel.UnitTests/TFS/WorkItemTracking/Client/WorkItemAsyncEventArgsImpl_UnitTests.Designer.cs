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
    public partial class WorkItemAsyncEventArgsImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CancelableAsyncResult_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemAsyncEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CancelableAsyncResult; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NewState_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemAsyncEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.NewState; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void OldState_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemAsyncEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.OldState; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CancelableAsyncResult_SetCondition(ref IWorkItemAsyncEventArgs instance, ref ICancelableAsyncResult setValue);
        internal static IEnumerable<WorkItemAsyncEventArgsImpl> GetIEnumerableInstance() { return new List<WorkItemAsyncEventArgsImpl> {GetInstance()}; }

        internal static WorkItemAsyncEventArgsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemAsyncEventArgsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemAsyncEventArgsImpl instance, [CallerMemberName] string callerName = "");

        partial void NewState_SetCondition(ref IWorkItemAsyncEventArgs instance, ref ICancelableActionState setValue);
        partial void OldState_SetCondition(ref IWorkItemAsyncEventArgs instance, ref ICancelableActionState setValue);
    }
}