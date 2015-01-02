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
    public partial class HooksRestCalls_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Actions_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.Actions; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Consumers_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.Consumers; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

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
        public void EventTypes_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.EventTypes; },
                // Validate Get Operation
                (setValue, getValue) => { });
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
        public void InputValuesQuery_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.InputValuesQuery; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NotificationsQuery_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.NotificationsQuery; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Notifications_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.Notifications; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PublishersQuery_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.PublishersQuery; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Publishers_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.Publishers; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SubscriptionsQuery_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.SubscriptionsQuery; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Subscriptions_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.Subscriptions; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TestNotifications_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return HooksRestCalls.TestNotifications; },
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

        partial void Actions_SetCondition(ref CallSpec setValue);

        partial void Consumers_SetCondition(ref CallSpec setValue);
        partial void Equals_PostValidate(HooksRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref HooksRestCalls instance, ref Object obj);

        partial void EventTypes_SetCondition(ref CallSpec setValue);
        partial void GetHashCode_PostValidate(HooksRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref HooksRestCalls instance);
        internal static IEnumerable<HooksRestCalls> GetIEnumerableInstance() { return new List<HooksRestCalls> {GetInstance()}; }

        internal static HooksRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new HooksRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(HooksRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(ref HooksRestCalls instance);

        partial void InputValuesQuery_SetCondition(ref CallSpec setValue);
        static partial void InstanceFactory(ref HooksRestCalls instance, [CallerMemberName] string callerName = "");

        partial void NotificationsQuery_SetCondition(ref CallSpec setValue);
        partial void Notifications_SetCondition(ref CallSpec setValue);

        partial void PublishersQuery_SetCondition(ref CallSpec setValue);
        partial void Publishers_SetCondition(ref CallSpec setValue);

        partial void SubscriptionsQuery_SetCondition(ref CallSpec setValue);
        partial void Subscriptions_SetCondition(ref CallSpec setValue);

        partial void TestNotifications_SetCondition(ref CallSpec setValue);
        partial void ToString_PostValidate(HooksRestCalls instance, String _retVal);
        partial void ToString_PreCondition(ref HooksRestCalls instance);
    }
}