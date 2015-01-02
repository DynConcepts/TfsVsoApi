using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.TFVC
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonShelveSet_UnitTests : DynTestClassBase
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
        public void Comment_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonShelveSet instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Comment; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreatedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonShelveSet instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CreatedDate; },
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
            JToken token = default(JToken);
            JsonShelveSet _retVal = default(JsonShelveSet);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    token = default(JToken); //No Constructor
                    FromToken_PreCondition(ref instance, ref token);
                },
                instance => { _retVal = JsonShelveSet.FromToken(token); },
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
        public void Id_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonShelveSet instance = GetInstance();
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
                    JsonShelveSet instance = GetInstance();
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
                    JsonShelveSet instance = GetInstance();
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
        public void Owner_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonShelveSet instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Owner; },
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
                    JsonShelveSet instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Url; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void CaptureJson_PostValidate(JsonShelveSet instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonShelveSet instance, ref JToken token);

        partial void Comment_SetCondition(ref JsonShelveSet instance, ref String setValue);

        partial void CreatedDate_SetCondition(ref JsonShelveSet instance, ref DateTime setValue);
        partial void Equals_PostValidate(JsonShelveSet instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonShelveSet instance, ref Object obj);
        partial void FromToken_PostValidate(JsonShelveSet instance, JToken token, JsonShelveSet _retVal);
        partial void FromToken_PreCondition(ref JsonShelveSet instance, ref JToken token);
        partial void GetHashCode_PostValidate(JsonShelveSet instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonShelveSet instance);
        internal static IEnumerable<JsonShelveSet> GetIEnumerableInstance() { return new List<JsonShelveSet> {GetInstance()}; }

        internal static JsonShelveSet GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonShelveSet instance = JsonShelveSet.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonShelveSet instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonShelveSet instance);

        partial void Id_SetCondition(ref JsonShelveSet instance, ref Int32 setValue);
        static partial void InstanceFactory(ref JsonShelveSet instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);
        partial void JsonValue_SetCondition(ref JsonShelveSet instance, ref JToken setValue);

        partial void Name_SetCondition(ref JsonShelveSet instance, ref String setValue);

        partial void Owner_SetCondition(ref JsonShelveSet instance, ref String setValue);
        partial void ToJSonString_PostValidate(JsonShelveSet instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonShelveSet instance);
        partial void ToString_PostValidate(JsonShelveSet instance, String _retVal);
        partial void ToString_PreCondition(ref JsonShelveSet instance);

        partial void Url_SetCondition(ref JsonShelveSet instance, ref String setValue);
    }
}