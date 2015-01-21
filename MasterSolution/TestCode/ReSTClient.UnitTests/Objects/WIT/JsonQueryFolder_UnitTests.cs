using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonQueryFolder_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(JsonQueryFolder instance, ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.SampleQueries);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }

        static partial void JsonSource(ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.SampleQueries);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }
    }
}