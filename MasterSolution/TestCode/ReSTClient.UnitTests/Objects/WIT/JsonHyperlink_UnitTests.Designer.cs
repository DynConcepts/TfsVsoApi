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

        partial void Attributes_SetCondition(ref JsonHyperlink instance, ref String setValue);
        partial void CaptureJson_PostValidate(JsonHyperlink instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonHyperlink instance, ref JToken token);

        partial void Equals_PostValidate(JsonHyperlink instance, Object obj);
        partial void Equals_PreCondition(ref JsonHyperlink instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonHyperlink instance);
        partial void GetHashCode_PreCondition(ref JsonHyperlink instance);
        internal static IEnumerable<JsonHyperlink> GetIEnumerableInstance() { return new List<JsonHyperlink> {GetInstance()}; }

        internal static JsonHyperlink GetInstance([CallerMemberName] string callerName = "")
        {
            JsonHyperlink instance = default(JsonHyperlink);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonHyperlink instance);
        partial void GetType_PreCondition(ref JsonHyperlink instance);
        static partial void InstanceFactory(ref JsonHyperlink instance, [CallerMemberName] string callerName = "");
        partial void JsonValue_SetCondition(ref JsonHyperlink instance, ref JToken setValue);

        partial void Rel_SetCondition(ref JsonHyperlink instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonHyperlink instance);
        partial void ToJSonString_PreCondition(ref JsonHyperlink instance);
        partial void ToString_PostValidate(JsonHyperlink instance);
        partial void ToString_PreCondition(ref JsonHyperlink instance);

        partial void Url_SetCondition(ref JsonHyperlink instance, ref String setValue);
    }
}