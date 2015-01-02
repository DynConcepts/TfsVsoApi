using System;
using DynCon.OSI.DynTest;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.TFVC
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonVersionControlItem_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("url", "http://www.example.com"));
            jObject.Add(new JProperty("changeDate", DateTime.Today));
            jObject.Add(new JProperty("path", "The Path"));
            jObject.Add(new JProperty("isFolder", false));
            jObject.Add(new JProperty("version", 1));
            json = jObject;
        }
    }
}