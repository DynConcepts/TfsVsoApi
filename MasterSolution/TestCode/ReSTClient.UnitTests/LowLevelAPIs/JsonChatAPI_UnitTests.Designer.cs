using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonChatAPI_UnitTests : DynTestClassBase
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
        public void GetMessages_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetMessages_PreCondition(ref instance); },
                instance => { _retVal = instance.GetMessages(); },
                instance => { GetMessages_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRooms_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetRooms_PreCondition(ref instance); },
                instance => { _retVal = instance.GetRooms(); },
                instance => { GetRooms_PostValidate(instance, _retVal); });
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
        public void GetUsers_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetUsers_PreCondition(ref instance); },
                instance => { _retVal = instance.GetUsers(); },
                instance => { GetUsers_PostValidate(instance, _retVal); });
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

        partial void Equals_PostValidate(JsonChatAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonChatAPI instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonChatAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonChatAPI instance);
        internal static IEnumerable<JsonChatAPI> GetIEnumerableInstance() { return new List<JsonChatAPI> {GetInstance()}; }

        internal static JsonChatAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonChatAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetMessages_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetMessages_PreCondition(ref JsonChatAPI instance);
        partial void GetRooms_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetRooms_PreCondition(ref JsonChatAPI instance);

        partial void GetType_PostValidate(JsonChatAPI instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonChatAPI instance);
        partial void GetUsers_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetUsers_PreCondition(ref JsonChatAPI instance);
        static partial void InstanceFactory(ref JsonChatAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonChatAPI instance, String _retVal);
        partial void ToString_PreCondition(ref JsonChatAPI instance);
    }
}