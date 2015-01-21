using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.RestCalls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.RestCalls
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TfvcRestCalls_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Branches_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.Branches; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangesetChanges_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ChangesetChanges; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangesetWorkItems_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ChangesetWorkItems; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangesetsBatch_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ChangesetsBatch; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Changesets_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.Changesets; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            Object obj = default(Object);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(instance); },
                instance => { return _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(instance); },
                instance => { return _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ItemBatch_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ItemBatch; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Items_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.Items; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LabelItems_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.LabelItems; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Labels_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.Labels; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProjectInfo0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ProjectSpecificInfo; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProjectInfo1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.AllProjectInfo; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ShelvesetChanges0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ShelvesetChanges; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

    
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ShelvesetWorkItems0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.ShelvesetWorkItems; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

           /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Shelvesets0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return TfvcRestCalls.AllShelvesets; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Branches_SetCondition(ref CallSpec setValue);

        partial void ChangesetChanges_SetCondition(ref CallSpec setValue);

        partial void ChangesetWorkItems_SetCondition(ref CallSpec setValue);

        partial void ChangesetsBatch_SetCondition(ref CallSpec setValue);
        partial void Changesets_SetCondition(ref CallSpec setValue);
        partial void Equals_PostValidate(TfvcRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(TfvcRestCalls instance, ref Object obj);
        partial void GetHashCode_PostValidate(TfvcRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(TfvcRestCalls instance);
        internal static IEnumerable<TfvcRestCalls> GetIEnumerableInstance() { return new List<TfvcRestCalls> {GetInstance()}; }

        internal static TfvcRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new TfvcRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(TfvcRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(TfvcRestCalls instance);
        static partial void InstanceFactory(ref TfvcRestCalls instance, [CallerMemberName] string callerName = "");

        partial void ItemBatch_SetCondition(ref CallSpec setValue);

        partial void Items_SetCondition(ref CallSpec setValue);

        partial void LabelItems_SetCondition(ref CallSpec setValue);

        partial void Labels_SetCondition(ref CallSpec setValue);

        partial void ProjectInfo0_SetCondition(ref CallSpec setValue);

        partial void ProjectInfo1_SetCondition(ref CallSpec setValue);

        partial void ShelvesetChanges0_SetCondition(ref CallSpec setValue);

        partial void ShelvesetChanges1_SetCondition(ref CallSpec setValue);

        partial void ShelvesetWorkItems0_SetCondition(ref CallSpec setValue);

        partial void ShelvesetWorkItems1_SetCondition(ref CallSpec setValue);

        partial void Shelvesets0_SetCondition(ref CallSpec setValue);

        partial void Shelvesets1_SetCondition(ref CallSpec setValue);
        partial void ToString_PostValidate(TfvcRestCalls instance, String _retVal);
        partial void ToString_PreCondition(TfvcRestCalls instance);
    }
}