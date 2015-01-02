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
    public partial class JsonWorkItemType_UnitTests : DynTestClassBase
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
        public void Description_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemType instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Description; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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
        public void FieldDefinitions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemType instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldDefinitions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Fields_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemType instance = GetInstance();
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
            JToken content = default(JToken);
            JsonWorkItemType _retVal = default(JsonWorkItemType);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    content = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref content);
                },
                instance => { _retVal = JsonWorkItemType.FromToken(content); },
                instance => { FromToken_PostValidate(instance, content, _retVal); });
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
                    JsonWorkItemType instance = GetInstance();
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
                    JsonWorkItemType instance = GetInstance();
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

        partial void CaptureJson_PostValidate(JsonWorkItemType instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonWorkItemType instance, ref JToken token);
        partial void Description_SetCondition(ref JsonWorkItemType instance, ref String setValue);
        partial void Equals_PostValidate(JsonWorkItemType instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonWorkItemType instance, ref Object obj);

        partial void FieldDefinitions_SetCondition(ref JsonWorkItemType instance, ref JsonFieldDefinitionCollection setValue);
        partial void Fields_SetCondition(ref JsonWorkItemType instance, ref IReadOnlyList<JsonFieldDefinition> setValue);
        partial void FromToken_PostValidate(JsonWorkItemType instance, JToken content, JsonWorkItemType _retVal);
        partial void FromToken_PreCondition(ref JsonWorkItemType instance, ref JToken content);
        partial void GetHashCode_PostValidate(JsonWorkItemType instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonWorkItemType instance);
        internal static IEnumerable<JsonWorkItemType> GetIEnumerableInstance() { return new List<JsonWorkItemType> {GetInstance()}; }

        internal static JsonWorkItemType GetInstance([CallerMemberName] string callerName = "")
        {
            JsonWorkItemType instance = default(JsonWorkItemType);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemType instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonWorkItemType instance);
        static partial void InstanceFactory(ref JsonWorkItemType instance, [CallerMemberName] string callerName = "");

        partial void JsonValue_SetCondition(ref JsonWorkItemType instance, ref JToken setValue);
        partial void Name_SetCondition(ref JsonWorkItemType instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonWorkItemType instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonWorkItemType instance);
        partial void ToString_PostValidate(JsonWorkItemType instance, String _retVal);
        partial void ToString_PreCondition(ref JsonWorkItemType instance);
    }
}