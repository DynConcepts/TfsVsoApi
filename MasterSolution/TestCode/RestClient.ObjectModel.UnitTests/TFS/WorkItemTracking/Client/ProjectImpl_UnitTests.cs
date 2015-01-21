using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ProjectImpl_UnitTests
    {
        /// <summary>
        ///     Class_s the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [ClassInitialize]
        public static void Class_Initialize(TestContext context) { var api = new JsonWitAPI(); }

        static partial void JsonSource(ref JToken json)
        {
            var retVal = new JObject();
            retVal.Add("id", Guid.NewGuid().ToString());
            json = retVal;
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "QueryHierarchy_UnitTest",
        };
    }
}