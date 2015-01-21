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
    public partial class WorkItemTypeWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DisplayForm_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DisplayForm; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Export_UnitTest()
        {
            Boolean includeGlobalListsFlag = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItemType) GetInstance(); },
                instance =>
                {
                    includeGlobalListsFlag = default(Boolean); //No Constructor
                    Export_PreCondition(instance, ref includeGlobalListsFlag);
                },
                instance => { instance.Export(includeGlobalListsFlag); },
                instance => { Export_PostValidate(instance, includeGlobalListsFlag); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldDefinitions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldDefinitions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetNextState_UnitTest()
        {
            String currentState = default(String);
            String action = default(String);
            ExecuteMethod(
                () => { return (IWorkItemType) GetInstance(); },
                instance =>
                {
                    currentState = default(String); //No Constructor
                    action = default(String); //No Constructor
                    GetNextState_PreCondition(instance, ref currentState, ref action);
                },
                instance => { instance.GetNextState(currentState, action); },
                instance => { GetNextState_PostValidate(instance, currentState, action); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NewWorkItem_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItemType) GetInstance(); },
                instance => { NewWorkItem_PreCondition(instance); },
                instance => { instance.NewWorkItem(); },
                instance => { NewWorkItem_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Project_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Project; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Store_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemType) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Store; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void DisplayForm_SetCondition(ref IWorkItemType instance, ref String setValue);
        partial void Export_PostValidate(IWorkItemType instance, Boolean includeGlobalListsFlag);
        partial void Export_PreCondition(IWorkItemType instance, ref Boolean includeGlobalListsFlag);

        partial void FieldDefinitions_SetCondition(ref IWorkItemType instance, ref IFieldDefinitionCollection setValue);
        internal static IEnumerable<WorkItemTypeWrapper> GetIEnumerableInstance() { return new List<WorkItemTypeWrapper> {GetInstance()}; }

        internal static WorkItemTypeWrapper GetInstance()
        {
            WorkItemType real = default(WorkItemType);
            RealInstanceFactory(ref real);
            var instance = (WorkItemTypeWrapper) WorkItemTypeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetNextState_PostValidate(IWorkItemType instance, String currentState, String action);
        partial void GetNextState_PreCondition(IWorkItemType instance, ref String currentState, ref String action);
        static partial void InstanceFactory(ref WorkItemTypeWrapper instance, [CallerMemberName] string callerName = "");
        partial void NewWorkItem_PostValidate(IWorkItemType instance);
        partial void NewWorkItem_PreCondition(IWorkItemType instance);
        partial void Project_SetCondition(ref IWorkItemType instance, ref IProject setValue);
        static partial void RealInstanceFactory(ref WorkItemType real, [CallerMemberName] string callerName = "");

        partial void Store_SetCondition(ref IWorkItemType instance, ref IWorkItemStore setValue);
    }
}