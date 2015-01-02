using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonFieldDefinition_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json) { json = JObject.Parse(CannedMessages.SampleWorkItemsFieldDefinition); }
    }
}