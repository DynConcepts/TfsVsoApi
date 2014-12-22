using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonProject_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            JObject jobject = JObject.Parse(CannedMessages.JsonProjects);
            var array = jobject["value"].Value<JArray>();
            json = array[0];
        }
    }
}