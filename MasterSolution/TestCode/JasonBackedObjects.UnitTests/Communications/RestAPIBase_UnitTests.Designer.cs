using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RestAPIBase_UnitTests : DynTestClassBase
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(RestAPIBase instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref RestAPIBase instance, ref Object obj);

        partial void GetHashCode_PostValidate(RestAPIBase instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref RestAPIBase instance);

        internal static IEnumerable<RestAPIBase> GetIEnumerableInstance()
        {
            return new List<RestAPIBase> {GetInstance()};
        }

        internal static RestAPIBase GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new RestAPIBase();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(RestAPIBase instance, Type _retVal);
        partial void GetType_PreCondition(ref RestAPIBase instance);
        static partial void InstanceFactory(ref RestAPIBase instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(RestAPIBase instance, String _retVal);
        partial void ToString_PreCondition(ref RestAPIBase instance);
    }
}