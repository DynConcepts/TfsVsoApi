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
    public partial class JsonRelatedLink_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Attributes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelatedLink instance = GetInstance();
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
            JToken json = default(JToken);
            JsonRelatedLink _retVal = default(JsonRelatedLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    json = default(JToken); //No Constructor
                    FromToken_PreCondition(instance, ref json);
                },
                instance => { return _retVal = JsonRelatedLink.FromToken(json); },
                instance => { FromToken_PostValidate(instance, json, _retVal); });
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
        public void JsonValue_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelatedLink instance = GetInstance();
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
        public void LinkTypeEnd_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelatedLink instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LinkTypeEnd; },
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
                    JsonRelatedLink instance = GetInstance();
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
        public void RelatedWorkItemId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonRelatedLink instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RelatedWorkItemId; },
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
                    JsonRelatedLink instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Url; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Attributes_SetCondition(ref JsonRelatedLink instance, ref JsonLinkAttributes setValue);
        partial void CaptureJson_PostValidate(JsonRelatedLink instance, JToken token);
        partial void CaptureJson_PreCondition(JsonRelatedLink instance, ref JToken token);

        partial void Equals_PostValidate(JsonRelatedLink instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonRelatedLink instance, ref Object obj);
        partial void FromToken_PostValidate(JsonRelatedLink instance, JToken json, JsonRelatedLink _retVal);
        partial void FromToken_PreCondition(JsonRelatedLink instance, ref JToken json);

        partial void GetHashCode_PostValidate(JsonRelatedLink instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonRelatedLink instance);
        internal static IEnumerable<JsonRelatedLink> GetIEnumerableInstance() { return new List<JsonRelatedLink> {GetInstance()}; }

        internal static JsonRelatedLink GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonRelatedLink instance = JsonRelatedLink.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonRelatedLink instance, Type _retVal);
        partial void GetType_PreCondition(JsonRelatedLink instance);
        static partial void InstanceFactory(ref JsonRelatedLink instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonRelatedLink instance, ref JToken setValue);

        partial void LinkTypeEnd_SetCondition(ref JsonRelatedLink instance, ref JsonLinkTypeEnd setValue);

        partial void Rel_SetCondition(ref JsonRelatedLink instance, ref String setValue);
        partial void RelatedWorkItemId_SetCondition(ref JsonRelatedLink instance, ref Int32 setValue);
        partial void ToJSonString_PostValidate(JsonRelatedLink instance, String _retVal);
        partial void ToJSonString_PreCondition(JsonRelatedLink instance);
        partial void ToString_PostValidate(JsonRelatedLink instance, String _retVal);
        partial void ToString_PreCondition(JsonRelatedLink instance);

        partial void Url_SetCondition(ref JsonRelatedLink instance, ref String setValue);
    }
}