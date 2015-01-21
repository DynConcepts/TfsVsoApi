using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class LinkImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
            var retVal = new JObject();
            retVal.Add("source", "Testing..Link.ReferenceName");
            retVal.Add("rel", "Testing..Link.Rel");
            json = retVal;
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "ArtifactLinkType_UnitTest",
            "BaseType_UnitTest",
        };
    }
}