using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.TeamFoundation.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IWorkItemOpenFieldDataHelperWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldId_UnitTest()
        {
            String fieldName = default(String);
            ExecuteMethod(
                () => { return (IIWorkItemOpenFieldDataHelper) GetInstance(); },
                instance =>
                {
                    fieldName = default(String); //No Constructor
                    GetFieldId_PreCondition(ref instance, ref fieldName);
                },
                instance => { instance.GetFieldId(fieldName); },
                instance => { GetFieldId_PostValidate(instance, fieldName); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasField_UnitTest()
        {
            Int32 fieldId = default(Int32);
            ExecuteMethod(
                () => { return (IIWorkItemOpenFieldDataHelper) GetInstance(); },
                instance =>
                {
                    fieldId = default(Int32); //No Constructor
                    HasField_PreCondition(ref instance, ref fieldId);
                },
                instance => { instance.HasField(fieldId); },
                instance => { HasField_PostValidate(instance, fieldId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetLatestData_UnitTest()
        {
            Dictionary<Int32, Object> latestData = default(Dictionary<Int32, Object>);
            ExecuteMethod(
                () => { return (IIWorkItemOpenFieldDataHelper) GetInstance(); },
                instance =>
                {
                    latestData = default(Dictionary<Int32, Object>); //No Type
                    SetLatestData_PreCondition(ref instance, ref latestData);
                },
                instance => { instance.SetLatestData(latestData); },
                instance => { SetLatestData_PostValidate(instance, latestData); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetRevisionData_UnitTest()
        {
            List<Dictionary<Int32, Object>> revisionData = default(List<Dictionary<Int32, Object>>);
            ExecuteMethod(
                () => { return (IIWorkItemOpenFieldDataHelper) GetInstance(); },
                instance =>
                {
                    revisionData = default(List<Dictionary<Int32, Object>>); //No Type
                    SetRevisionData_PreCondition(ref instance, ref revisionData);
                },
                instance => { instance.SetRevisionData(revisionData); },
                instance => { SetRevisionData_PostValidate(instance, revisionData); });
        }

        partial void GetFieldId_PostValidate(IIWorkItemOpenFieldDataHelper instance, String fieldName);
        partial void GetFieldId_PreCondition(ref IIWorkItemOpenFieldDataHelper instance, ref String fieldName);
        internal static IEnumerable<IWorkItemOpenFieldDataHelperWrapper> GetIEnumerableInstance() { return new List<IWorkItemOpenFieldDataHelperWrapper> {GetInstance()}; }

        internal static IWorkItemOpenFieldDataHelperWrapper GetInstance()
        {
            IWorkItemOpenFieldDataHelper real = default(IWorkItemOpenFieldDataHelper);
            RealInstanceFactory(ref real);
            var instance = (IWorkItemOpenFieldDataHelperWrapper) IWorkItemOpenFieldDataHelperWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void HasField_PostValidate(IIWorkItemOpenFieldDataHelper instance, Int32 fieldId);
        partial void HasField_PreCondition(ref IIWorkItemOpenFieldDataHelper instance, ref Int32 fieldId);
        static partial void InstanceFactory(ref IWorkItemOpenFieldDataHelperWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref IWorkItemOpenFieldDataHelper real, [CallerMemberName] string callerName = "");
        partial void SetLatestData_PostValidate(IIWorkItemOpenFieldDataHelper instance, Dictionary<Int32, Object> latestData);
        partial void SetLatestData_PreCondition(ref IIWorkItemOpenFieldDataHelper instance, ref Dictionary<Int32, Object> latestData);
        partial void SetRevisionData_PostValidate(IIWorkItemOpenFieldDataHelper instance, List<Dictionary<Int32, Object>> revisionData);
        partial void SetRevisionData_PreCondition(ref IIWorkItemOpenFieldDataHelper instance, ref List<Dictionary<Int32, Object>> revisionData);
    }
}