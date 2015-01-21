using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IWorkItemSaveFieldDataHelperImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldUpdates_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIWorkItemSaveFieldDataHelper) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldUpdates; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldName_UnitTest()
        {
            Int32 fieldId = default(Int32);
            ExecuteMethod(
                () => { return (IIWorkItemSaveFieldDataHelper) GetInstance(); },
                instance =>
                {
                    fieldId = default(Int32); //No Constructor
                    GetFieldName_PreCondition(instance, ref fieldId);
                },
                instance => { instance.GetFieldName(fieldId); },
                instance => { GetFieldName_PostValidate(instance, fieldId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldReferenceName_UnitTest()
        {
            Int32 fieldId = default(Int32);
            ExecuteMethod(
                () => { return (IIWorkItemSaveFieldDataHelper) GetInstance(); },
                instance =>
                {
                    fieldId = default(Int32); //No Constructor
                    GetFieldReferenceName_PreCondition(instance, ref fieldId);
                },
                instance => { instance.GetFieldReferenceName(fieldId); },
                instance => { GetFieldReferenceName_PostValidate(instance, fieldId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldSystemType_UnitTest()
        {
            Int32 fieldId = default(Int32);
            ExecuteMethod(
                () => { return (IIWorkItemSaveFieldDataHelper) GetInstance(); },
                instance =>
                {
                    fieldId = default(Int32); //No Constructor
                    GetFieldSystemType_PreCondition(instance, ref fieldId);
                },
                instance => { instance.GetFieldSystemType(fieldId); },
                instance => { GetFieldSystemType_PostValidate(instance, fieldId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsLongTextField_UnitTest()
        {
            Int32 fieldId = default(Int32);
            ExecuteMethod(
                () => { return (IIWorkItemSaveFieldDataHelper) GetInstance(); },
                instance =>
                {
                    fieldId = default(Int32); //No Constructor
                    IsLongTextField_PreCondition(instance, ref fieldId);
                },
                instance => { instance.IsLongTextField(fieldId); },
                instance => { IsLongTextField_PostValidate(instance, fieldId); });
        }

        partial void FieldUpdates_SetCondition(ref IIWorkItemSaveFieldDataHelper instance, ref Dictionary<Int32, Object> setValue);
        partial void GetFieldName_PostValidate(IIWorkItemSaveFieldDataHelper instance, Int32 fieldId);
        partial void GetFieldName_PreCondition(IIWorkItemSaveFieldDataHelper instance, ref Int32 fieldId);
        partial void GetFieldReferenceName_PostValidate(IIWorkItemSaveFieldDataHelper instance, Int32 fieldId);
        partial void GetFieldReferenceName_PreCondition(IIWorkItemSaveFieldDataHelper instance, ref Int32 fieldId);
        partial void GetFieldSystemType_PostValidate(IIWorkItemSaveFieldDataHelper instance, Int32 fieldId);
        partial void GetFieldSystemType_PreCondition(IIWorkItemSaveFieldDataHelper instance, ref Int32 fieldId);
        internal static IEnumerable<IWorkItemSaveFieldDataHelperImpl> GetIEnumerableInstance() { return new List<IWorkItemSaveFieldDataHelperImpl> {GetInstance()}; }

        internal static IWorkItemSaveFieldDataHelperImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IWorkItemSaveFieldDataHelperImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IWorkItemSaveFieldDataHelperImpl instance, [CallerMemberName] string callerName = "");
        partial void IsLongTextField_PostValidate(IIWorkItemSaveFieldDataHelper instance, Int32 fieldId);
        partial void IsLongTextField_PreCondition(IIWorkItemSaveFieldDataHelper instance, ref Int32 fieldId);
    }
}