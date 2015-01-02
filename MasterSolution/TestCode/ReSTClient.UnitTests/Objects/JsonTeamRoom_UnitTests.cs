using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonTeamRoom_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonTeamRoom instance, ref JToken json) { json = JObject.Parse(CannedMessages.JsonTeamRoom); }
        static partial void JsonSource(ref JToken json) { json = JObject.Parse(CannedMessages.JsonTeamRoom); }
    }
}