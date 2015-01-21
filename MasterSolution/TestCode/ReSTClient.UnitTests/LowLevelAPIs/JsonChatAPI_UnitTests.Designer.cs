using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
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
        public void GetMessages_UnitTest()
        {
            Task<IReadOnlyList<JsonRoomMessage>> _retVal = default(Task<IReadOnlyList<JsonRoomMessage>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetMessages_PreCondition(instance); },
                instance =>
                {
                    string roomId = instance.GetRooms().Result[0].Id;
                    return _retVal = instance.GetMessages(roomId);
                },
                instance => { GetMessages_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetRooms_UnitTest()
        {
            Task<IReadOnlyList<JsonRoom>> _retVal = default(Task<IReadOnlyList<JsonRoom>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetRooms_PreCondition(instance); },
                instance => { return _retVal = instance.GetRooms(); },
                instance => { GetRooms_PostValidate(instance, _retVal); });
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
        public void GetUsers_UnitTest()
        {
            Task<IReadOnlyList<JsonRoomMember>> _retVal = default(Task<IReadOnlyList<JsonRoomMember>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetUsers_PreCondition(instance); },
                instance =>
                {
                    string roomId = instance.GetRooms().Result[0].Id;
                    return _retVal = instance.GetUsers(roomId);
                },
                instance => { GetUsers_PostValidate(instance, _retVal); });
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

        partial void Equals_PostValidate(JsonChatAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonChatAPI instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonChatAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonChatAPI instance);
        internal static IEnumerable<JsonChatAPI> GetIEnumerableInstance() { return new List<JsonChatAPI> {GetInstance()}; }

        internal static JsonChatAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonChatAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetMessages_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoomMessage>> _retVal);
        partial void GetMessages_PreCondition(JsonChatAPI instance);
        partial void GetRooms_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoom>> _retVal);
        partial void GetRooms_PreCondition(JsonChatAPI instance);

        partial void GetType_PostValidate(JsonChatAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonChatAPI instance);
        partial void GetUsers_PostValidate(JsonChatAPI instance, Task<IReadOnlyList<JsonRoomMember>> _retVal);
        partial void GetUsers_PreCondition(JsonChatAPI instance);
        static partial void InstanceFactory(ref JsonChatAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonChatAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonChatAPI instance);
    }
}