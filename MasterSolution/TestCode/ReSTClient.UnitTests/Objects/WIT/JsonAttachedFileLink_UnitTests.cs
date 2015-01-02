using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonAttachedFileLink_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonAttachedFileLink instance, ref JToken json)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();

            JObject jObject = CannedMessages.SampleWorkItemsWithRelations;
            JToken workItem = jObject["value"].Value<JArray>()[0];
            var relations = workItem["relations"].Value<JArray>();
            json = relations[2];
        }

        static partial void JsonSource(ref JToken json)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();

            JObject jObject = CannedMessages.SampleWorkItemsWithRelations;
            JToken workItem = jObject["value"].Value<JArray>()[0];
            var relations = workItem["relations"].Value<JArray>();
            json = relations[2];
        }
    }
}