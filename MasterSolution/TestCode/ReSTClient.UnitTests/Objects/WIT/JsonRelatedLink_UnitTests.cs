using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonRelatedLink_UnitTests : DynTestClassBase
    {
        static partial void JsonSource(ref JToken json)
        {
            string src =
                @"{
  ""id"": 141,
  ""rev"": 1,
  ""fields"": {
    ""System.AreaPath"": ""RestPlaypen"",
    ""System.TeamProject"": ""RestPlaypen"",
    ""System.IterationPath"": ""RestPlaypen"",
    ""System.WorkItemType"": ""Task"",
    ""System.State"": ""New"",
    ""System.Reason"": ""New"",
    ""System.CreatedDate"": ""2014-11-24T19:55:05.557Z"",
    ""System.CreatedBy"": ""David V. Corbin <david.corbin@live.com>"",
    ""System.ChangedDate"": ""2014-11-24T19:55:05.557Z"",
    ""System.ChangedBy"": ""David V. Corbin <david.corbin@live.com>"",
    ""System.Title"": ""Sample Title"",
    ""Microsoft.VSTS.Common.StateChangeDate"": ""2014-11-24T19:55:05.557Z"",
    ""Microsoft.VSTS.Common.Priority"": 2
  },
  ""_links"": {
    ""self"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/141/revisions/1""
    },
    ""workItemRevisions"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/141/revisions""
    },
    ""parent"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/141""
    }
  },
  ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/141/revisions/1""
}";
            JObject jobject = JObject.Parse(src);
            var array = jobject["relations"].Value<JArray>();
            json = array[0];
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "RelatedWorkITemId_UnitTest"
        };
    }
}