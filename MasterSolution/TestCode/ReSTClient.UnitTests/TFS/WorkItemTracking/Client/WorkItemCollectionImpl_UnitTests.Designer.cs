using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemCollectionImpl_UnitTests : DynTestClassBase
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
                    GetId_PreCondition(ref instance, ref index);
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
                instance => { Resort_PreCondition(ref instance); },
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
        internal static IEnumerable<WorkItemCollectionImpl> GetIEnumerableInstance() { return new List<WorkItemCollectionImpl> {GetInstance()}; }
        partial void GetId_PostValidate(IWorkItemCollection instance, Int32 index);
        partial void GetId_PreCondition(ref IWorkItemCollection instance, ref Int32 index);

        internal static WorkItemCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItemCollectionImpl instance = default(WorkItemCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemCollectionImpl instance, [CallerMemberName] string callerName = "");
        partial void PageSize_SetCondition(ref IWorkItemCollection instance, ref Int32 setValue);
        partial void Resort_PostValidate(IWorkItemCollection instance);
        partial void Resort_PreCondition(ref IWorkItemCollection instance);

        partial void SortFields_SetCondition(ref IWorkItemCollection instance, ref ISortFieldList setValue);
    }
}