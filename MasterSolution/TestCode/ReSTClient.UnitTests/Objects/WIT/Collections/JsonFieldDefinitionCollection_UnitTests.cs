using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonFieldDefinitionCollection_UnitTests : DynTestClassBase
    {
        partial void CopyTo_PreCondition(JsonFieldDefinitionCollection instance, ref Array array, ref Int32 index)
        {
            array = new JsonFieldDefinition[instance.Count + 1];
            index = 1;
        }

        partial void FromToken_PreCondition(JsonFieldDefinitionCollection instance, ref JToken json) { json = new JArray(); }


        static partial void JsonSource(ref JToken json) { json = new JArray(); }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "GetDefinition_UnitTest",
        };
    }
}