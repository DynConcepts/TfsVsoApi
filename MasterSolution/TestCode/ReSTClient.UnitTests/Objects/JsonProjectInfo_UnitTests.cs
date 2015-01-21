using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonProjectInfo_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(JsonProjectInfo instance, ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("project", JsonProject_UnitTests.GetProjectJson()));
            jObject.Add(new JProperty("supportsTFVC", true));
            json = jObject;
        }

        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("project", JsonProject_UnitTests.GetProjectJson()));
            jObject.Add(new JProperty("supportsTFVC", true));
            json = jObject;
        }
    }
}