using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.TFVC
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonShelveSet_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonShelveSet instance, ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("url", "http://www.example.com"));
            jObject.Add(new JProperty("id", 12345));
            jObject.Add(new JProperty("comment", "My Comment"));
            jObject.Add(new JProperty("createdDate", DateTime.Today));
            jObject.Add(new JProperty("name", "The Name"));
            jObject.Add(new JProperty("owner", "The Owner"));
            json = jObject;
        }

        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("url", "http://www.example.com"));
            jObject.Add(new JProperty("id", 12345));
            jObject.Add(new JProperty("comment", "My Comment"));
            jObject.Add(new JProperty("createdDate", DateTime.Today));
            jObject.Add(new JProperty("name", "The Name"));
            jObject.Add(new JProperty("owner", "The Owner"));
            json = jObject;
        }
    }
}