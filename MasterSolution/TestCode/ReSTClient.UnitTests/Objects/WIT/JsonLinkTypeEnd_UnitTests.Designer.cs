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
                    token = default(JToken); //No Type
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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { instance.GetType(); },
                instance => { GetType_PostValidate(instance); });
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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToJSonString_PreCondition(ref instance); },
                instance => { instance.ToJSonString(); },
                instance => { ToJSonString_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { instance.ToString(); },
                instance => { ToString_PostValidate(instance); });
        }

        partial void CaptureJson_PostValidate(JsonLinkTypeEnd instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonLinkTypeEnd instance, ref JToken token);

        partial void Equals_PostValidate(JsonLinkTypeEnd instance, Object obj);
        partial void Equals_PreCondition(ref JsonLinkTypeEnd instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonLinkTypeEnd instance);
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

        partial void GetType_PostValidate(JsonLinkTypeEnd instance);
        partial void GetType_PreCondition(ref JsonLinkTypeEnd instance);

        partial void ImmutableName_SetCondition(ref JsonLinkTypeEnd instance, ref String setValue);
        static partial void InstanceFactory(ref JsonLinkTypeEnd instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JObject json);

        partial void JsonValue_SetCondition(ref JsonLinkTypeEnd instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonLinkTypeEnd instance);
        partial void ToJSonString_PreCondition(ref JsonLinkTypeEnd instance);
        partial void ToString_PostValidate(JsonLinkTypeEnd instance);
        partial void ToString_PreCondition(ref JsonLinkTypeEnd instance);
    }
}