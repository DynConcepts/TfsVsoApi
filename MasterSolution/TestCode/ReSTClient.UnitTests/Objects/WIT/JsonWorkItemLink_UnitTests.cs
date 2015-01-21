using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItemLink_UnitTests : DynTestClassBase
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
        }

        partial void FromToken_PreCondition(JsonWorkItemLink instance, ref JToken json)
        {
            string src =
                @"{
 }";
            JObject jobject = JObject.Parse(src);
            json = jobject;
        }

        static partial void JsonSource(ref JToken json)
        {
            string src =
                @"{
 }";
            JObject jobject = JObject.Parse(src);
            json = jobject;
            //var array = jobject["value"].Value<JArray>();
            //json = array[0];
        }


        partial void Url_SetCondition(ref JsonWorkItemLink instance, ref String setValue) { setValue = "http://example.com"; }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "OtherWorkItem_UnitTest",
            "Attributes_UnitTest",
            "Rel_UnitTest",
            "Url_UnitTest"
        };
    }
}