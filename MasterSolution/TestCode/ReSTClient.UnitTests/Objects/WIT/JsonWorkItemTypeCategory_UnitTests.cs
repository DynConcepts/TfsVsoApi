using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonWorkItemTypeCategory_UnitTests : DynTestClassBase
    {
        partial void FromToken_PreCondition(ref JsonWorkItemTypeCategory instance, ref JToken json) { json = JsonSource(); }
        static partial void InstanceFactory(ref JsonWorkItemTypeCategory instance, string callerName) { instance = JsonWorkItemTypeCategory.FromToken(JsonSource()); }

        private static JObject JsonSource()
        {
            string src =
                @"{
  ""count"": 14,
  ""value"": [
    {
      ""name"": ""Bug Category"",
      ""referenceName"": ""Microsoft.BugCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Bug"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Bug""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Bug"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Bug""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.BugCategory""
    },
    {
      ""name"": ""Feature Category"",
      ""referenceName"": ""Microsoft.FeatureCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Feature"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feature""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Feature"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feature""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.FeatureCategory""
    },
    {
      ""name"": ""Requirement Category"",
      ""referenceName"": ""Microsoft.RequirementCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""User Story"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/User%20Story""
      },
      ""workItemTypes"": [
        {
          ""name"": ""User Story"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/User%20Story""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.RequirementCategory""
    },
    {
      ""name"": ""Test Case Category"",
      ""referenceName"": ""Microsoft.TestCaseCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Test Case"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Case""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Test Case"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Case""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.TestCaseCategory""
    },
    {
      ""name"": ""Shared Step Category"",
      ""referenceName"": ""Microsoft.SharedStepCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Shared Steps"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Shared%20Steps""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Shared Steps"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Shared%20Steps""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.SharedStepCategory""
    },
    {
      ""name"": ""Shared Parameter Category"",
      ""referenceName"": ""Microsoft.SharedParameterCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Shared Parameter"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Shared%20Parameter""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Shared Parameter"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Shared%20Parameter""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.SharedParameterCategory""
    },
    {
      ""name"": ""Test Plan Category"",
      ""referenceName"": ""Microsoft.TestPlanCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Test Plan"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Plan""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Test Plan"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Plan""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.TestPlanCategory""
    },
    {
      ""name"": ""Task Category"",
      ""referenceName"": ""Microsoft.TaskCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Task"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Task""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Task"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Task""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.TaskCategory""
    },
    {
      ""name"": ""Test Suite Category"",
      ""referenceName"": ""Microsoft.TestSuiteCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Test Suite"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Suite""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Test Suite"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Suite""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.TestSuiteCategory""
    },
    {
      ""name"": ""Hidden Types Category"",
      ""referenceName"": ""Microsoft.HiddenCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Code Review Request"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Request""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Test Plan"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Plan""
        },
        {
          ""name"": ""Shared Steps"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Shared%20Steps""
        },
        {
          ""name"": ""Shared Parameter"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Shared%20Parameter""
        },
        {
          ""name"": ""Test Suite"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Test%20Suite""
        },
        {
          ""name"": ""Code Review Request"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Request""
        },
        {
          ""name"": ""Code Review Response"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Response""
        },
        {
          ""name"": ""Feedback Request"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feedback%20Request""
        },
        {
          ""name"": ""Feedback Response"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feedback%20Response""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.HiddenCategory""
    },
    {
      ""name"": ""Code Review Request Category"",
      ""referenceName"": ""Microsoft.CodeReviewRequestCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Code Review Request"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Request""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Code Review Request"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Request""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.CodeReviewRequestCategory""
    },
    {
      ""name"": ""Code Review Response Category"",
      ""referenceName"": ""Microsoft.CodeReviewResponseCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Code Review Response"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Response""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Code Review Response"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Code%20Review%20Response""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.CodeReviewResponseCategory""
    },
    {
      ""name"": ""Feedback Request Category"",
      ""referenceName"": ""Microsoft.FeedbackRequestCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Feedback Request"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feedback%20Request""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Feedback Request"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feedback%20Request""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.FeedbackRequestCategory""
    },
    {
      ""name"": ""Feedback Response Category"",
      ""referenceName"": ""Microsoft.FeedbackResponseCategory"",
      ""defaultWorkItemType"": {
        ""name"": ""Feedback Response"",
        ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feedback%20Response""
      },
      ""workItemTypes"": [
        {
          ""name"": ""Feedback Response"",
          ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypes/Feedback%20Response""
        }
      ],
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5/_apis/wit/workItemTypeCategories/Microsoft.FeedbackResponseCategory""
    }
  ]
}";
            JObject jobject = JObject.Parse(src);
            var array = jobject["value"].Value<JArray>();
            return (JObject) array[0];
        }
    }
}