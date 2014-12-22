using System.Linq;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonLinkCollection_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JArray json)
        {
            JObject o = JObject.Parse(CannedMessages.JsonWorkItem217);
            JProperty property = o.Properties().FirstOrDefault(p => p.Name == "relations");
            var array = property.Value<JArray>();
            json = array;
        }
    }
}