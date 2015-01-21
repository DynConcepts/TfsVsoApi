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
    public partial class JsonWorkItemLinkCollection_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Add_UnitTest()
        {
            JsonWorkItemLink item = default(JsonWorkItemLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Constructor
                    Add_PreCondition(instance, ref item);
                },
                instance => { instance.Add(item); },
                instance => { Add_PostValidate(instance, item); });
        }

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
        public void Clear_UnitTest()
        {
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { Clear_PreCondition(instance); },
                instance => { instance.Clear(); },
                instance => { Clear_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Contains_UnitTest()
        {
            JsonWorkItemLink item = default(JsonWorkItemLink);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Constructor
                    Contains_PreCondition(instance, ref item);
                },
                instance => { return _retVal = instance.Contains(item); },
                instance => { Contains_PostValidate(instance, item, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CopyTo_UnitTest()
        {
            JsonWorkItemLink[] array = default(JsonWorkItemLink[]);
            Int32 arrayIndex = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    array = default(JsonWorkItemLink[]); //No Constructor
                    arrayIndex = default(Int32); //No Constructor
                    CopyTo_PreCondition(instance, ref array, ref arrayIndex);
                },
                instance => { instance.CopyTo(array, arrayIndex); },
                instance => { CopyTo_PostValidate(instance, array, arrayIndex); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Count_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemLinkCollection instance = GetInstance();
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
            JArray value = default(JArray);
            JsonWorkItemLinkCollection _retVal = default(JsonWorkItemLinkCollection);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    value = new JArray();
                    FromToken_PreCondition(instance, ref value);
                },
                instance => { return _retVal = JsonWorkItemLinkCollection.FromToken(value); },
                instance => { FromToken_PostValidate(instance, value, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetEnumerator_UnitTest()
        {
            IEnumerator<JsonWorkItemLink> _retVal = default(IEnumerator<JsonWorkItemLink>);
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
        public void IndexOf_UnitTest()
        {
            JsonWorkItemLink item = default(JsonWorkItemLink);
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Constructor
                    IndexOf_PreCondition(instance, ref item);
                },
                instance => { return _retVal = instance.IndexOf(item); },
                instance => { IndexOf_PostValidate(instance, item, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Insert_UnitTest()
        {
            Int32 index = default(Int32);
            JsonWorkItemLink item = default(JsonWorkItemLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    item = default(JsonWorkItemLink); //No Constructor
                    Insert_PreCondition(instance, ref index, ref item);
                },
                instance => { instance.Insert(index, item); },
                instance => { Insert_PostValidate(instance, index, item); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsReadOnly_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemLinkCollection instance = GetInstance();
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
                    JsonWorkItemLinkCollection instance = GetInstance();
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
        public void RemoveAt_UnitTest()
        {
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    RemoveAt_PreCondition(instance, ref index);
                },
                instance => { instance.RemoveAt(index); },
                instance => { RemoveAt_PostValidate(instance, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Remove_UnitTest()
        {
            JsonWorkItemLink item = default(JsonWorkItemLink);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Constructor
                    Remove_PreCondition(instance, ref item);
                },
                instance => { return _retVal = instance.Remove(item); },
                instance => { Remove_PostValidate(instance, item, _retVal); });
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
        public void VersionTag_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemLinkCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.VersionTag; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Add_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item);
        partial void Add_PreCondition(JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void CaptureJson_PostValidate(JsonWorkItemLinkCollection instance, JToken newFields);
        partial void CaptureJson_PreCondition(JsonWorkItemLinkCollection instance, ref JToken newFields);
        partial void Clear_PostValidate(JsonWorkItemLinkCollection instance);
        partial void Clear_PreCondition(JsonWorkItemLinkCollection instance);
        partial void Contains_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item, Boolean _retVal);
        partial void Contains_PreCondition(JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void CopyTo_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink[] array, Int32 arrayIndex);
        partial void CopyTo_PreCondition(JsonWorkItemLinkCollection instance, ref JsonWorkItemLink[] array, ref Int32 arrayIndex);
        partial void Count_SetCondition(ref JsonWorkItemLinkCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonWorkItemLinkCollection instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonWorkItemLinkCollection instance, ref Object obj);
        partial void FromToken_PostValidate(JsonWorkItemLinkCollection instance, JArray value, JsonWorkItemLinkCollection _retVal);
        partial void FromToken_PreCondition(JsonWorkItemLinkCollection instance, ref JArray value);
        partial void GetEnumerator_PostValidate(JsonWorkItemLinkCollection instance, IEnumerator<JsonWorkItemLink> _retVal);
        partial void GetEnumerator_PreCondition(JsonWorkItemLinkCollection instance);

        partial void GetHashCode_PostValidate(JsonWorkItemLinkCollection instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonWorkItemLinkCollection instance);
        internal static IEnumerable<JsonWorkItemLinkCollection> GetIEnumerableInstance() { return new List<JsonWorkItemLinkCollection> {GetInstance()}; }

        internal static JsonWorkItemLinkCollection GetInstance([CallerMemberName] string callerName = "")
        {
            var json = new JArray();
            JsonSource(ref json);
            JsonWorkItemLinkCollection instance = JsonWorkItemLinkCollection.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemLinkCollection instance, Type _retVal);
        partial void GetType_PreCondition(JsonWorkItemLinkCollection instance);
        partial void IndexOf_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item, Int32 _retVal);
        partial void IndexOf_PreCondition(JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void Insert_PostValidate(JsonWorkItemLinkCollection instance, Int32 index, JsonWorkItemLink item);
        partial void Insert_PreCondition(JsonWorkItemLinkCollection instance, ref Int32 index, ref JsonWorkItemLink item);
        static partial void InstanceFactory(ref JsonWorkItemLinkCollection instance, [CallerMemberName] string callerName = "");

        partial void IsReadOnly_SetCondition(ref JsonWorkItemLinkCollection instance, ref Boolean setValue);
        static partial void JsonSource(ref JArray json);

        partial void JsonValue_SetCondition(ref JsonWorkItemLinkCollection instance, ref JToken setValue);
        partial void RemoveAt_PostValidate(JsonWorkItemLinkCollection instance, Int32 index);
        partial void RemoveAt_PreCondition(JsonWorkItemLinkCollection instance, ref Int32 index);
        partial void Remove_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item, Boolean _retVal);
        partial void Remove_PreCondition(JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void ToJSonString_PostValidate(JsonWorkItemLinkCollection instance, String _retVal);
        partial void ToJSonString_PreCondition(JsonWorkItemLinkCollection instance);
        partial void ToString_PostValidate(JsonWorkItemLinkCollection instance, String _retVal);
        partial void ToString_PreCondition(JsonWorkItemLinkCollection instance);
        partial void VersionTag_SetCondition(ref JsonWorkItemLinkCollection instance, ref Int32 setValue);
    }
}