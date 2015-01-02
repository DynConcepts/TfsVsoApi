using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonIteration_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonIteration JsonFieldCollection, ref JToken json)
        {
            var o = new JObject();
            json = o;
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "Links_UnitTest"
        };
    }
}