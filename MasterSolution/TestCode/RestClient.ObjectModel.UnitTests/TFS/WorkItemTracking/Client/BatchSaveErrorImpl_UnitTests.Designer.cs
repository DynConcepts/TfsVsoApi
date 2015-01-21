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
    public partial class BatchSaveErrorImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Exception_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IBatchSaveError) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Exception; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItem_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IBatchSaveError) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItem; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Exception_SetCondition(ref IBatchSaveError instance, ref Exception setValue);
        internal static IEnumerable<BatchSaveErrorImpl> GetIEnumerableInstance() { return new List<BatchSaveErrorImpl> {GetInstance()}; }

        internal static BatchSaveErrorImpl GetInstance([CallerMemberName] string callerName = "")
        {
            BatchSaveErrorImpl instance = default(BatchSaveErrorImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref BatchSaveErrorImpl instance, [CallerMemberName] string callerName = "");
        partial void WorkItem_SetCondition(ref IBatchSaveError instance, ref IWorkItem setValue);
    }
}