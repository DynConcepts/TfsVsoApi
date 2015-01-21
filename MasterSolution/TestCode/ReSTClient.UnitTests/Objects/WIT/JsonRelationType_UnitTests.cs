using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonRelationType_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Populates the link types.
        /// </summary>
        public static void PopulateLinkTypes()
        {
            if (JsonLink.PreLoadedTypes != null)
                return;
            JObject jobject = JObject.Parse(CannedMessages.JsonRelationTypes);
            var array = jobject["value"].Value<JArray>();
            var preLoadedTypes = new Dictionary<string, JsonRelationType>();
            foreach (JToken element in array)
            {
                JsonRelationType item = JsonRelationType.FromToken(element);
                preLoadedTypes.Add(item.ReferenceName, item);
            }
            JsonLink.PreLoadedTypes = preLoadedTypes;
        }

        partial void FromToken_PreCondition(JsonRelationType instance, ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.JsonRelationTypes);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }

        static partial void JsonSource(ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.JsonRelationTypes);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }
    }
}