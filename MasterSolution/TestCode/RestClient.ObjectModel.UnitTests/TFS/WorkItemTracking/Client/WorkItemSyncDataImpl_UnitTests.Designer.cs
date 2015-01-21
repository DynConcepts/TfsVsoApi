using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemSyncDataImpl_UnitTests : DynTestClassBase
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
        internal static IEnumerable<WorkItemSyncDataImpl> GetIEnumerableInstance() { return new List<WorkItemSyncDataImpl> {GetInstance()}; }

        internal static WorkItemSyncDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemSyncDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemSyncDataImpl instance, [CallerMemberName] string callerName = "");
        partial void RowSets_SetCondition(ref IWorkItemSyncData instance, ref IIWorkItemRowSets setValue);
    }
}