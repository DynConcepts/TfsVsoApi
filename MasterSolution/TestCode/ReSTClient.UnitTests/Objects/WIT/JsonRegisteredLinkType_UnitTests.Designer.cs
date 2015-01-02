using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonRegisteredLinkType_UnitTests : DynTestClassBase
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

        partial void Equals_PostValidate(JsonRegisteredLinkType instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonRegisteredLinkType instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonRegisteredLinkType instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonRegisteredLinkType instance);
        internal static IEnumerable<JsonRegisteredLinkType> GetIEnumerableInstance() { return new List<JsonRegisteredLinkType> {GetInstance()}; }

        internal static JsonRegisteredLinkType GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonRegisteredLinkType();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonRegisteredLinkType instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonRegisteredLinkType instance);
        static partial void InstanceFactory(ref JsonRegisteredLinkType instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonRegisteredLinkType instance, String _retVal);
        partial void ToString_PreCondition(ref JsonRegisteredLinkType instance);
    }
}