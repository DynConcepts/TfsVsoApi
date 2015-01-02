using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonQueryFolder_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref JsonQueryFolder instance, string callerName)
        {
            JObject jobject = JObject.Parse(CannedMessages.SampleQueries);
            var array = jobject["value"].Value<JArray>();
            JToken token = array[0];
            instance = JsonQueryFolder.FromToken(token);
        }
    }
}