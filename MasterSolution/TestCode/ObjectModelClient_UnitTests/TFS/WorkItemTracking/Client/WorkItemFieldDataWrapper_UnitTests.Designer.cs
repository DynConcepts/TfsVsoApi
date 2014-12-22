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
    public partial class WorkItemFieldDataWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldState_UnitTest()
        {
            Int32 id = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItemFieldData) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    GetFieldState_PreCondition(ref instance, ref id);
                },
                instance => { instance.GetFieldState(id); },
                instance => { GetFieldState_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetUpdateFieldValue_UnitTest()
        {
            Int32 id = default(Int32);
            IWorkItemFieldData_FieldUpdate fu = default(IWorkItemFieldData_FieldUpdate);
            ExecuteMethod(
                () => { return (IWorkItemFieldData) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    fu = WorkItemFieldData_FieldUpdateWrapper_UnitTests.GetInstance();
                    GetUpdateFieldValue_PreCondition(ref instance, ref id, ref fu);
                },
                instance => { instance.GetUpdateFieldValue(id, out fu); },
                instance => { GetUpdateFieldValue_PostValidate(instance, id, fu); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetUpdateFieldValue_UnitTest()
        {
            Int32 id = default(Int32);
            Object value = default(Object);
            IWorkItemFieldData_FieldFlags flags = default(IWorkItemFieldData_FieldFlags);
            ExecuteMethod(
                () => { return (IWorkItemFieldData) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    value = new Object();
                    flags = WorkItemFieldData_FieldFlagsWrapper_UnitTests.GetInstance();
                    SetUpdateFieldValue_PreCondition(ref instance, ref id, ref value, ref flags);
                },
                instance => { instance.SetUpdateFieldValue(id, value, flags); },
                instance => { SetUpdateFieldValue_PostValidate(instance, id, value, flags); });
        }

        partial void GetFieldState_PostValidate(IWorkItemFieldData instance, Int32 id);
        partial void GetFieldState_PreCondition(ref IWorkItemFieldData instance, ref Int32 id);
        internal static IEnumerable<WorkItemFieldDataWrapper> GetIEnumerableInstance() { return new List<WorkItemFieldDataWrapper> {GetInstance()}; }

        internal static WorkItemFieldDataWrapper GetInstance()
        {
            WorkItemFieldData real = default(WorkItemFieldData);
            RealInstanceFactory(ref real);
            var instance = (WorkItemFieldDataWrapper) WorkItemFieldDataWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetUpdateFieldValue_PostValidate(IWorkItemFieldData instance, Int32 id, IWorkItemFieldData_FieldUpdate fu);
        partial void GetUpdateFieldValue_PreCondition(ref IWorkItemFieldData instance, ref Int32 id, ref IWorkItemFieldData_FieldUpdate fu);
        static partial void InstanceFactory(ref WorkItemFieldDataWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref WorkItemFieldData real, [CallerMemberName] string callerName = "");
        partial void SetUpdateFieldValue_PostValidate(IWorkItemFieldData instance, Int32 id, Object value, IWorkItemFieldData_FieldFlags flags);
        partial void SetUpdateFieldValue_PreCondition(ref IWorkItemFieldData instance, ref Int32 id, ref Object value, ref IWorkItemFieldData_FieldFlags flags);
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public class WorkItemFieldData_FieldFlagsWrapper_UnitTests : DynTestClassBase
    {
        internal static IWorkItemFieldData_FieldFlags GetInstance() { return default(IWorkItemFieldData_FieldFlags); }
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemFieldData_FieldInfoWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemFieldData_FieldInfoWrapper> GetIEnumerableInstance() { return new List<WorkItemFieldData_FieldInfoWrapper> {GetInstance()}; }

        internal static WorkItemFieldData_FieldInfoWrapper GetInstance()
        {
            WorkItemFieldData.FieldInfo real = default(WorkItemFieldData.FieldInfo);
            RealInstanceFactory(ref real);
            WorkItemFieldData_FieldInfoWrapper instance = WorkItemFieldData_FieldInfoWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemFieldData_FieldInfoWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemFieldData.FieldInfo real, [CallerMemberName] string callerName = "");
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemFieldData_FieldUpdateWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemFieldData_FieldUpdateWrapper> GetIEnumerableInstance() { return new List<WorkItemFieldData_FieldUpdateWrapper> {GetInstance()}; }

        internal static WorkItemFieldData_FieldUpdateWrapper GetInstance()
        {
            WorkItemFieldData.FieldUpdate real = default(WorkItemFieldData.FieldUpdate);
            RealInstanceFactory(ref real);
            WorkItemFieldData_FieldUpdateWrapper instance = WorkItemFieldData_FieldUpdateWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemFieldData_FieldUpdateWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItemFieldData.FieldUpdate real, [CallerMemberName] string callerName = "");
    }
}