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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { instance.GetType(); },
                instance => { GetType_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { instance.ToString(); },
                instance => { ToString_PostValidate(instance); });
        }

        partial void Equals_PostValidate(JsonRegisteredLinkType instance, Object obj);
        partial void Equals_PreCondition(ref JsonRegisteredLinkType instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonRegisteredLinkType instance);
        partial void GetHashCode_PreCondition(ref JsonRegisteredLinkType instance);
        internal static IEnumerable<JsonRegisteredLinkType> GetIEnumerableInstance() { return new List<JsonRegisteredLinkType> {GetInstance()}; }

        internal static JsonRegisteredLinkType GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonRegisteredLinkType();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonRegisteredLinkType instance);
        partial void GetType_PreCondition(ref JsonRegisteredLinkType instance);
        static partial void InstanceFactory(ref JsonRegisteredLinkType instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonRegisteredLinkType instance);
        partial void ToString_PreCondition(ref JsonRegisteredLinkType instance);
    }
}