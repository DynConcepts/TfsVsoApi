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
    public partial class JsonHyperlink_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Attributes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonHyperlink instance = GetInstance();
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
            JsonHyperlink _retVal = default(JsonHyperlink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref token);
                },
                instance => { _retVal = JsonHyperlink.FromToken(token); },
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
                    JsonHyperlink instance = GetInstance();
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
        public void Rel_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonHyperlink instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Rel; },
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
        public void Url_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonHyperlink instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Url; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Attributes_SetCondition(ref JsonHyperlink instance, ref JsonLinkAttributes setValue);
        partial void CaptureJson_PostValidate(JsonHyperlink instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonHyperlink instance, ref JToken token);

        partial void Equals_PostValidate(JsonHyperlink instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonHyperlink instance, ref Object obj);
        partial void FromToken_PostValidate(JsonHyperlink instance, JToken token, JsonHyperlink _retVal);
        partial void FromToken_PreCondition(ref JsonHyperlink instance, ref JToken token);

        partial void GetHashCode_PostValidate(JsonHyperlink instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonHyperlink instance);
        internal static IEnumerable<JsonHyperlink> GetIEnumerableInstance() { return new List<JsonHyperlink> {GetInstance()}; }

        internal static JsonHyperlink GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonHyperlink instance = JsonHyperlink.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonHyperlink instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonHyperlink instance);
        static partial void InstanceFactory(ref JsonHyperlink instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonHyperlink instance, ref JToken setValue);

        partial void Rel_SetCondition(ref JsonHyperlink instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonHyperlink instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonHyperlink instance);
        partial void ToString_PostValidate(JsonHyperlink instance, String _retVal);
        partial void ToString_PreCondition(ref JsonHyperlink instance);

        partial void Url_SetCondition(ref JsonHyperlink instance, ref String setValue);
    }
}