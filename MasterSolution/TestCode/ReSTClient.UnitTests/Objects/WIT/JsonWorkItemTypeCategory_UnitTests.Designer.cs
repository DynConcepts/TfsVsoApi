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
    public partial class JsonWorkItemTypeCategory_UnitTests : DynTestClassBase
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
        public void DefaultWorkItemType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemTypeCategory instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.DefaultWorkItemType; },
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
        public void FromToken_UnitTest()
        {
            JToken content = default(JToken);
            JsonWorkItemTypeCategory _retVal = default(JsonWorkItemTypeCategory);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    content = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref content);
                },
                instance => { _retVal = JsonWorkItemTypeCategory.FromToken(content); },
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
                    JsonWorkItemTypeCategory instance = GetInstance();
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
                    JsonWorkItemTypeCategory instance = GetInstance();
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
                    JsonWorkItemTypeCategory instance = GetInstance();
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
                    JsonWorkItemTypeCategory instance = GetInstance();
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
        public void WorkItemTypes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemTypeCategory instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemTypes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CaptureJson_PostValidate(JsonWorkItemTypeCategory instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonWorkItemTypeCategory instance, ref JToken token);
        partial void DefaultWorkItemType_SetCondition(ref JsonWorkItemTypeCategory instance, ref JsonWorkItemType setValue);

        partial void Equals_PostValidate(JsonWorkItemTypeCategory instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonWorkItemTypeCategory instance, ref Object obj);
        partial void FromToken_PostValidate(JsonWorkItemTypeCategory instance, JToken content, JsonWorkItemTypeCategory _retVal);
        partial void FromToken_PreCondition(ref JsonWorkItemTypeCategory instance, ref JToken content);

        partial void GetHashCode_PostValidate(JsonWorkItemTypeCategory instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonWorkItemTypeCategory instance);
        internal static IEnumerable<JsonWorkItemTypeCategory> GetIEnumerableInstance() { return new List<JsonWorkItemTypeCategory> {GetInstance()}; }

        internal static JsonWorkItemTypeCategory GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonWorkItemTypeCategory instance = JsonWorkItemTypeCategory.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemTypeCategory instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonWorkItemTypeCategory instance);
        static partial void InstanceFactory(ref JsonWorkItemTypeCategory instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonWorkItemTypeCategory instance, ref JToken setValue);

        partial void Name_SetCondition(ref JsonWorkItemTypeCategory instance, ref String setValue);

        partial void ReferenceName_SetCondition(ref JsonWorkItemTypeCategory instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonWorkItemTypeCategory instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonWorkItemTypeCategory instance);
        partial void ToString_PostValidate(JsonWorkItemTypeCategory instance, String _retVal);
        partial void ToString_PreCondition(ref JsonWorkItemTypeCategory instance);

        partial void Url_SetCondition(ref JsonWorkItemTypeCategory instance, ref String setValue);

        partial void WorkItemTypes_SetCondition(ref JsonWorkItemTypeCategory instance, ref IReadOnlyList<JsonWorkItemType> setValue);
    }
}