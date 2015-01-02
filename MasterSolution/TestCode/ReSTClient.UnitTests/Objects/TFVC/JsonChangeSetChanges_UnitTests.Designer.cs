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
    public partial class JsonChangeSetChanges_UnitTests : DynTestClassBase
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
                    token = default(JToken); //No Type
                    CaptureJson_PreCondition(ref instance, ref token);
                },
                instance => { instance.CaptureJson(token); },
                instance => { CaptureJson_PostValidate(instance, token); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangeType_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonChangeSetChanges instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ChangeType; },
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
                    JsonChangeSetChanges instance = GetInstance();
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

        partial void CaptureJson_PostValidate(JsonChangeSetChanges instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonChangeSetChanges instance, ref JToken token);
        partial void ChangeType_SetCondition(ref JsonChangeSetChanges instance, ref String setValue);

        partial void Equals_PostValidate(JsonChangeSetChanges instance, Object obj);
        partial void Equals_PreCondition(ref JsonChangeSetChanges instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonChangeSetChanges instance);
        partial void GetHashCode_PreCondition(ref JsonChangeSetChanges instance);
        internal static IEnumerable<JsonChangeSetChanges> GetIEnumerableInstance() { return new List<JsonChangeSetChanges> {GetInstance()}; }

        internal static JsonChangeSetChanges GetInstance([CallerMemberName] string callerName = "")
        {
            JToken json = new JObject();
            JsonSource(ref json);
            JsonChangeSetChanges instance = JsonChangeSetChanges.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonChangeSetChanges instance);
        partial void GetType_PreCondition(ref JsonChangeSetChanges instance);
        static partial void InstanceFactory(ref JsonChangeSetChanges instance, [CallerMemberName] string callerName = "");
        static partial void JsonSource(ref JToken json);

        partial void JsonValue_SetCondition(ref JsonChangeSetChanges instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonChangeSetChanges instance);
        partial void ToJSonString_PreCondition(ref JsonChangeSetChanges instance);
        partial void ToString_PostValidate(JsonChangeSetChanges instance);
        partial void ToString_PreCondition(ref JsonChangeSetChanges instance);
    }
}