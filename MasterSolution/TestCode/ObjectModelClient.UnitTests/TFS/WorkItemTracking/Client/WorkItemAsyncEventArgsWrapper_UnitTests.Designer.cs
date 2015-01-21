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
    public partial class WorkItemAsyncEventArgsWrapper_UnitTests : DynTestClassBase
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
        internal static IEnumerable<WorkItemAsyncEventArgsWrapper> GetIEnumerableInstance() { return new List<WorkItemAsyncEventArgsWrapper> {GetInstance()}; }

        internal static WorkItemAsyncEventArgsWrapper GetInstance()
        {
            WorkItemAsyncEventArgs real = default(WorkItemAsyncEventArgs);
            RealInstanceFactory(ref real);
            var instance = (WorkItemAsyncEventArgsWrapper) WorkItemAsyncEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemAsyncEventArgsWrapper instance, [CallerMemberName] string callerName = "");

        partial void NewState_SetCondition(ref IWorkItemAsyncEventArgs instance, ref ICancelableActionState setValue);
        partial void OldState_SetCondition(ref IWorkItemAsyncEventArgs instance, ref ICancelableActionState setValue);
        static partial void RealInstanceFactory(ref WorkItemAsyncEventArgs real, [CallerMemberName] string callerName = "");
    }
}