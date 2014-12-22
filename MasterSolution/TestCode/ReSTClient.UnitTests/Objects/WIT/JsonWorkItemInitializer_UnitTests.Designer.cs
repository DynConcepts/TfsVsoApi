using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonWorkItemInitializer_UnitTests : DynTestClassBase
    {
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
        public void LinkTypeEndInitializer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemInitializer instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd> setValue = default(IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd>);
                    LinkTypeEndInitializer_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.LinkTypeEndInitializer = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.LinkTypeEndInitializer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void OtherItemInitializer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemInitializer instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem> setValue = default(IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem>);
                    OtherItemInitializer_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.OtherItemInitializer = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.OtherItemInitializer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
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

        partial void Equals_PostValidate(JsonWorkItemInitializer instance, Object obj);
        partial void Equals_PreCondition(ref JsonWorkItemInitializer instance, ref Object obj);
        partial void GetHashCode_PostValidate(JsonWorkItemInitializer instance);
        partial void GetHashCode_PreCondition(ref JsonWorkItemInitializer instance);
        internal static IEnumerable<JsonWorkItemInitializer> GetIEnumerableInstance() { return new List<JsonWorkItemInitializer> {GetInstance()}; }

        internal static JsonWorkItemInitializer GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonWorkItemInitializer();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemInitializer instance);
        partial void GetType_PreCondition(ref JsonWorkItemInitializer instance);
        static partial void InstanceFactory(ref JsonWorkItemInitializer instance, [CallerMemberName] string callerName = "");

        partial void LinkTypeEndInitializer_SetCondition(ref JsonWorkItemInitializer instance, ref IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd> setValue);
        partial void OtherItemInitializer_SetCondition(ref JsonWorkItemInitializer instance, ref IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem> setValue);
        partial void ToString_PostValidate(JsonWorkItemInitializer instance);
        partial void ToString_PreCondition(ref JsonWorkItemInitializer instance);
    }
}