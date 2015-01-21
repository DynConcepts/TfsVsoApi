using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class FieldDefinitionCollectionImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
            var retVal = new JArray();
            JToken item = FieldDefinitionImpl_UnitTests.GetInstance().JsonValue;
            retVal.Add(item);
            json = retVal;
        }
    }
}