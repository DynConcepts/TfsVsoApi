using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.APIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class VSOClientManager_UnitTests : DynTestClassBase
    {
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void VsoCollection_UnitTest()
        {
            ExecuteProperty(
                // Create Set Value
                () =>
                {
                    string setValue = default(String);
                    VsoCollection_SetCondition(ref setValue);
                    return setValue;
                },
                // Invoke Setter
                setValue => { VSOClientManager.VsoCollection = setValue; },
                // Validate Set Operation
                setValue => { },
                // Invoke Getter
                () => { return VSOClientManager.VsoCollection; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        partial void Equals_PostValidate(VSOClientManager instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(VSOClientManager instance, ref Object obj);

        partial void GetHashCode_PostValidate(VSOClientManager instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(VSOClientManager instance);
        internal static IEnumerable<VSOClientManager> GetIEnumerableInstance() { return new List<VSOClientManager> {GetInstance()}; }

        internal static VSOClientManager GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new VSOClientManager();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(VSOClientManager instance, Type _retVal);
        partial void GetType_PreCondition(VSOClientManager instance);
        static partial void InstanceFactory(ref VSOClientManager instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(VSOClientManager instance, String _retVal);
        partial void ToString_PreCondition(VSOClientManager instance);

        partial void VsoCollection_SetCondition(ref String setValue);
    }
}