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
    public partial class JsonLinkCollection_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AddItem_UnitTest()
        {
            Object value = default(Object);
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    value = new Object();
                    AddItem_PreCondition(instance, ref value);
                },
                instance => { return _retVal = instance.AddItem(value); },
                instance => { AddItem_PostValidate(instance, value, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Add_UnitTest()
        {
            JsonHyperlink link = default(JsonHyperlink);
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    link = default(JsonHyperlink); //No Constructor
                    Add_PreCondition(instance, ref link);
                },
                instance => { return _retVal = instance.Add(link); },
                instance => { Add_PostValidate(instance, link, _retVal); });
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
            JsonLink item = default(JsonLink);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonLink); //No Constructor
                    Contains_PreCondition(instance, ref item);
                },
                instance => { return _retVal = instance.Contains(item); },
                instance => { Contains_PostValidate(instance, item, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CopyTo_UnitTest()
        {
            JsonLink[] array = default(JsonLink[]);
            Int32 arrayIndex = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    array = default(JsonLink[]); //No Constructor
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
                    JsonLinkCollection instance = GetInstance();
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
            JsonLinkCollection _retVal = default(JsonLinkCollection);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    value = new JArray();
                    FromToken_PreCondition(instance, ref value);
                },
                instance => { return _retVal = JsonLinkCollection.FromToken(value); },
                instance => { FromToken_PostValidate(instance, value, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetEnumerator_UnitTest()
        {
            IEnumerator<JsonLink> _retVal = default(IEnumerator<JsonLink>);
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
        public void GetItem_UnitTest()
        {
            Int32 index = default(Int32);
            Object _retVal = default(Object);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    GetItem_PreCondition(instance, ref index);
                },
                instance => { return _retVal = instance.GetItem(index); },
                instance => { GetItem_PostValidate(instance, index, _retVal); });
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
            JsonLink item = default(JsonLink);
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonLink); //No Constructor
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
            JsonLink item = default(JsonLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    item = default(JsonLink); //No Constructor
                    Insert_PreCondition(instance, ref index, ref item);
                },
                instance => { instance.Insert(index, item); },
                instance => { Insert_PostValidate(instance, index, item); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsFixedSize_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsFixedSize; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsReadOnly_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkCollection instance = GetInstance();
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
        public void IsSynchronized_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsSynchronized; },
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
                    JsonLinkCollection instance = GetInstance();
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
            JsonLink item = default(JsonLink);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonLink); //No Constructor
                    Remove_PreCondition(instance, ref item);
                },
                instance => { return _retVal = instance.Remove(item); },
                instance => { Remove_PostValidate(instance, item, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncRoot_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.SyncRoot; },
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void VersionTag_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkCollection instance = GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.VersionTag; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AddItem_PostValidate(JsonLinkCollection instance, Object value, Int32 _retVal);
        partial void AddItem_PreCondition(JsonLinkCollection instance, ref Object value);
        partial void Add_PostValidate(JsonLinkCollection instance, JsonHyperlink link, Int32 _retVal);
        partial void Add_PreCondition(JsonLinkCollection instance, ref JsonHyperlink link);
        partial void CaptureJson_PostValidate(JsonLinkCollection instance, JToken newFields);
        partial void CaptureJson_PreCondition(JsonLinkCollection instance, ref JToken newFields);
        partial void Clear_PostValidate(JsonLinkCollection instance);
        partial void Clear_PreCondition(JsonLinkCollection instance);
        partial void Contains_PostValidate(JsonLinkCollection instance, JsonLink item, Boolean _retVal);
        partial void Contains_PreCondition(JsonLinkCollection instance, ref JsonLink item);
        partial void CopyTo_PostValidate(JsonLinkCollection instance, JsonLink[] array, Int32 arrayIndex);
        partial void CopyTo_PreCondition(JsonLinkCollection instance, ref JsonLink[] array, ref Int32 arrayIndex);
        partial void Count_SetCondition(ref JsonLinkCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonLinkCollection instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonLinkCollection instance, ref Object obj);
        partial void FromToken_PostValidate(JsonLinkCollection instance, JArray value, JsonLinkCollection _retVal);
        partial void FromToken_PreCondition(JsonLinkCollection instance, ref JArray value);
        partial void GetEnumerator_PostValidate(JsonLinkCollection instance, IEnumerator<JsonLink> _retVal);
        partial void GetEnumerator_PreCondition(JsonLinkCollection instance);

        partial void GetHashCode_PostValidate(JsonLinkCollection instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonLinkCollection instance);
        internal static IEnumerable<JsonLinkCollection> GetIEnumerableInstance() { return new List<JsonLinkCollection> {GetInstance()}; }

        internal static JsonLinkCollection GetInstance([CallerMemberName] string callerName = "")
        {
            var json = new JArray();
            JsonSource(ref json);
            JsonLinkCollection instance = JsonLinkCollection.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetItem_PostValidate(JsonLinkCollection instance, Int32 index, Object _retVal);
        partial void GetItem_PreCondition(JsonLinkCollection instance, ref Int32 index);

        partial void GetType_PostValidate(JsonLinkCollection instance, Type _retVal);
        partial void GetType_PreCondition(JsonLinkCollection instance);
        partial void IndexOf_PostValidate(JsonLinkCollection instance, JsonLink item, Int32 _retVal);
        partial void IndexOf_PreCondition(JsonLinkCollection instance, ref JsonLink item);
        partial void Insert_PostValidate(JsonLinkCollection instance, Int32 index, JsonLink item);
        partial void Insert_PreCondition(JsonLinkCollection instance, ref Int32 index, ref JsonLink item);
        static partial void InstanceFactory(ref JsonLinkCollection instance, [CallerMemberName] string callerName = "");

        partial void IsFixedSize_SetCondition(ref JsonLinkCollection instance, ref Boolean setValue);

        partial void IsReadOnly_SetCondition(ref JsonLinkCollection instance, ref Boolean setValue);
        partial void IsSynchronized_SetCondition(ref JsonLinkCollection instance, ref Boolean setValue);
        static partial void JsonSource(ref JArray json);

        partial void JsonValue_SetCondition(ref JsonLinkCollection instance, ref JToken setValue);
        partial void RemoveAt_PostValidate(JsonLinkCollection instance, Int32 index);
        partial void RemoveAt_PreCondition(JsonLinkCollection instance, ref Int32 index);
        partial void Remove_PostValidate(JsonLinkCollection instance, JsonLink item, Boolean _retVal);
        partial void Remove_PreCondition(JsonLinkCollection instance, ref JsonLink item);
        partial void SyncRoot_SetCondition(ref JsonLinkCollection instance, ref Object setValue);
        partial void ToJSonString_PostValidate(JsonLinkCollection instance, String _retVal);
        partial void ToJSonString_PreCondition(JsonLinkCollection instance);
        partial void ToString_PostValidate(JsonLinkCollection instance, String _retVal);
        partial void ToString_PreCondition(JsonLinkCollection instance);
        partial void VersionTag_SetCondition(ref JsonLinkCollection instance, ref Int32 setValue);
    }
}