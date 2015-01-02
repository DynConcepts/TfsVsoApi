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
    public partial class JsonLinkTypeEnd_UnitTests : DynTestClassBase
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
            JObject token = default(JObject);
            JsonLinkTypeEnd _retVal = default(JsonLinkTypeEnd);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = new JObject();
                    FromToken_PreCondition(ref instance, ref token);
                },
                instance => { _retVal = JsonLinkTypeEnd.FromToken(token); },
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
        public void ImmutableName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkTypeEnd instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ImmutableName; },
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
                    JsonLinkTypeEnd instance = GetInstance();
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

        partial void CaptureJson_PostValidate(JsonLinkTypeEnd instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonLinkTypeEnd instance, ref JToken token);

        partial void Equals_PostValidate(JsonLinkTypeEnd instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonLinkTypeEnd instance, ref Object obj);
        partial void FromToken_PostValidate(JsonLinkTypeEnd instance, JObject token, JsonLinkTypeEnd _retVal);
        partial void FromToken_PreCondition(ref JsonLinkTypeEnd instance, ref JObject token);

        partial void GetHashCode_PostValidate(JsonLinkTypeEnd instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonLinkTypeEnd instance);
        internal static IEnumerable<JsonLinkTypeEnd> GetIEnumerableInstance() { return new List<JsonLinkTypeEnd> {GetInstance()}; }

        internal static JsonLinkTypeEnd GetInstance([CallerMemberName] string callerName = "")
        {
            var json = new JObject();
            JsonSource(ref json);
            JsonLinkTypeEnd instance = JsonLinkTypeEnd.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonLinkTypeEnd instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonLinkTypeEnd instance);

        partial void ImmutableName_SetCondition(ref JsonLinkTypeEnd instance, ref String setValue);
        static partial void InstanceFactory(ref JsonLinkTypeEnd instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JObject json);

        partial void JsonValue_SetCondition(ref JsonLinkTypeEnd instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonLinkTypeEnd instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonLinkTypeEnd instance);
        partial void ToString_PostValidate(JsonLinkTypeEnd instance, String _retVal);
        partial void ToString_PreCondition(ref JsonLinkTypeEnd instance);
    }
}