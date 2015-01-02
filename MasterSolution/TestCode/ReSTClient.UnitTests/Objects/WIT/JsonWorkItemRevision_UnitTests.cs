using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItemRevision_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            JObject o = CannedMessages.SampleWorkItemsWithRelations;
            var firstItem = (JObject) o["value"].Value<JArray>()[0];
            json = firstItem;
        }
    }
}