using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonLink_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();

            JObject jObject = CannedMessages.SampleWorkItemsWithRelations;
            JToken workItem = jObject["value"].Value<JArray>()[1];
            var relations = workItem["relations"].Value<JArray>();
            json = relations[2];
        }
    }
}