using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonWorkItem_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void APIFactory_UnitTest()
        {
            ExecuteProperty(
                // Create Set Value
                () =>
                {
                    Func<JsonWitAPI> setValue = default(Func<JsonWitAPI>);
                    APIFactory_SetCondition(ref setValue);
                    return setValue;
                },
                // Invoke Setter
                setValue => { JsonWorkItem.APIFactory = setValue; },
                // Validate Set Operation
                setValue => { },
                // Invoke Getter
                () => { return JsonWorkItem.APIFactory; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CaptureJson_UnitTest()
        {
            JObject jObject = default(JObject);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    jObject = new JObject();
                    CaptureJson_PreCondition(instance, ref jObject);
                },
                instance => { instance.CaptureJson(jObject); },
                instance => { CaptureJson_PostValidate(instance, jObject); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangeWorkItemType_UnitTest()
        {
            String workItemType = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    workItemType = default(String); //No Constructor
                    ChangeWorkItemType_PreCondition(instance, ref workItemType);
                },
                instance => { instance.ChangeWorkItemType(workItemType); },
                instance => { ChangeWorkItemType_PostValidate(instance, workItemType); });
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
        public void FieldsMode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    FieldsMode_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.FieldsMode = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.FieldsMode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldsToJArray_UnitTest()
        {
            JsonWorkItem workItem = default(JsonWorkItem);
            JArray _retVal = default(JArray);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    workItem = default(JsonWorkItem); //No Constructor
                    FieldsToJArray_PreCondition(instance, ref workItem);
                },
                instance => { return _retVal = JsonWorkItem.FieldsToJArray(workItem); },
                instance => { FieldsToJArray_PostValidate(instance, workItem, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Fields_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
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
            JToken json = default(JToken);
            JsonWorkItem _retVal = default(JsonWorkItem);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    json = default(JToken); //No Constructor
                    FromToken_PreCondition(instance, ref json);
                },
                instance => { return _retVal = JsonWorkItem.FromToken(json); },
                instance => { FromToken_PostValidate(instance, json, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldType_UnitTest()
        {
            String fieldName = default(String);
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    fieldName = default(String); //No Constructor
                    GetFieldType_PreCondition(instance, ref fieldName);
                },
                instance => { return _retVal = instance.GetFieldType(fieldName); },
                instance => { GetFieldType_PostValidate(instance, fieldName, _retVal); });
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
        public void Id_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
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
                    JsonWorkItem instance = GetInstance();
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
        public void LinkMode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    LinkMode_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.LinkMode = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.LinkMode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Links_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Links; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProjectName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ProjectName; },
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
                    JsonWorkItem instance = GetInstance();
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
        public void SetFieldValue_UnitTest()
        {
            String fieldName = default(String);
            Object value = default(Object);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    fieldName = default(String); //No Constructor
                    value = new Object();
                    SetFieldValue_PreCondition(instance, ref fieldName, ref value);
                },
                instance => { instance.SetFieldValue(fieldName, value); },
                instance => { SetFieldValue_PostValidate(instance, fieldName, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetJsonContent_UnitTest()
        {
            JToken content = default(JToken);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    content = default(JToken); //No Constructor
                    SetJsonContent_PreCondition(instance, ref content);
                },
                instance => { instance.SetJsonContent(content); },
                instance => { SetJsonContent_PostValidate(instance, content); });
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
        public void TryGetField_UnitTest()
        {
            String fieldName = default(String);
            JsonField fieldValue = default(JsonField);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    fieldName = default(String); //No Constructor
                    TryGetField_PreCondition(instance, ref fieldName, ref fieldValue);
                },
                instance => { return _retVal = instance.TryGetField(fieldName, out fieldValue); },
                instance => { TryGetField_PostValidate(instance, fieldName, fieldValue, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Url_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Url; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemTypeName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItem instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemTypeName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void APIFactory_SetCondition(ref Func<JsonWitAPI> setValue);
        partial void CaptureJson_PostValidate(JsonWorkItem instance, JObject jObject);
        partial void CaptureJson_PreCondition(JsonWorkItem instance, ref JObject jObject);
        partial void ChangeWorkItemType_PostValidate(JsonWorkItem instance, String workItemType);
        partial void ChangeWorkItemType_PreCondition(JsonWorkItem instance, ref String workItemType);

        partial void Equals_PostValidate(JsonWorkItem instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonWorkItem instance, ref Object obj);
        partial void FieldsMode_SetCondition(ref JsonWorkItem instance, ref String setValue);
        partial void FieldsToJArray_PostValidate(JsonWorkItem instance, JsonWorkItem workItem, JArray _retVal);
        partial void FieldsToJArray_PreCondition(JsonWorkItem instance, ref JsonWorkItem workItem);
        partial void Fields_SetCondition(ref JsonWorkItem instance, ref JsonFieldCollection setValue);
        partial void FromToken_PostValidate(JsonWorkItem instance, JToken json, JsonWorkItem _retVal);
        partial void FromToken_PreCondition(JsonWorkItem instance, ref JToken json);
        partial void GetFieldType_PostValidate(JsonWorkItem instance, String fieldName, Type _retVal);
        partial void GetFieldType_PreCondition(JsonWorkItem instance, ref String fieldName);

        partial void GetHashCode_PostValidate(JsonWorkItem instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonWorkItem instance);
        internal static IEnumerable<JsonWorkItem> GetIEnumerableInstance() { return new List<JsonWorkItem> {GetInstance()}; }

        internal static JsonWorkItem GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonWorkItem instance = JsonWorkItem.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItem instance, Type _retVal);
        partial void GetType_PreCondition(JsonWorkItem instance);

        partial void Id_SetCondition(ref JsonWorkItem instance, ref Int32 setValue);
        static partial void InstanceFactory(ref JsonWorkItem instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonWorkItem instance, ref JToken setValue);

        partial void LinkMode_SetCondition(ref JsonWorkItem instance, ref String setValue);

        partial void Links_SetCondition(ref JsonWorkItem instance, ref JsonLinkCollection setValue);

        partial void ProjectName_SetCondition(ref JsonWorkItem instance, ref String setValue);
        partial void Rev_SetCondition(ref JsonWorkItem instance, ref Int32 setValue);
        partial void SetFieldValue_PostValidate(JsonWorkItem instance, String fieldName, Object value);
        partial void SetFieldValue_PreCondition(JsonWorkItem instance, ref String fieldName, ref Object value);
        partial void SetJsonContent_PostValidate(JsonWorkItem instance, JToken content);
        partial void SetJsonContent_PreCondition(JsonWorkItem instance, ref JToken content);
        partial void ToJSonString_PostValidate(JsonWorkItem instance, String _retVal);
        partial void ToJSonString_PreCondition(JsonWorkItem instance);
        partial void ToString_PostValidate(JsonWorkItem instance, String _retVal);
        partial void ToString_PreCondition(JsonWorkItem instance);
        partial void TryGetField_PostValidate(JsonWorkItem instance, String fieldName, JsonField fieldValue, Boolean _retVal);
        partial void TryGetField_PreCondition(JsonWorkItem instance, ref String fieldName, ref JsonField fieldValue);

        partial void Url_SetCondition(ref JsonWorkItem instance, ref String setValue);

        partial void WorkItemTypeName_SetCondition(ref JsonWorkItem instance, ref String setValue);
    }
}