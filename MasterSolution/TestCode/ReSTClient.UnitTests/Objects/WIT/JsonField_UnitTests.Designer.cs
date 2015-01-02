using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonField_UnitTests : DynTestClassBase
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
        public void FieldDefinition_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonField instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldDefinition; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FromToken_UnitTest()
        {
            JToken token = default(JToken);
            JsonField _retVal = default(JsonField);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref token);
                },
                instance => { _retVal = JsonField.FromToken(token); },
                instance => { FromToken_PostValidate(instance, token, _retVal); });
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
        public void JsonValue_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonField instance = GetInstance();
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
        public void ReferenceName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonField instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ReferenceName; },
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Value_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonField instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    object setValue = default(Object);
                    Value_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Value = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Value; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CaptureJson_PostValidate(JsonField instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonField instance, ref JToken token);
        partial void Equals_PostValidate(JsonField instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonField instance, ref Object obj);

        partial void FieldDefinition_SetCondition(ref JsonField instance, ref JsonFieldDefinition setValue);
        partial void FromToken_PostValidate(JsonField instance, JToken token, JsonField _retVal);
        partial void FromToken_PreCondition(ref JsonField instance, ref JToken token);
        partial void GetHashCode_PostValidate(JsonField instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonField instance);
        internal static IEnumerable<JsonField> GetIEnumerableInstance() { return new List<JsonField> {GetInstance()}; }

        internal static JsonField GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonField instance = JsonField.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonField instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonField instance);
        static partial void InstanceFactory(ref JsonField instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);

        partial void JsonValue_SetCondition(ref JsonField instance, ref JToken setValue);
        partial void ReferenceName_SetCondition(ref JsonField instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonField instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonField instance);
        partial void ToString_PostValidate(JsonField instance, String _retVal);
        partial void ToString_PreCondition(ref JsonField instance);
        partial void Value_SetCondition(ref JsonField instance, ref Object setValue);
    }
}