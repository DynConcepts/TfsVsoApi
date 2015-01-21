using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonFieldDefinitionCollection_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CaptureJson_UnitTest()
        {
            JToken newFields = default(JToken);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    newFields = default(JToken); //No Constructor
                    CaptureJson_PreCondition(instance, ref newFields);
                },
                instance => { instance.CaptureJson(newFields); },
                instance => { CaptureJson_PostValidate(instance, newFields); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CopyTo_UnitTest()
        {
            Array array = default(Array);
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    array = default(Array); //No Constructor
                    index = default(Int32); //No Constructor
                    CopyTo_PreCondition(instance, ref array, ref index);
                },
                instance => { instance.CopyTo(array, index); },
                instance => { CopyTo_PostValidate(instance, array, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Count_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonFieldDefinitionCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Count; },
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
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FromToken_UnitTest()
        {
            JToken token = default(JToken);
            JsonFieldDefinitionCollection _retVal = default(JsonFieldDefinitionCollection);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    FromToken_PreCondition(instance, ref token);
                },
                instance => { return _retVal = JsonFieldDefinitionCollection.FromToken(token); },
                instance => { FromToken_PostValidate(instance, token, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDefinition_UnitTest()
        {
            String referenceName = default(String);
            JsonFieldDefinition _retVal = default(JsonFieldDefinition);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    referenceName = default(String); //No Constructor
                    GetDefinition_PreCondition(instance, ref referenceName);
                },
                instance => { return _retVal = JsonFieldDefinitionCollection.GetDefinition(referenceName); },
                instance => { GetDefinition_PostValidate(instance, referenceName, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetEnumerator_UnitTest()
        {
            IEnumerator<JsonFieldDefinition> _retVal = default(IEnumerator<JsonFieldDefinition>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetEnumerator_PreCondition(instance); },
                instance => { return _retVal = instance.GetEnumerator(); },
                instance => { GetEnumerator_PostValidate(instance, _retVal); });
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
        public void IsReadOnly_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonFieldDefinitionCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsReadOnly; },
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
                    JsonFieldDefinitionCollection instance = GetInstance();
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

        partial void CaptureJson_PostValidate(JsonFieldDefinitionCollection instance, JToken newFields);
        partial void CaptureJson_PreCondition(JsonFieldDefinitionCollection instance, ref JToken newFields);
        partial void CopyTo_PostValidate(JsonFieldDefinitionCollection instance, Array array, Int32 index);
        partial void CopyTo_PreCondition(JsonFieldDefinitionCollection instance, ref Array array, ref Int32 index);
        partial void Count_SetCondition(ref JsonFieldDefinitionCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonFieldDefinitionCollection instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonFieldDefinitionCollection instance, ref Object obj);
        partial void FromToken_PostValidate(JsonFieldDefinitionCollection instance, JToken token, JsonFieldDefinitionCollection _retVal);
        partial void FromToken_PreCondition(JsonFieldDefinitionCollection instance, ref JToken token);
        partial void GetDefinition_PostValidate(JsonFieldDefinitionCollection instance, String referenceName, JsonFieldDefinition _retVal);
        partial void GetDefinition_PreCondition(JsonFieldDefinitionCollection instance, ref String referenceName);
        partial void GetEnumerator_PostValidate(JsonFieldDefinitionCollection instance, IEnumerator<JsonFieldDefinition> _retVal);
        partial void GetEnumerator_PreCondition(JsonFieldDefinitionCollection instance);

        partial void GetHashCode_PostValidate(JsonFieldDefinitionCollection instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonFieldDefinitionCollection instance);
        internal static IEnumerable<JsonFieldDefinitionCollection> GetIEnumerableInstance() { return new List<JsonFieldDefinitionCollection> {GetInstance()}; }

        internal static JsonFieldDefinitionCollection GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonFieldDefinitionCollection instance = JsonFieldDefinitionCollection.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonFieldDefinitionCollection instance, Type _retVal);
        partial void GetType_PreCondition(JsonFieldDefinitionCollection instance);
        static partial void InstanceFactory(ref JsonFieldDefinitionCollection instance, [CallerMemberName] string callerName = "");

        partial void IsReadOnly_SetCondition(ref JsonFieldDefinitionCollection instance, ref Boolean setValue);
        static partial void JsonSource(ref JToken json);

        partial void JsonValue_SetCondition(ref JsonFieldDefinitionCollection instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonFieldDefinitionCollection instance, String _retVal);
        partial void ToJSonString_PreCondition(JsonFieldDefinitionCollection instance);
        partial void ToString_PostValidate(JsonFieldDefinitionCollection instance, String _retVal);
        partial void ToString_PreCondition(JsonFieldDefinitionCollection instance);
    }
}