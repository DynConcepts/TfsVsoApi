using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonHyperlink_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref JsonHyperlink instance, string callerName)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();

            JObject jObject = CannedMessages.SampleWorkItemsWithRelations;
            JToken workItem = jObject["value"].Value<JArray>()[1];
            var relations = workItem["relations"].Value<JArray>();
            JToken token = relations[2];
            instance = JsonHyperlink.FromToken(token);
        }
    }
}