using DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ExternalLinkImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
            JsonRelationType_UnitTests.PopulateLinkTypes();
            var retVal = new JObject();
            retVal.Add("rel", "ExternalLinkImpl.Rel");
            json = retVal;
        }
    }
}