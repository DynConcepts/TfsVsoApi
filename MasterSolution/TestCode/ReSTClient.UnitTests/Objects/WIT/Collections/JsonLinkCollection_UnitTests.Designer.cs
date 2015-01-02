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
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    value = new Object();
                    AddItem_PreCondition(ref instance, ref value);
                },
                instance => { instance.AddItem(value); },
                instance => { AddItem_PostValidate(instance, value); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Add_UnitTest()
        {
            JsonHyperlink link = default(JsonHyperlink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    link = default(JsonHyperlink); //No Type
                    Add_PreCondition(ref instance, ref link);
                },
                instance => { instance.Add(link); },
                instance => { Add_PostValidate(instance, link); });
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
                    newFields = default(JToken); //No Type
                    CaptureJson_PreCondition(ref instance, ref newFields);
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
                instance => { Clear_PreCondition(ref instance); },
                instance => { instance.Clear(); },
                instance => { Clear_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Contains_UnitTest()
        {
            JsonLink item = default(JsonLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonLink); //No Type
                    Contains_PreCondition(ref instance, ref item);
                },
                instance => { instance.Contains(item); },
                instance => { Contains_PostValidate(instance, item); });
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
                    array = default(JsonLink[]); //No Type
                    arrayIndex = default(Int32); //No Constructor
                    CopyTo_PreCondition(ref instance, ref array, ref arrayIndex);
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
        public void GetItem_UnitTest()
        {
            Int32 index = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    GetItem_PreCondition(ref instance, ref index);
                },
                instance => { instance.GetItem(index); },
                instance => { GetItem_PostValidate(instance, index); });
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
        public void IndexOf_UnitTest()
        {
            JsonLink item = default(JsonLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonLink); //No Type
                    IndexOf_PreCondition(ref instance, ref item);
                },
                instance => { instance.IndexOf(item); },
                instance => { IndexOf_PostValidate(instance, item); });
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
                    item = default(JsonLink); //No Type
                    Insert_PreCondition(ref instance, ref index, ref item);
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
                    RemoveAt_PreCondition(ref instance, ref index);
                },
                instance => { instance.RemoveAt(index); },
                instance => { RemoveAt_PostValidate(instance, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Remove_UnitTest()
        {
            JsonLink item = default(JsonLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonLink); //No Type
                    Remove_PreCondition(ref instance, ref item);
                },
                instance => { instance.Remove(item); },
                instance => { Remove_PostValidate(instance, item); });
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

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void VersionTag_UnitTest()
        {
            int originalTagValue = int.MaxValue;
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonLinkCollection instance = GetInstance();
                    originalTagValue = instance.VersionTag;
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance =>
                {
                    instance.Clear();
                    return instance.VersionTag;
                },
                // Validate Get Operation
                (instance, setValue, getValue) => Assert.IsTrue(getValue > originalTagValue, "VersionTag did not increment on Clear()"));
        }

        partial void AddItem_PostValidate(JsonLinkCollection instance, Object value);
        partial void AddItem_PreCondition(ref JsonLinkCollection instance, ref Object value);
        partial void Add_PostValidate(JsonLinkCollection instance, JsonHyperlink link);
        partial void Add_PreCondition(ref JsonLinkCollection instance, ref JsonHyperlink link);
        partial void CaptureJson_PostValidate(JsonLinkCollection instance, JToken newFields);
        partial void CaptureJson_PreCondition(ref JsonLinkCollection instance, ref JToken newFields);
        partial void Clear_PostValidate(JsonLinkCollection instance);
        partial void Clear_PreCondition(ref JsonLinkCollection instance);
        partial void Contains_PostValidate(JsonLinkCollection instance, JsonLink item);
        partial void Contains_PreCondition(ref JsonLinkCollection instance, ref JsonLink item);
        partial void CopyTo_PostValidate(JsonLinkCollection instance, JsonLink[] array, Int32 arrayIndex);
        partial void CopyTo_PreCondition(ref JsonLinkCollection instance, ref JsonLink[] array, ref Int32 arrayIndex);
        partial void Count_SetCondition(ref JsonLinkCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonLinkCollection instance, Object obj);
        partial void Equals_PreCondition(ref JsonLinkCollection instance, ref Object obj);
        partial void GetEnumerator_PostValidate(JsonLinkCollection instance);
        partial void GetEnumerator_PreCondition(ref JsonLinkCollection instance);

        partial void GetHashCode_PostValidate(JsonLinkCollection instance);
        partial void GetHashCode_PreCondition(ref JsonLinkCollection instance);
        internal static IEnumerable<JsonLinkCollection> GetIEnumerableInstance() { return new List<JsonLinkCollection> {GetInstance()}; }

        internal static JsonLinkCollection GetInstance([CallerMemberName] string callerName = "")
        {
            var json = new JArray();
            JsonSource(ref json);
            JsonLinkCollection instance = JsonLinkCollection.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetItem_PostValidate(JsonLinkCollection instance, Int32 index);
        partial void GetItem_PreCondition(ref JsonLinkCollection instance, ref Int32 index);

        partial void GetType_PostValidate(JsonLinkCollection instance);
        partial void GetType_PreCondition(ref JsonLinkCollection instance);
        partial void IndexOf_PostValidate(JsonLinkCollection instance, JsonLink item);
        partial void IndexOf_PreCondition(ref JsonLinkCollection instance, ref JsonLink item);
        partial void Insert_PostValidate(JsonLinkCollection instance, Int32 index, JsonLink item);
        partial void Insert_PreCondition(ref JsonLinkCollection instance, ref Int32 index, ref JsonLink item);
        static partial void InstanceFactory(ref JsonLinkCollection instance, [CallerMemberName] string callerName = "");

        partial void IsFixedSize_SetCondition(ref JsonLinkCollection instance, ref Boolean setValue);

        partial void IsReadOnly_SetCondition(ref JsonLinkCollection instance, ref Boolean setValue);
        partial void IsSynchronized_SetCondition(ref JsonLinkCollection instance, ref Boolean setValue);
        static partial void JsonSource(ref JArray json);

        partial void JsonValue_SetCondition(ref JsonLinkCollection instance, ref JToken setValue);
        partial void RemoveAt_PostValidate(JsonLinkCollection instance, Int32 index);
        partial void RemoveAt_PreCondition(ref JsonLinkCollection instance, ref Int32 index);
        partial void Remove_PostValidate(JsonLinkCollection instance, JsonLink item);
        partial void Remove_PreCondition(ref JsonLinkCollection instance, ref JsonLink item);
        partial void SyncRoot_SetCondition(ref JsonLinkCollection instance, ref Object setValue);
        partial void ToJSonString_PostValidate(JsonLinkCollection instance);
        partial void ToJSonString_PreCondition(ref JsonLinkCollection instance);
        partial void ToString_PostValidate(JsonLinkCollection instance);
        partial void ToString_PreCondition(ref JsonLinkCollection instance);
        partial void VersionTag_SetCondition(ref JsonLinkCollection instance, ref Int32 setValue);
    }
}