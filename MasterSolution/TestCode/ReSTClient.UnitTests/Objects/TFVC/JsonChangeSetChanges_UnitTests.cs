using DynCon.OSI.DynTest;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.TFVC
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonChangeSetChanges_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("changeType", "The Change Type"));
            json = jObject;
        }
    }
}