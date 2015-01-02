using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ExternalLinkImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();
            var retVal = new JObject();
            retVal.Add("rel", "ExternalLinkImpl.Rel");
            json = retVal;
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "LinkedArtifactUri_UnitTest",
        };
    }
}