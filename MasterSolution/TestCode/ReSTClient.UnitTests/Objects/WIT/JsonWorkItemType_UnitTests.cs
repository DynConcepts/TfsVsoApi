using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItemType_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref JsonWorkItemType instance, string callerName)
        {
            JObject token = JObject.Parse(CannedMessages.SampleWorkItemType);
            instance = JsonWorkItemType.FromToken(token);
        }
    }
}