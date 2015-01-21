using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonGeneralPurposeObject_UnitTests : DynTestClassBase
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
        public void FromToken_UnitTest()
        {
            JToken token = default(JToken);
            JsonGeneralPurposeObject _retVal = default(JsonGeneralPurposeObject);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref token);
                },
                instance => { _retVal = JsonGeneralPurposeObject.FromToken(token); },
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
                    JsonGeneralPurposeObject instance = GetInstance();
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

        partial void CaptureJson_PostValidate(JsonGeneralPurposeObject instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonGeneralPurposeObject instance, ref JToken token);

        partial void Equals_PostValidate(JsonGeneralPurposeObject instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonGeneralPurposeObject instance, ref Object obj);
        partial void FromToken_PostValidate(JsonGeneralPurposeObject instance, JToken token, JsonGeneralPurposeObject _retVal);
        partial void FromToken_PreCondition(ref JsonGeneralPurposeObject instance, ref JToken token);

        partial void GetHashCode_PostValidate(JsonGeneralPurposeObject instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonGeneralPurposeObject instance);

        internal static IEnumerable<JsonGeneralPurposeObject> GetIEnumerableInstance()
        {
            return new List<JsonGeneralPurposeObject> {GetInstance()};
        }

        internal static JsonGeneralPurposeObject GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonGeneralPurposeObject instance = JsonGeneralPurposeObject.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonGeneralPurposeObject instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonGeneralPurposeObject instance);
        static partial void InstanceFactory(ref JsonGeneralPurposeObject instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);

        partial void JsonValue_SetCondition(ref JsonGeneralPurposeObject instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonGeneralPurposeObject instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonGeneralPurposeObject instance);
        partial void ToString_PostValidate(JsonGeneralPurposeObject instance, String _retVal);
        partial void ToString_PreCondition(ref JsonGeneralPurposeObject instance);
    }
}