using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonWorkItem_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context)
        {
            var api = new JsonWitAPI();
            Assert.IsNotNull(api);
            JsonWorkItem.APIFactory = () => api;
        }

//        partial void GetField_PreCondition(DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonWorkItem instance, ref System.String fieldName) { fieldName = "System.Title"; }

        /// <summary>
        ///     APIs the factory_ set condition.
        /// </summary>
        /// <param name="setValue">The set value.</param>
        partial void APIFactory_SetCondition(ref Func<JsonWitAPI> setValue)
        {
            setValue = () => new JsonWitAPI();
        }

        /// <summary>
        ///     Fieldses to j array_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="workItem">The work item.</param>
        partial void FieldsToJArray_PreCondition(JsonWorkItem instance, ref JsonWorkItem workItem)
        {
            workItem = GetInstance();
        }

        /// <summary>
        ///     Froms the token_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="json">The json.</param>
        partial void FromToken_PreCondition(JsonWorkItem instance, ref JToken json)
        {
            json = JObject.Parse(CannedMessages.JsonWorkItem324);
        }

        /// <summary>
        ///     Gets the field type_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="fieldName">Name of the field.</param>
        partial void GetFieldType_PreCondition(JsonWorkItem instance, ref String fieldName)
        {
            fieldName = "System.Title";
        }

        /// <summary>
        ///     Jsons the source.
        /// </summary>
        /// <param name="json">The json.</param>
        static partial void JsonSource(ref JToken json)
        {
            json = JObject.Parse(CannedMessages.JsonWorkItem324);
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        /// <summary>
        ///     The SR_ disabled tests
        /// </summary>
        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "ChangeWorkItemType_UnitTest",
            "SetFieldValue_UnitTest",
            "SetJsonContent_UnitTest",
            "CaptureJson_UnitTest",
            "TryGetField_UnitTest",
            "APIFactory_UnitTest",
            "FieldsToJArray_UnitTest",
        };
    }
}