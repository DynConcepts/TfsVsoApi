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
    public partial class WorkItemLinkTypeEndWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ImmutableName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeEnd) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ImmutableName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsForwardLink_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeEnd) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsForwardLink; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void OppositeEnd_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkTypeEnd) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.OppositeEnd; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<WorkItemLinkTypeEndWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkTypeEndWrapper> {GetInstance()}; }

        internal static WorkItemLinkTypeEndWrapper GetInstance()
        {
            WorkItemLinkTypeEnd real = default(WorkItemLinkTypeEnd);
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkTypeEndWrapper) WorkItemLinkTypeEndWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void ImmutableName_SetCondition(ref IWorkItemLinkTypeEnd instance, ref String setValue);
        static partial void InstanceFactory(ref WorkItemLinkTypeEndWrapper instance, [CallerMemberName] string callerName = "");

        partial void IsForwardLink_SetCondition(ref IWorkItemLinkTypeEnd instance, ref Boolean setValue);
        partial void OppositeEnd_SetCondition(ref IWorkItemLinkTypeEnd instance, ref IWorkItemLinkTypeEnd setValue);
        static partial void RealInstanceFactory(ref WorkItemLinkTypeEnd real, [CallerMemberName] string callerName = "");
    }
}