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
    public partial class ChatRestCalls_UnitTests : DynTestClassBase
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
        public void Messages_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return ChatRestCalls.Messages; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Rooms_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return ChatRestCalls.Rooms; },
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Users_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return ChatRestCalls.Users; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        partial void Equals_PostValidate(ChatRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref ChatRestCalls instance, ref Object obj);

        partial void GetHashCode_PostValidate(ChatRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref ChatRestCalls instance);
        internal static IEnumerable<ChatRestCalls> GetIEnumerableInstance() { return new List<ChatRestCalls> {GetInstance()}; }

        internal static ChatRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ChatRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(ChatRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(ref ChatRestCalls instance);
        static partial void InstanceFactory(ref ChatRestCalls instance, [CallerMemberName] string callerName = "");

        partial void Messages_SetCondition(ref CallSpec setValue);

        partial void Rooms_SetCondition(ref CallSpec setValue);
        partial void ToString_PostValidate(ChatRestCalls instance, String _retVal);
        partial void ToString_PreCondition(ref ChatRestCalls instance);

        partial void Users_SetCondition(ref CallSpec setValue);
    }
}