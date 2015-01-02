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
    public partial class JsonProjectInfo_UnitTests : DynTestClassBase
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
            JsonProjectInfo _retVal = default(JsonProjectInfo);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref token);
                },
                instance => { _retVal = JsonProjectInfo.FromToken(token); },
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
                    JsonProjectInfo instance = GetInstance();
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
        public void Project_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonProjectInfo instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Project; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SupportsTfvc_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonProjectInfo instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SupportsTfvc; },
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

        partial void CaptureJson_PostValidate(JsonProjectInfo instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonProjectInfo instance, ref JToken token);

        partial void Equals_PostValidate(JsonProjectInfo instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonProjectInfo instance, ref Object obj);
        partial void FromToken_PostValidate(JsonProjectInfo instance, JToken token, JsonProjectInfo _retVal);
        partial void FromToken_PreCondition(ref JsonProjectInfo instance, ref JToken token);

        partial void GetHashCode_PostValidate(JsonProjectInfo instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonProjectInfo instance);
        internal static IEnumerable<JsonProjectInfo> GetIEnumerableInstance() { return new List<JsonProjectInfo> {GetInstance()}; }

        internal static JsonProjectInfo GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonProjectInfo instance = JsonProjectInfo.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonProjectInfo instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonProjectInfo instance);
        static partial void InstanceFactory(ref JsonProjectInfo instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonProjectInfo instance, ref JToken setValue);

        partial void Project_SetCondition(ref JsonProjectInfo instance, ref JsonProject setValue);

        partial void SupportsTfvc_SetCondition(ref JsonProjectInfo instance, ref Boolean setValue);
        partial void ToJSonString_PostValidate(JsonProjectInfo instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonProjectInfo instance);
        partial void ToString_PostValidate(JsonProjectInfo instance, String _retVal);
        partial void ToString_PreCondition(ref JsonProjectInfo instance);
    }
}