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
    public partial class PackagingRestCalls_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ArtifactBatch_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.ArtifactBatch; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Artifacts_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.Artifacts; },
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
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LineupBatch_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.LineupBatch; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Lineups_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.Lineups; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ModuleBatch_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.ModuleBatch; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Modules_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.Modules; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Stores_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return PackagingRestCalls.Stores; },
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
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void ArtifactBatch_SetCondition(ref CallSpec setValue);

        partial void Artifacts_SetCondition(ref CallSpec setValue);
        partial void Equals_PostValidate(PackagingRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref PackagingRestCalls instance, ref Object obj);
        partial void GetHashCode_PostValidate(PackagingRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref PackagingRestCalls instance);
        internal static IEnumerable<PackagingRestCalls> GetIEnumerableInstance() { return new List<PackagingRestCalls> {GetInstance()}; }

        internal static PackagingRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new PackagingRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(PackagingRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(ref PackagingRestCalls instance);
        static partial void InstanceFactory(ref PackagingRestCalls instance, [CallerMemberName] string callerName = "");

        partial void LineupBatch_SetCondition(ref CallSpec setValue);

        partial void Lineups_SetCondition(ref CallSpec setValue);

        partial void ModuleBatch_SetCondition(ref CallSpec setValue);

        partial void Modules_SetCondition(ref CallSpec setValue);

        partial void Stores_SetCondition(ref CallSpec setValue);
        partial void ToString_PostValidate(PackagingRestCalls instance, String _retVal);
        partial void ToString_PreCondition(ref PackagingRestCalls instance);
    }
}