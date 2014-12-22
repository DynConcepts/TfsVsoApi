using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
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
                    newFields = default(JToken); //No Type
                    CaptureJson_PreCondition(ref instance, ref newFields);
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
                    CopyTo_PreCondition(ref instance, ref array, ref index);
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
        public void GetEnumerator_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetEnumerator_PreCondition(ref instance); },
                instance => { instance.GetEnumerator(); },
                instance => { GetEnumerator_PostValidate(instance); });
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

        partial void CaptureJson_PostValidate(JsonFieldDefinitionCollection instance, JToken newFields);
        partial void CaptureJson_PreCondition(ref JsonFieldDefinitionCollection instance, ref JToken newFields);
        partial void CopyTo_PostValidate(JsonFieldDefinitionCollection instance, Array array, Int32 index);
        partial void CopyTo_PreCondition(ref JsonFieldDefinitionCollection instance, ref Array array, ref Int32 index);
        partial void Count_SetCondition(ref JsonFieldDefinitionCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonFieldDefinitionCollection instance, Object obj);
        partial void Equals_PreCondition(ref JsonFieldDefinitionCollection instance, ref Object obj);
        partial void GetEnumerator_PostValidate(JsonFieldDefinitionCollection instance);
        partial void GetEnumerator_PreCondition(ref JsonFieldDefinitionCollection instance);

        partial void GetHashCode_PostValidate(JsonFieldDefinitionCollection instance);
        partial void GetHashCode_PreCondition(ref JsonFieldDefinitionCollection instance);
        internal static IEnumerable<JsonFieldDefinitionCollection> GetIEnumerableInstance() { return new List<JsonFieldDefinitionCollection> {GetInstance()}; }

        internal static JsonFieldDefinitionCollection GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonFieldDefinitionCollection instance = JsonFieldDefinitionCollection.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonFieldDefinitionCollection instance);
        partial void GetType_PreCondition(ref JsonFieldDefinitionCollection instance);
        static partial void InstanceFactory(ref JsonFieldDefinitionCollection instance, [CallerMemberName] string callerName = "");

        partial void IsReadOnly_SetCondition(ref JsonFieldDefinitionCollection instance, ref Boolean setValue);
        static partial void JsonSource(ref JToken json);

        partial void JsonValue_SetCondition(ref JsonFieldDefinitionCollection instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonFieldDefinitionCollection instance);
        partial void ToJSonString_PreCondition(ref JsonFieldDefinitionCollection instance);
        partial void ToString_PostValidate(JsonFieldDefinitionCollection instance);
        partial void ToString_PreCondition(ref JsonFieldDefinitionCollection instance);
    }
}