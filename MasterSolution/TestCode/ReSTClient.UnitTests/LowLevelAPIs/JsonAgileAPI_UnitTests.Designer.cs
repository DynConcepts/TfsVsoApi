using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonAgileAPI_UnitTests : DynTestClassBase
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
        public void GetBacklogs_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetBacklogs_PreCondition(instance); },
                instance => { return _retVal = instance.GetBacklogs(); },
                instance => { GetBacklogs_PostValidate(instance, _retVal); });
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

        partial void Equals_PostValidate(JsonAgileAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonAgileAPI instance, ref Object obj);
        partial void GetBacklogs_PostValidate(JsonAgileAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetBacklogs_PreCondition(JsonAgileAPI instance);

        partial void GetHashCode_PostValidate(JsonAgileAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonAgileAPI instance);
        internal static IEnumerable<JsonAgileAPI> GetIEnumerableInstance() { return new List<JsonAgileAPI> {GetInstance()}; }

        internal static JsonAgileAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonAgileAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonAgileAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonAgileAPI instance);
        static partial void InstanceFactory(ref JsonAgileAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonAgileAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonAgileAPI instance);
    }
}