using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonQueryDefinition_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonQueryDefinition instance, ref JToken json) { json = JObject.Parse(CannedMessages.SampleQueryDefinition); }

        static partial void InstanceFactory(ref JsonQueryDefinition instance, string callerName)
        {
            JObject jobject = JObject.Parse(CannedMessages.SampleQueryDefinition);
            instance = JsonQueryDefinition.FromToken(jobject);
        }
    }
}