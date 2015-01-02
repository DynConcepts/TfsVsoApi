using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonTeamRoom_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CaptureJson_UnitTest()
        {
            JToken token = default(JToken);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    CaptureJson_PreCondition(ref instance, ref token);
                },
                instance => { instance.CaptureJson(token); },
                instance => { CaptureJson_PostValidate(instance, token); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Description_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonTeamRoom instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Description; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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
        public void FromToken_UnitTest()
        {
            JToken arg = default(JToken);
            JsonTeamRoom _retVal = default(JsonTeamRoom);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    arg = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref arg);
                },
                instance => { _retVal = JsonTeamRoom.FromToken(arg); },
                instance => { FromToken_PostValidate(instance, arg, _retVal); });
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
        public void Id_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonTeamRoom instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Id; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void JsonValue_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonTeamRoom instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.JsonValue; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LastActivity_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonTeamRoom instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LastActivity; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Name_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonTeamRoom instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Name; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToJSonString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToJSonString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToJSonString(); },
                instance => { ToJSonString_PostValidate(instance, _retVal); });
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

        partial void CaptureJson_PostValidate(JsonTeamRoom instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonTeamRoom instance, ref JToken token);
        partial void Description_SetCondition(ref JsonTeamRoom instance, ref String setValue);

        partial void Equals_PostValidate(JsonTeamRoom instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonTeamRoom instance, ref Object obj);
        partial void FromToken_PostValidate(JsonTeamRoom instance, JToken arg, JsonTeamRoom _retVal);
        partial void FromToken_PreCondition(ref JsonTeamRoom instance, ref JToken arg);

        partial void GetHashCode_PostValidate(JsonTeamRoom instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonTeamRoom instance);
        internal static IEnumerable<JsonTeamRoom> GetIEnumerableInstance() { return new List<JsonTeamRoom> {GetInstance()}; }

        internal static JsonTeamRoom GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonTeamRoom instance = JsonTeamRoom.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonTeamRoom instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonTeamRoom instance);

        partial void Id_SetCondition(ref JsonTeamRoom instance, ref Int32 setValue);
        static partial void InstanceFactory(ref JsonTeamRoom instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonTeamRoom instance, ref JToken setValue);

        partial void LastActivity_SetCondition(ref JsonTeamRoom instance, ref DateTime setValue);

        partial void Name_SetCondition(ref JsonTeamRoom instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonTeamRoom instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonTeamRoom instance);
        partial void ToString_PostValidate(JsonTeamRoom instance, String _retVal);
        partial void ToString_PreCondition(ref JsonTeamRoom instance);
    }
}