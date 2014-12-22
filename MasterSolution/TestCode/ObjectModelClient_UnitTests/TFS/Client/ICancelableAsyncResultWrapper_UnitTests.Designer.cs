using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ICancelableAsyncResultWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AsyncState_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IICancelableAsyncResult) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AsyncState; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AsyncWaitHandle_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IICancelableAsyncResult) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AsyncWaitHandle; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Cancel_UnitTest()
        {
            ExecuteMethod(
                () => { return (IICancelableAsyncResult) GetInstance(); },
                instance => { Cancel_PreCondition(ref instance); },
                instance => { instance.Cancel(); },
                instance => { Cancel_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CompletedSynchronously_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IICancelableAsyncResult) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CompletedSynchronously; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsCanceled_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IICancelableAsyncResult) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsCanceled; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsCompleted_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IICancelableAsyncResult) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsCompleted; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AsyncState_SetCondition(ref IICancelableAsyncResult instance, ref Object setValue);
        partial void AsyncWaitHandle_SetCondition(ref IICancelableAsyncResult instance, ref WaitHandle setValue);
        partial void Cancel_PostValidate(IICancelableAsyncResult instance);
        partial void Cancel_PreCondition(ref IICancelableAsyncResult instance);

        partial void CompletedSynchronously_SetCondition(ref IICancelableAsyncResult instance, ref Boolean setValue);
        internal static IEnumerable<ICancelableAsyncResultWrapper> GetIEnumerableInstance() { return new List<ICancelableAsyncResultWrapper> {GetInstance()}; }

        internal static ICancelableAsyncResultWrapper GetInstance()
        {
            ICancelableAsyncResult real = default(ICancelableAsyncResult);
            RealInstanceFactory(ref real);
            var instance = (ICancelableAsyncResultWrapper) ICancelableAsyncResultWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ICancelableAsyncResultWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsCanceled_SetCondition(ref IICancelableAsyncResult instance, ref Boolean setValue);
        partial void IsCompleted_SetCondition(ref IICancelableAsyncResult instance, ref Boolean setValue);
        static partial void RealInstanceFactory(ref ICancelableAsyncResult real, [CallerMemberName] string callerName = "");
    }
}