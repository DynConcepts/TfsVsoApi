using System;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.Build
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonBuildDefinition_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(JsonBuildDefinition instance, ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("url", "http://www.example.com"));
            jObject.Add(new JProperty("uri", "http://www.example.com"));
            jObject.Add(new JProperty("id", 12345));
            jObject.Add(new JProperty("batchSize", 1));
            jObject.Add(new JProperty("dateCreated", DateTime.Today));
            jObject.Add(new JProperty("lastBuild", DateTime.Today));
            jObject.Add(new JProperty("name", "The Name"));
            jObject.Add(new JProperty("buildArgs", "The Build Arguments"));
            jObject.Add(new JProperty("queue", "The Queue"));
            jObject.Add(new JProperty("description", "The Description"));
            jObject.Add(new JProperty("supportedReasons", "The Supported Reasons"));
            jObject.Add(new JProperty("definitionType", "The Definition Type"));
            jObject.Add(new JProperty("triggerType", "The Trigger Type"));
            jObject.Add(new JProperty("defaultDropLocation", "The Default Drop Location"));
            json = jObject;
        }

        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("url", "http://www.example.com"));
            jObject.Add(new JProperty("uri", "http://www.example.com"));
            jObject.Add(new JProperty("id", 12345));
            jObject.Add(new JProperty("batchSize", 1));
            jObject.Add(new JProperty("dateCreated", DateTime.Today));
            jObject.Add(new JProperty("lastBuild", DateTime.Today));
            jObject.Add(new JProperty("name", "The Name"));
            jObject.Add(new JProperty("buildArgs", "The Build Arguments"));
            jObject.Add(new JProperty("queue", "The Queue"));
            jObject.Add(new JProperty("description", "The Description"));
            jObject.Add(new JProperty("supportedReasons", "The Supported Reasons"));
            jObject.Add(new JProperty("definitionType", "The Definition Type"));
            jObject.Add(new JProperty("triggerType", "The Trigger Type"));
            jObject.Add(new JProperty("defaultDropLocation", "The Default Drop Location"));
            json = jObject;
        }
    }
}