using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonWorkItemRevision_UnitTests : DynTestClassBase
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
        public void Fields_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemRevision instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Fields; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FromToken_UnitTest()
        {
            JToken arg = default(JToken);
            JsonWorkItemRevision _retVal = default(JsonWorkItemRevision);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    arg = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref arg);
                },
                instance => { _retVal = JsonWorkItemRevision.FromToken(arg); },
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
                    JsonWorkItemRevision instance = GetInstance();
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
                    JsonWorkItemRevision instance = GetInstance();
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
        public void Rev_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemRevision instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Rev; },
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

        partial void CaptureJson_PostValidate(JsonWorkItemRevision instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonWorkItemRevision instance, ref JToken token);

        partial void Equals_PostValidate(JsonWorkItemRevision instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonWorkItemRevision instance, ref Object obj);
        partial void Fields_SetCondition(ref JsonWorkItemRevision instance, ref JsonFieldCollection setValue);
        partial void FromToken_PostValidate(JsonWorkItemRevision instance, JToken arg, JsonWorkItemRevision _retVal);
        partial void FromToken_PreCondition(ref JsonWorkItemRevision instance, ref JToken arg);

        partial void GetHashCode_PostValidate(JsonWorkItemRevision instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonWorkItemRevision instance);
        internal static IEnumerable<JsonWorkItemRevision> GetIEnumerableInstance() { return new List<JsonWorkItemRevision> {GetInstance()}; }

        internal static JsonWorkItemRevision GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonWorkItemRevision instance = JsonWorkItemRevision.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemRevision instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonWorkItemRevision instance);

        partial void Id_SetCondition(ref JsonWorkItemRevision instance, ref Int32 setValue);
        static partial void InstanceFactory(ref JsonWorkItemRevision instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);

        partial void JsonValue_SetCondition(ref JsonWorkItemRevision instance, ref JToken setValue);
        partial void Rev_SetCondition(ref JsonWorkItemRevision instance, ref Int32 setValue);
        partial void ToJSonString_PostValidate(JsonWorkItemRevision instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonWorkItemRevision instance);
        partial void ToString_PostValidate(JsonWorkItemRevision instance, String _retVal);
        partial void ToString_PreCondition(ref JsonWorkItemRevision instance);
    }
}