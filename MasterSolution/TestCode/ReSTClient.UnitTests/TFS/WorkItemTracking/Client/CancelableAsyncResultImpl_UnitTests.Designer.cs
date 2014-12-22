using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CancelableAsyncResultImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BeginAsync_UnitTest()
        {
            ExecuteMethod(
                () => { return (ICancelableAsyncResult) GetInstance(); },
                instance => { BeginAsync_PreCondition(ref instance); },
                instance => { instance.BeginAsync(); },
                instance => { BeginAsync_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Callback_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ICancelableAsyncResult) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    AsyncCallback setValue = default(AsyncCallback);
                    Callback_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Callback = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Callback; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void BeginAsync_PostValidate(ICancelableAsyncResult instance);
        partial void BeginAsync_PreCondition(ref ICancelableAsyncResult instance);
        partial void Callback_SetCondition(ref ICancelableAsyncResult instance, ref AsyncCallback setValue);
        internal static IEnumerable<CancelableAsyncResultImpl> GetIEnumerableInstance() { return new List<CancelableAsyncResultImpl> {GetInstance()}; }

        internal static CancelableAsyncResultImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new CancelableAsyncResultImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref CancelableAsyncResultImpl instance, [CallerMemberName] string callerName = "");
    }
}