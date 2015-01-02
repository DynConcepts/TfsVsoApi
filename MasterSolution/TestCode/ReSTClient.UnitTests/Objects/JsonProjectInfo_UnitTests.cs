using DynCon.OSI.DynTest;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonProjectInfo_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("project", JsonProject_UnitTests.GetProjectJson()));
            jObject.Add(new JProperty("supportsTFVC", true));
            json = jObject;
        }
    }
}