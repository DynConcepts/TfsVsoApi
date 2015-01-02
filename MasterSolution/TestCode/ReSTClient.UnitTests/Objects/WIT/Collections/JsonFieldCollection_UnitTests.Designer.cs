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
    public partial class JsonFieldCollection_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CaptureJson_UnitTest()
        {
            Int32 id = default(Int32);
            Int32 rev = default(Int32);
            JToken newFields = default(JToken);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    rev = default(Int32); //No Constructor
                    newFields = default(JToken); //No Constructor
                    CaptureJson_PreCondition(ref instance, ref id, ref rev, ref newFields);
                },
                instance => { instance.CaptureJson(id, rev, newFields); },
                instance => { CaptureJson_PostValidate(instance, id, rev, newFields); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Contains_UnitTest()
        {
            String fieldName = default(String);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    fieldName = default(String); //No Constructor
                    Contains_PreCondition(ref instance, ref fieldName);
                },
                instance => { _retVal = instance.Contains(fieldName); },
                instance => { Contains_PostValidate(instance, fieldName, _retVal); });
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
                    JsonFieldCollection instance = GetInstance();
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
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetEnumerator_UnitTest()
        {
            IEnumerator<JsonField> _retVal = default(IEnumerator<JsonField>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetEnumerator_PreCondition(ref instance); },
                instance => { _retVal = instance.GetEnumerator(); },
                instance => { GetEnumerator_PostValidate(instance, _retVal); });
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
        public void IsReadOnly_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonFieldCollection instance = GetInstance();
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
                    JsonFieldCollection instance = GetInstance();
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TryGetField_UnitTest()
        {
            String fieldName = default(String);
            JsonField field = default(JsonField);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    fieldName = default(String); //No Constructor
                    TryGetField_PreCondition(ref instance, ref fieldName, ref field);
                },
                instance => { _retVal = instance.TryGetField(fieldName, out field); },
                instance => { TryGetField_PostValidate(instance, fieldName, field, _retVal); });
        }

        partial void CaptureJson_PostValidate(JsonFieldCollection instance, Int32 id, Int32 rev, JToken newFields);
        partial void CaptureJson_PreCondition(ref JsonFieldCollection instance, ref Int32 id, ref Int32 rev, ref JToken newFields);
        partial void Contains_PostValidate(JsonFieldCollection instance, String fieldName, Boolean _retVal);
        partial void Contains_PreCondition(ref JsonFieldCollection instance, ref String fieldName);
        partial void CopyTo_PostValidate(JsonFieldCollection instance, Array array, Int32 index);
        partial void CopyTo_PreCondition(ref JsonFieldCollection instance, ref Array array, ref Int32 index);
        partial void Count_SetCondition(ref JsonFieldCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonFieldCollection instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonFieldCollection instance, ref Object obj);
        partial void GetEnumerator_PostValidate(JsonFieldCollection instance, IEnumerator<JsonField> _retVal);
        partial void GetEnumerator_PreCondition(ref JsonFieldCollection instance);

        partial void GetHashCode_PostValidate(JsonFieldCollection instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonFieldCollection instance);
        internal static IEnumerable<JsonFieldCollection> GetIEnumerableInstance() { return new List<JsonFieldCollection> {GetInstance()}; }

        internal static JsonFieldCollection GetInstance([CallerMemberName] string callerName = "")
        {
            JsonFieldCollection instance = default(JsonFieldCollection);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonFieldCollection instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonFieldCollection instance);
        static partial void InstanceFactory(ref JsonFieldCollection instance, [CallerMemberName] string callerName = "");

        partial void IsReadOnly_SetCondition(ref JsonFieldCollection instance, ref Boolean setValue);

        partial void JsonValue_SetCondition(ref JsonFieldCollection instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonFieldCollection instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonFieldCollection instance);
        partial void ToString_PostValidate(JsonFieldCollection instance, String _retVal);
        partial void ToString_PreCondition(ref JsonFieldCollection instance);
        partial void TryGetField_PostValidate(JsonFieldCollection instance, String fieldName, JsonField field, Boolean _retVal);
        partial void TryGetField_PreCondition(ref JsonFieldCollection instance, ref String fieldName, ref JsonField field);
    }
}