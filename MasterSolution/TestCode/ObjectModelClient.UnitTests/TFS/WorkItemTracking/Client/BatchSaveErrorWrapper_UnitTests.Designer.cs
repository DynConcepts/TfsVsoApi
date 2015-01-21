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
    public partial class BatchSaveErrorWrapper_UnitTests : DynTestClassBase
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
        internal static IEnumerable<BatchSaveErrorWrapper> GetIEnumerableInstance() { return new List<BatchSaveErrorWrapper> {GetInstance()}; }

        internal static BatchSaveErrorWrapper GetInstance()
        {
            BatchSaveError real = default(BatchSaveError);
            RealInstanceFactory(ref real);
            var instance = (BatchSaveErrorWrapper) BatchSaveErrorWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref BatchSaveErrorWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref BatchSaveError real, [CallerMemberName] string callerName = "");

        partial void WorkItem_SetCondition(ref IBatchSaveError instance, ref IWorkItem setValue);
    }
}