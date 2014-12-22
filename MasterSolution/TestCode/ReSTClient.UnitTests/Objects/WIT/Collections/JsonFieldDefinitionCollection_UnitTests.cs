using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonFieldDefinitionCollection_UnitTests : DynTestClassBase
    {
        partial void CopyTo_PreCondition(ref JsonFieldDefinitionCollection instance, ref Array array, ref Int32 index)
        {
            array = new JsonFieldDefinition[instance.Count + 1];
            index = 1;
        }

        static partial void JsonSource(ref JToken json) { json = new JArray(); }
    }
}