using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class LinkImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
            var retVal = new JObject();
            retVal.Add("source", "Testing..Link.ReferenceName");
            retVal.Add("rel", "Testing..Link.Rel");
            json = retVal;
        }
    }
}