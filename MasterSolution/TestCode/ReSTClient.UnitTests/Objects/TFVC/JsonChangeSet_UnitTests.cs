using System;
using DynCon.OSI.DynTest;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.TFVC
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonChangeSet_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("url", "http://www.example.com"));
            jObject.Add(new JProperty("comment", "My Comment"));
            jObject.Add(new JProperty("createdDate", DateTime.Today));
            jObject.Add(new JProperty("author", "The Author"));
            jObject.Add(new JProperty("changesetId", 12345));
            jObject.Add(new JProperty("checkedInBy", "Checked In By"));
            json = jObject;
        }
    }
}