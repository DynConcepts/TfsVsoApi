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
                    item = default(JsonWorkItemLink); //No Type
                    Add_PreCondition(ref instance, ref item);
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
            JsonWorkItemLink item = default(JsonWorkItemLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Type
                    Contains_PreCondition(ref instance, ref item);
                },
                instance => { instance.Contains(item); },
                instance => { Contains_PostValidate(instance, item); });
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
                    array = default(JsonWorkItemLink[]); //No Type
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
        public void IndexOf_UnitTest()
        {
            JsonWorkItemLink item = default(JsonWorkItemLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Type
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
            JsonWorkItemLink item = default(JsonWorkItemLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    item = default(JsonWorkItemLink); //No Type
                    Insert_PreCondition(ref instance, ref index, ref item);
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
                    RemoveAt_PreCondition(ref instance, ref index);
                },
                instance => { instance.RemoveAt(index); },
                instance => { RemoveAt_PostValidate(instance, index); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Remove_UnitTest()
        {
            JsonWorkItemLink item = default(JsonWorkItemLink);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    item = default(JsonWorkItemLink); //No Type
                    Remove_PreCondition(ref instance, ref item);
                },
                instance => { instance.Remove(item); },
                instance => { Remove_PostValidate(instance, item); });
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

        partial void Add_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item);
        partial void Add_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void CaptureJson_PostValidate(JsonWorkItemLinkCollection instance, JToken newFields);
        partial void CaptureJson_PreCondition(ref JsonWorkItemLinkCollection instance, ref JToken newFields);
        partial void Clear_PostValidate(JsonWorkItemLinkCollection instance);
        partial void Clear_PreCondition(ref JsonWorkItemLinkCollection instance);
        partial void Contains_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item);
        partial void Contains_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void CopyTo_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink[] array, Int32 arrayIndex);
        partial void CopyTo_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink[] array, ref Int32 arrayIndex);
        partial void Count_SetCondition(ref JsonWorkItemLinkCollection instance, ref Int32 setValue);

        partial void Equals_PostValidate(JsonWorkItemLinkCollection instance, Object obj);
        partial void Equals_PreCondition(ref JsonWorkItemLinkCollection instance, ref Object obj);
        partial void GetEnumerator_PostValidate(JsonWorkItemLinkCollection instance);
        partial void GetEnumerator_PreCondition(ref JsonWorkItemLinkCollection instance);

        partial void GetHashCode_PostValidate(JsonWorkItemLinkCollection instance);
        partial void GetHashCode_PreCondition(ref JsonWorkItemLinkCollection instance);
        internal static IEnumerable<JsonWorkItemLinkCollection> GetIEnumerableInstance() { return new List<JsonWorkItemLinkCollection> {GetInstance()}; }

        internal static JsonWorkItemLinkCollection GetInstance([CallerMemberName] string callerName = "")
        {
            var json = new JArray();
            JsonSource(ref json);
            JsonWorkItemLinkCollection instance = JsonWorkItemLinkCollection.FromToken(json);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemLinkCollection instance);
        partial void GetType_PreCondition(ref JsonWorkItemLinkCollection instance);
        partial void IndexOf_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item);
        partial void IndexOf_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void Insert_PostValidate(JsonWorkItemLinkCollection instance, Int32 index, JsonWorkItemLink item);
        partial void Insert_PreCondition(ref JsonWorkItemLinkCollection instance, ref Int32 index, ref JsonWorkItemLink item);
        static partial void InstanceFactory(ref JsonWorkItemLinkCollection instance, [CallerMemberName] string callerName = "");

        partial void IsReadOnly_SetCondition(ref JsonWorkItemLinkCollection instance, ref Boolean setValue);
        static partial void JsonSource(ref JArray json);

        partial void JsonValue_SetCondition(ref JsonWorkItemLinkCollection instance, ref JToken setValue);
        partial void RemoveAt_PostValidate(JsonWorkItemLinkCollection instance, Int32 index);
        partial void RemoveAt_PreCondition(ref JsonWorkItemLinkCollection instance, ref Int32 index);
        partial void Remove_PostValidate(JsonWorkItemLinkCollection instance, JsonWorkItemLink item);
        partial void Remove_PreCondition(ref JsonWorkItemLinkCollection instance, ref JsonWorkItemLink item);
        partial void ToJSonString_PostValidate(JsonWorkItemLinkCollection instance);
        partial void ToJSonString_PreCondition(ref JsonWorkItemLinkCollection instance);
        partial void ToString_PostValidate(JsonWorkItemLinkCollection instance);
        partial void ToString_PreCondition(ref JsonWorkItemLinkCollection instance);
    }
}