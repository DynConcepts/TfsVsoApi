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
    public partial class WorkItemLinkTypeWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Activate_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkType) GetInstance(); },
                instance => { Activate_PreCondition(instance); },
                instance => { instance.Activate(); },
                instance => { Activate_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CanDelete_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CanDelete; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CanEdit_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CanEdit; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Deactivate_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemLinkType) GetInstance(); },
                instance => { Deactivate_PreCondition(instance); },
                instance => { instance.Deactivate(); },
                instance => { Deactivate_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ForwardEnd_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ForwardEnd; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsDirectional_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsDirectional; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsNonCircular_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsNonCircular; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsOneToMany_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsOneToMany; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkTopology_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LinkTopology; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ReverseEnd_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemLinkType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ReverseEnd; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Activate_PostValidate(IWorkItemLinkType instance);
        partial void Activate_PreCondition(IWorkItemLinkType instance);

        partial void CanDelete_SetCondition(ref IWorkItemLinkType instance, ref Boolean setValue);

        partial void CanEdit_SetCondition(ref IWorkItemLinkType instance, ref Boolean setValue);
        partial void Deactivate_PostValidate(IWorkItemLinkType instance);
        partial void Deactivate_PreCondition(IWorkItemLinkType instance);
        partial void ForwardEnd_SetCondition(ref IWorkItemLinkType instance, ref IWorkItemLinkTypeEnd setValue);
        internal static IEnumerable<WorkItemLinkTypeWrapper> GetIEnumerableInstance() { return new List<WorkItemLinkTypeWrapper> {GetInstance()}; }

        internal static WorkItemLinkTypeWrapper GetInstance()
        {
            WorkItemLinkType real = default(WorkItemLinkType);
            RealInstanceFactory(ref real);
            var instance = (WorkItemLinkTypeWrapper) WorkItemLinkTypeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemLinkTypeWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsDirectional_SetCondition(ref IWorkItemLinkType instance, ref Boolean setValue);
        partial void IsNonCircular_SetCondition(ref IWorkItemLinkType instance, ref Boolean setValue);
        partial void IsOneToMany_SetCondition(ref IWorkItemLinkType instance, ref Boolean setValue);

        partial void LinkTopology_SetCondition(ref IWorkItemLinkType instance, ref IWorkItemLinkType_Topology setValue);
        static partial void RealInstanceFactory(ref WorkItemLinkType real, [CallerMemberName] string callerName = "");
        partial void ReverseEnd_SetCondition(ref IWorkItemLinkType instance, ref IWorkItemLinkTypeEnd setValue);
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public class WorkItemLinkType_TopologyWrapper_UnitTests : DynTestClassBase
    {
        internal static IWorkItemLinkType_Topology GetInstance() { return default(IWorkItemLinkType_Topology); }
    }
}