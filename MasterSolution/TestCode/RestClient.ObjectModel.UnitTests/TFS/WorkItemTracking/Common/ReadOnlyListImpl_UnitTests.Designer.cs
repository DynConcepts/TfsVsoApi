using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ReadOnlyListImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CopyTo_UnitTest()
        {
            Array array = default(Array);
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return (IReadOnlyList) GetInstance(); },
                instance =>
                {
                    array = default(Array); //No Constructor
                    index = default(Int32); //No Constructor
                    CopyTo_PreCondition(instance, ref array, ref index);
                },
                instance => { instance.CopyTo(array, index); },
                instance => { CopyTo_PostValidate(instance, array, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Count_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReadOnlyList) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Count; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetEnumerator_UnitTest()
        {
            ExecuteMethod(
                () => { return (IReadOnlyList) GetInstance(); },
                instance => { GetEnumerator_PreCondition(instance); },
                instance => { instance.GetEnumerator(); },
                instance => { GetEnumerator_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsFixedSize_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReadOnlyList) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsFixedSize; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsReadOnly_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReadOnlyList) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsReadOnly; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsSynchronized_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReadOnlyList) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsSynchronized; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncRoot_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IReadOnlyList) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SyncRoot; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CopyTo_PostValidate(IReadOnlyList instance, Array array, Int32 index);
        partial void CopyTo_PreCondition(IReadOnlyList instance, ref Array array, ref Int32 index);
        partial void Count_SetCondition(ref IReadOnlyList instance, ref Int32 setValue);
        partial void GetEnumerator_PostValidate(IReadOnlyList instance);
        partial void GetEnumerator_PreCondition(IReadOnlyList instance);
        internal static IEnumerable<ReadOnlyListImpl> GetIEnumerableInstance() { return new List<ReadOnlyListImpl> {GetInstance()}; }

        internal static ReadOnlyListImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ReadOnlyListImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ReadOnlyListImpl instance, [CallerMemberName] string callerName = "");

        partial void IsFixedSize_SetCondition(ref IReadOnlyList instance, ref Boolean setValue);

        partial void IsReadOnly_SetCondition(ref IReadOnlyList instance, ref Boolean setValue);
        partial void IsSynchronized_SetCondition(ref IReadOnlyList instance, ref Boolean setValue);
        partial void SyncRoot_SetCondition(ref IReadOnlyList instance, ref Object setValue);
    }
}