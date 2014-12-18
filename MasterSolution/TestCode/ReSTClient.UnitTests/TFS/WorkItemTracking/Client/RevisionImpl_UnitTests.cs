using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class RevisionImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
          JObject retVal = new JObject();
            retVal.Add("source", "Testing..Revisions.Source");
            var fields = new JObject();
            retVal.Add("fields", fields);
          json = retVal;
        }  
    }
}
