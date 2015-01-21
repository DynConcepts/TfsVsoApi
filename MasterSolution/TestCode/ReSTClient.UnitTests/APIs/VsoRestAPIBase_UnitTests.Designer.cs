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
    public partial class VsoRestAPIBase_UnitTests : DynTestClassBase
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

        partial void Equals_PostValidate(VsoRestAPIBase instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(VsoRestAPIBase instance, ref Object obj);

        partial void GetHashCode_PostValidate(VsoRestAPIBase instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(VsoRestAPIBase instance);
        internal static IEnumerable<VsoRestAPIBase> GetIEnumerableInstance() { return new List<VsoRestAPIBase> {GetInstance()}; }

        internal static VsoRestAPIBase GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new VsoRestAPIBase();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(VsoRestAPIBase instance, Type _retVal);
        partial void GetType_PreCondition(VsoRestAPIBase instance);
        static partial void InstanceFactory(ref VsoRestAPIBase instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(VsoRestAPIBase instance, String _retVal);
        partial void ToString_PreCondition(VsoRestAPIBase instance);
    }
}