using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects_UnitTests
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonBackedObjectBase_UnitTests : DynTestClassBase
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
                    JsonBackedObjectBase instance = GetInstance();
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

        partial void CaptureJson_PostValidate(JsonBackedObjectBase instance, JToken token);
        partial void CaptureJson_PreCondition(ref JsonBackedObjectBase instance, ref JToken token);

        partial void Equals_PostValidate(JsonBackedObjectBase instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref JsonBackedObjectBase instance, ref Object obj);

        partial void GetHashCode_PostValidate(JsonBackedObjectBase instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref JsonBackedObjectBase instance);

        internal static IEnumerable<JsonBackedObjectBase> GetIEnumerableInstance()
        {
            return new List<JsonBackedObjectBase> {GetInstance()};
        }

        internal static JsonBackedObjectBase GetInstance([CallerMemberName] string callerName = "")
        {
            JsonBackedObjectBase instance = default(JsonBackedObjectBase);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonBackedObjectBase instance, Type _retVal);
        partial void GetType_PreCondition(ref JsonBackedObjectBase instance);
        static partial void InstanceFactory(ref JsonBackedObjectBase instance, [CallerMemberName] string callerName = "");

        partial void JsonValue_SetCondition(ref JsonBackedObjectBase instance, ref JToken setValue);
        partial void ToJSonString_PostValidate(JsonBackedObjectBase instance, String _retVal);
        partial void ToJSonString_PreCondition(ref JsonBackedObjectBase instance);
        partial void ToString_PostValidate(JsonBackedObjectBase instance, String _retVal);
        partial void ToString_PreCondition(ref JsonBackedObjectBase instance);
    }
}