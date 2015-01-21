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
    public partial class WorkItemCollectionWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DefaultProjectHint_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemCollection) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    DefaultProjectHint_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.DefaultProjectHint = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.DefaultProjectHint; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DisplayFields_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DisplayFields; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetId_UnitTest()
        {
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemCollection) GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    GetId_PreCondition(instance, ref index);
                },
                instance => { instance.GetId(index); },
                instance => { GetId_PostValidate(instance, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PageSize_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemCollection) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    PageSize_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.PageSize = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.PageSize; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Resort_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemCollection) GetInstance(); },
                instance => { Resort_PreCondition(instance); },
                instance => { instance.Resort(); },
                instance => { Resort_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SortFields_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemCollection) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SortFields; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void DefaultProjectHint_SetCondition(ref IWorkItemCollection instance, ref Int32 setValue);

        partial void DisplayFields_SetCondition(ref IWorkItemCollection instance, ref IDisplayFieldList setValue);
        internal static IEnumerable<WorkItemCollectionWrapper> GetIEnumerableInstance() { return new List<WorkItemCollectionWrapper> {GetInstance()}; }
        partial void GetId_PostValidate(IWorkItemCollection instance, Int32 index);
        partial void GetId_PreCondition(IWorkItemCollection instance, ref Int32 index);

        internal static WorkItemCollectionWrapper GetInstance()
        {
            WorkItemCollection real = default(WorkItemCollection);
            RealInstanceFactory(ref real);
            var instance = (WorkItemCollectionWrapper) WorkItemCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemCollectionWrapper instance, [CallerMemberName] string callerName = "");
        partial void PageSize_SetCondition(ref IWorkItemCollection instance, ref Int32 setValue);
        static partial void RealInstanceFactory(ref WorkItemCollection real, [CallerMemberName] string callerName = "");
        partial void Resort_PostValidate(IWorkItemCollection instance);
        partial void Resort_PreCondition(IWorkItemCollection instance);

        partial void SortFields_SetCondition(ref IWorkItemCollection instance, ref ISortFieldList setValue);
    }
}