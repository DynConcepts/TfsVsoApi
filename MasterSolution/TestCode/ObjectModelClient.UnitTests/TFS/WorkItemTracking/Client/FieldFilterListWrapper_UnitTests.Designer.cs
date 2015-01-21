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
    public partial class FieldFilterListWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Add_UnitTest()
        {
            IFieldFilter filter = default(IFieldFilter);
            ExecuteMethod(
                () => { return (IFieldFilterList) GetInstance(); },
                instance =>
                {
                    filter = FieldFilterWrapper_UnitTests.GetInstance();
                    Add_PreCondition(instance, ref filter);
                },
                instance => { instance.Add(filter); },
                instance => { Add_PostValidate(instance, filter); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IndexOfFieldId_UnitTest()
        {
            Int32 id = default(Int32);
            ExecuteMethod(
                () => { return (IFieldFilterList) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    IndexOfFieldId_PreCondition(instance, ref id);
                },
                instance => { instance.IndexOfFieldId(id); },
                instance => { IndexOfFieldId_PostValidate(instance, id); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Remove_UnitTest()
        {
            IFieldFilter value = default(IFieldFilter);
            ExecuteMethod(
                () => { return (IFieldFilterList) GetInstance(); },
                instance =>
                {
                    value = FieldFilterWrapper_UnitTests.GetInstance();
                    Remove_PreCondition(instance, ref value);
                },
                instance => { instance.Remove(value); },
                instance => { Remove_PostValidate(instance, value); });
        }

        partial void Add_PostValidate(IFieldFilterList instance, IFieldFilter filter);
        partial void Add_PreCondition(IFieldFilterList instance, ref IFieldFilter filter);
        internal static IEnumerable<FieldFilterListWrapper> GetIEnumerableInstance() { return new List<FieldFilterListWrapper> {GetInstance()}; }

        internal static FieldFilterListWrapper GetInstance()
        {
            var real = new FieldFilterList();
            RealInstanceFactory(ref real);
            var instance = (FieldFilterListWrapper) FieldFilterListWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void IndexOfFieldId_PostValidate(IFieldFilterList instance, Int32 id);
        partial void IndexOfFieldId_PreCondition(IFieldFilterList instance, ref Int32 id);
        static partial void InstanceFactory(ref FieldFilterListWrapper instance, [CallerMemberName] string callerName = "");
        static partial void RealInstanceFactory(ref FieldFilterList real, [CallerMemberName] string callerName = "");

        partial void Remove_PostValidate(IFieldFilterList instance, IFieldFilter value);
        partial void Remove_PreCondition(IFieldFilterList instance, ref IFieldFilter value);
    }
}