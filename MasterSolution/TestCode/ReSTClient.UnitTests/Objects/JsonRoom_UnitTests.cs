using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonRoom_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonRoom instance, ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("id", 12345));
            jObject.Add(new JProperty("createdDate", DateTime.Today));
            jObject.Add(new JProperty("createdBy", "Me!"));
            jObject.Add(new JProperty("description", "Room Description"));
            jObject.Add(new JProperty("name", "Room Name"));
            jObject.Add(new JProperty("lastActivity", DateTime.Today));
            jObject.Add(new JProperty("hasAdminPermissions", false));
            jObject.Add(new JProperty("hasReadWritePermissions", false));
            json = jObject;
        }

        static partial void JsonSource(ref JToken json)
        {
            var jObject = new JObject();
            jObject.Add(new JProperty("id", 12345));
            jObject.Add(new JProperty("createdDate", DateTime.Today));
            jObject.Add(new JProperty("createdBy", "Me!"));
            jObject.Add(new JProperty("description", "Room Description"));
            jObject.Add(new JProperty("name", "Room Name"));
            jObject.Add(new JProperty("lastActivity", DateTime.Today));
            jObject.Add(new JProperty("hasAdminPermissions", false));
            jObject.Add(new JProperty("hasReadWritePermissions", false));
            json = jObject;
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "RunRevisionQuery_UnitTest"
        };
    }
}