using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemFieldDataImpl_UnitTests : DynTestClassBase
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
                    fu = WorkItemFieldData_FieldUpdateImpl_UnitTests.GetInstance();
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
                    flags = WorkItemFieldData_FieldFlagsImpl_UnitTests.GetInstance();
                    SetUpdateFieldValue_PreCondition(ref instance, ref id, ref value, ref flags);
                },
                instance => { instance.SetUpdateFieldValue(id, value, flags); },
                instance => { SetUpdateFieldValue_PostValidate(instance, id, value, flags); });
        }

        partial void GetFieldState_PostValidate(IWorkItemFieldData instance, Int32 id);
        partial void GetFieldState_PreCondition(ref IWorkItemFieldData instance, ref Int32 id);
        internal static IEnumerable<WorkItemFieldDataImpl> GetIEnumerableInstance() { return new List<WorkItemFieldDataImpl> {GetInstance()}; }

        internal static WorkItemFieldDataImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WorkItemFieldDataImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetUpdateFieldValue_PostValidate(IWorkItemFieldData instance, Int32 id, IWorkItemFieldData_FieldUpdate fu);
        partial void GetUpdateFieldValue_PreCondition(ref IWorkItemFieldData instance, ref Int32 id, ref IWorkItemFieldData_FieldUpdate fu);
        static partial void InstanceFactory(ref WorkItemFieldDataImpl instance, [CallerMemberName] string callerName = "");
        partial void SetUpdateFieldValue_PostValidate(IWorkItemFieldData instance, Int32 id, Object value, IWorkItemFieldData_FieldFlags flags);
        partial void SetUpdateFieldValue_PreCondition(ref IWorkItemFieldData instance, ref Int32 id, ref Object value, ref IWorkItemFieldData_FieldFlags flags);
    }
}

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public class WorkItemFieldData_FieldFlagsImpl_UnitTests : DynTestClassBase
    {
        internal static IWorkItemFieldData_FieldFlags GetInstance() { return default(IWorkItemFieldData_FieldFlags); }
    }
}

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemFieldData_FieldInfoImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemFieldData_FieldInfoImpl> GetIEnumerableInstance() { return new List<WorkItemFieldData_FieldInfoImpl> {GetInstance()}; }

        internal static WorkItemFieldData_FieldInfoImpl GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItemFieldData_FieldInfoImpl instance = default(WorkItemFieldData_FieldInfoImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemFieldData_FieldInfoImpl instance, [CallerMemberName] string callerName = "");
    }
}

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemFieldData_FieldUpdateImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItemFieldData_FieldUpdateImpl> GetIEnumerableInstance() { return new List<WorkItemFieldData_FieldUpdateImpl> {GetInstance()}; }

        internal static WorkItemFieldData_FieldUpdateImpl GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItemFieldData_FieldUpdateImpl instance = default(WorkItemFieldData_FieldUpdateImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemFieldData_FieldUpdateImpl instance, [CallerMemberName] string callerName = "");
    }
}