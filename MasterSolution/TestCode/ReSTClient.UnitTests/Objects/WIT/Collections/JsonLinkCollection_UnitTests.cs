using System;
using System.Linq;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonLinkCollection_UnitTests : DynTestClassBase
    {
        partial void AddItem_PreCondition(JsonLinkCollection instance, ref Object value) { value = JsonHyperlink_UnitTests.GetInstance(); }

        partial void CopyTo_PreCondition(JsonLinkCollection instance, ref JsonLink[] array, ref Int32 arrayIndex)
        {
            array = new JsonLink[100];
            arrayIndex = 1;
        }

        static partial void JsonSource(ref JArray json)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();

            JObject o = CannedMessages.SampleWorkItemsWithRelations;
            var firstItem = (JObject) o["value"].Value<JArray>()[0];
            JProperty property = firstItem.Properties().FirstOrDefault(p => p.Name == "relations");
            var array = (JArray) property.Value;
            json = array;
        }
    }
}