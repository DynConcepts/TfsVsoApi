using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItem_UnitTests : DynTestClassBase
    {
//        partial void GetField_PreCondition(ref DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonWorkItem instance, ref System.String fieldName) { fieldName = "System.Title"; }

        partial void GetFieldType_PreCondition(ref JsonWorkItem instance, ref String fieldName) { fieldName = "System.Title"; }

        static partial void JsonSource(ref JToken json) { json = JObject.Parse(CannedMessages.JsonWorkItem324); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "ChangeWorkItemType_UnitTest",
            "SetFieldValue_UnitTest",
            "SetJsonContent_UnitTest",
            "CaptureJson_UnitTest",
            "TryGetField_UnitTest"
        };
    }
}