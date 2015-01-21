using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemSyncDataWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DataVersion_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemSyncData) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DataVersion; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RowSets_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemSyncData) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RowSets; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void DataVersion_SetCondition(ref IWorkItemSyncData instance, ref Int32 setValue);
        internal static IEnumerable<WorkItemSyncDataWrapper> GetIEnumerableInstance() { return new List<WorkItemSyncDataWrapper> {GetInstance()}; }

        internal static WorkItemSyncDataWrapper GetInstance()
        {
            WorkItemSyncData real = default(WorkItemSyncData);
            RealInstanceFactory(ref real);
            var instance = (WorkItemSyncDataWrapper) WorkItemSyncDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemSyncDataWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemSyncData real, [CallerMemberName] string callerName = "");

        partial void RowSets_SetCondition(ref IWorkItemSyncData instance, ref IIWorkItemRowSets setValue);
    }
}