using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.Build
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class JsonBuildRequest_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Froms the token_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="token">The token.</param>
        partial void FromToken_PreCondition(JsonBuildRequest instance, ref JToken token) { token = TestData; }

        /// <summary>
        ///     Jsons the source.
        /// </summary>
        /// <param name="json">The json.</param>
        static partial void JsonSource(ref JToken json) { json = TestData; }

        /// <summary>
        ///     Gets the test data.
        /// </summary>
        /// <value>The test data.</value>
        private static JToken TestData
        {
            get
            {
                JObject jobject = CannedMessages.SampleBuildRequests;
                var array = jobject["value"].Value<JArray>();
                JToken json = array[0];
                return json;
            }
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "Project_UnitTest",
            "RequestDropLocation_UnitTest"
        };
    }
}