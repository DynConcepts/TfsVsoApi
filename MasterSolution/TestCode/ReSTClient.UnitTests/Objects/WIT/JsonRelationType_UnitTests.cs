using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonRelationType_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.JsonRelationTypes);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }
    }
}