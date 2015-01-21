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
    public partial class JsonRelationType_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Attributes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelationType instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Attributes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

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
                    CaptureJson_PreCondition(instance, ref token);
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
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FromToken_UnitTest()
        {
            JToken arg = default(JToken);
            JsonRelationType _retVal = default(JsonRelationType);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    arg = default(JToken); //No Constructor
                    FromToken_PreCondition(instance, ref arg);
                },
                instance => { return _retVal = JsonRelationType.FromToken(arg); },
                instance => { FromToken_PostValidate(instance, arg, _retVal); });
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
        public void IsWorkItemLink_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelationType instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsWorkItemLink; },
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
                    JsonRelationType instance = GetInstance();
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
        public void Name_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelationType instance = GetInstance();
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
        public void ReferenceName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelationType instance = GetInstance();
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
                instance => { ToJSonString_PreCondition(instance); },
                instance => { return _retVal = instance.ToJSonString(); },
                instance => { ToJSonString_PostValidate(instance, _retVal); });
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Url_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelationType instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Url; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Attributes_SetCondition(ref JsonRelationType instance, ref IReadOnlyDictionary<String, Object> setValue);
        partial void CaptureJson_PostValidate(JsonRelationType instance, JToken token);
        partial void CaptureJson_PreCondition(JsonRelationType instance, ref JToken token);

        partial void Equals_PostValidate(JsonRelationType instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonRelationType instance, ref Object obj);
        partial void FromToken_PostValidate(JsonRelationType instance, JToken arg, JsonRelationType _retVal);
        partial void FromToken_PreCondition(JsonRelationType instance, ref JToken arg);

        partial void GetHashCode_PostValidate(JsonRelationType instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonRelationType instance);
        internal static IEnumerable<JsonRelationType> GetIEnumerableInstance() { return new List<JsonRelationType> {GetInstance()}; }

        internal static JsonRelationType GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonRelationType instance = JsonRelationType.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonRelationType instance, Type _retVal);
        partial void GetType_PreCondition(JsonRelationType instance);
        static partial void InstanceFactory(ref JsonRelationType instance, [CallerMemberName] string callerName = "");

        partial void IsWorkItemLink_SetCondition(ref JsonRelationType instance, ref Boolean setValue);
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonRelationType instance, ref JToken setValue);

        partial void Name_SetCondition(ref JsonRelationType instance, ref String setValue);

        partial void ReferenceName_SetCondition(ref JsonRelationType instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonRelationType instance, String _retVal);
        partial void ToJSonString_PreCondition(JsonRelationType instance);
        partial void ToString_PostValidate(JsonRelationType instance, String _retVal);
        partial void ToString_PreCondition(JsonRelationType instance);

        partial void Url_SetCondition(ref JsonRelationType instance, ref String setValue);
    }
}