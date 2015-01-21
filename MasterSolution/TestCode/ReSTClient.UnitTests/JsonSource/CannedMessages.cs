using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource
{
    internal class CannedMessages
    {
        public static JObject SampleWorkItemsWithRelations { get { return GetJsonResponseBody("DynCon.OSI.VSO.ReSTClient.UnitTests.JsonSource.wit.wit.workItems.GET__wit_workitems_ids-_ids___expand-all.json"); } }
        public static JObject SampleBuilds { get { return GetJsonResponseBody("DynCon.OSI.VSO.ReSTClient.UnitTests.JsonSource.build.builds.GET__build_builds.json"); } }
        public static JObject SampleBuildRequests { get { return GetJsonResponseBody("DynCon.OSI.VSO.ReSTClient.UnitTests.JsonSource.build.requests.GET__build_requests.json"); } }
        public static JObject SampleBuildQueues { get { return GetJsonResponseBody("DynCon.OSI.VSO.ReSTClient.UnitTests.JsonSource.build.queues.GET__build_queues.json"); } }
        public static JObject BuildQualities { get { return GetJsonResponseBody("DynCon.OSI.VSO.ReSTClient.UnitTests.JsonSource.build.qualities.GET__build_qualities.json"); } }

        public static List<String> GetResources()
        {
            var retVal = new List<String>();
            Assembly assembly = Assembly.GetExecutingAssembly();
            retVal.AddRange(assembly.GetManifestResourceNames());
            return retVal;
        }

        private static JObject GetJson(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                var reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                JObject jObject = JObject.Parse(content);
                return jObject;
            }
        }

        public class RequestInfo
        {

            public RequestInfo(string source, string resourceFormat, string requestUrl, string method)
            {
                Method = method;
                Source = source;
                ResourceFormat = resourceFormat;
                RequestUrl = requestUrl;
            }

            public string Source { get; set; }
            public string ResourceFormat { get; set; }
            public string RequestUrl { get; set; }

            public string Method { get; set; }
        }
        public static RequestInfo GetResourceFormat(string resourceName)
        {
            JObject root = GetJson(resourceName);
            var resourceFormat= root["resourceFormat"].Value<String>();
            var requestUrl =root["requestUrl"].Value<String>();
            var method =root["method"].Value<String>();
            var retVal = new RequestInfo(resourceName, resourceFormat, requestUrl, method);
            return retVal;
        }

        private static JObject GetJsonResponseBody(string resourceName)
        {
            JObject root = GetJson(resourceName);
            return root["responseBody"].Value<JObject>();
        }

        public const string AvailableRestCalls =
            @"{
""count"": 184,
""value"":[
  {
    ""id"": ""00d9565f-ed9c-4a06-9a50-00e7896ccab4"",
    ""area"": ""Location"",
    ""resourceName"": ""ConnectionData"",
    ""routeTemplate"": ""_apis/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""d810a47d-f4f4-4a62-a03f-fa1860585c4c"",
    ""area"": ""Location"",
    ""resourceName"": ""ServiceDefinitions"",
    ""routeTemplate"": ""_apis/{resource}/{serviceType}/{identifier}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""64d1cee1-a587-461d-9bd8-1ed63190635b"",
    ""area"": ""agile"",
    ""resourceName"": ""backlogs"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""5ead0b70-2572-4697-97e9-f341069a783a"",
    ""area"": ""core"",
    ""resourceName"": ""identityMru"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{mruName}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""e4f5c81e-e250-447b-9fef-bd48471bea5e"",
    ""area"": ""Container"",
    ""resourceName"": ""Containers"",
    ""routeTemplate"": ""_apis/resources/{resource}/{containerId}/{*itemPath}"",
    ""resourceVersion"": 3,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""294c494c-2600-4d7e-b76c-3dd50c3c95be"",
    ""area"": ""core"",
    ""resourceName"": ""members"",
    ""routeTemplate"": ""_apis/projects/{projectId}/teams/{teamId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""d30a3dd1-f8ba-442a-b86a-bd0c0c383e59"",
    ""area"": ""core"",
    ""resourceName"": ""teams"",
    ""routeTemplate"": ""_apis/projects/{projectId}/{resource}/{*teamId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""b4f70219-e18b-42c5-abe3-98b07d35525e"",
    ""area"": ""core"",
    ""resourceName"": ""connectedServices"",
    ""routeTemplate"": ""_apis/projects/{projectId}/{resource}/{name}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""ec1f4311-f2b4-4c15-b2b8-8990b80d2908"",
    ""area"": ""core"",
    ""resourceName"": ""proxies"",
    ""routeTemplate"": ""_apis/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""603fe2ac-9723-48b9-88ad-09305aa6c6e1"",
    ""area"": ""core"",
    ""resourceName"": ""projects"",
    ""routeTemplate"": ""_apis/{resource}/{*projectId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""b4b570ef-1775-4093-9218-afb7e4c8aef6"",
    ""area"": ""properties"",
    ""resourceName"": ""properties"",
    ""routeTemplate"": ""_apis/{resource}/{id}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""cf333e53-8825-4d68-8877-6eeb6bf98e2d"",
    ""area"": ""Tagging"",
    ""resourceName"": ""tags"",
    ""routeTemplate"": ""_apis/{area}/scopes/{scopeId}/{resource}/{tagId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7985e151-1f22-4344-9173-1a663ee1eb4d"",
    ""area"": ""Build"",
    ""resourceName"": ""Deployments"",
    ""routeTemplate"": ""_apis/build/azure/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""2f00bd4f-422d-417c-b429-f588ded6486f"",
    ""area"": ""Build"",
    ""resourceName"": ""DeploymentDefinitions"",
    ""routeTemplate"": ""_apis/build/azure/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""0cd358e1-9217-4d94-8269-1c1ee6f93dcf"",
    ""area"": ""Build"",
    ""resourceName"": ""Builds"",
    ""routeTemplate"": ""{project}/_apis/build/{resource}/{buildId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""dbeaf647-6167-421a-bda9-c9327b25e2e6"",
    ""area"": ""Build"",
    ""resourceName"": ""Definitions"",
    ""routeTemplate"": ""{project}/_apis/build/{resource}/{definitionId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""9f094d42-b41c-4920-95aa-597581a79821"",
    ""area"": ""Build"",
    ""resourceName"": ""Details"",
    ""routeTemplate"": ""{project}/_apis/build/Builds/{buildId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""09f2a4b8-08c9-4991-85c3-d698937568be"",
    ""area"": ""Build"",
    ""resourceName"": ""Queues"",
    ""routeTemplate"": ""_apis/build/{resource}/{controllerId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""de3e9770-c7ef-4697-983e-f4b5bab3c016"",
    ""area"": ""Build"",
    ""resourceName"": ""Requests"",
    ""routeTemplate"": ""{project}/_apis/build/{resource}/{requestId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""82fba9f8-4198-4ab6-b719-6a363880c19e"",
    ""area"": ""Build"",
    ""resourceName"": ""Qualities"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{quality}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""591cb5a4-2d46-4f3a-a697-5cd42b6bd332"",
    ""area"": ""build"",
    ""resourceName"": ""options"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""1db06c96-014e-44e1-ac91-90b2d4b3e984"",
    ""area"": ""build"",
    ""resourceName"": ""artifacts"",
    ""routeTemplate"": ""_apis/{area}/builds/{buildId}/{resource}/{artifactName}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""54572c7b-bbd3-45d4-80dc-28be08941620"",
    ""area"": ""build"",
    ""resourceName"": ""commits"",
    ""routeTemplate"": ""{project}/_apis/{area}/builds/{buildId}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""35a80daf-7f30-45fc-86e8-6b813d9c90df"",
    ""area"": ""build"",
    ""resourceName"": ""logs"",
    ""routeTemplate"": ""{project}/_apis/{area}/builds/{buildId}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""d84ac5c6-edc7-43d5-adc9-1b34be5dea09"",
    ""area"": ""build"",
    ""resourceName"": ""tags"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""6e6114b2-8161-44c8-8f6c-c5505782427f"",
    ""area"": ""build"",
    ""resourceName"": ""tags"",
    ""routeTemplate"": ""{project}/_apis/{area}/builds/{buildId}/{resource}/{tag}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""e884571e-7f92-4d6a-9274-3f5649900835"",
    ""area"": ""build"",
    ""resourceName"": ""templates"",
    ""routeTemplate"": ""{project}/_apis/{area}/definitions/{resource}/{templateId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7c116775-52e5-453e-8c5d-914d9762d8c4"",
    ""area"": ""build"",
    ""resourceName"": ""revisions"",
    ""routeTemplate"": ""_apis/{area}/definitions/{definitionId}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""2.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""01408881-1a9a-4cc9-981d-9333e354e9d9"",
    ""area"": ""Chat"",
    ""resourceName"": ""Users"",
    ""routeTemplate"": ""_apis/{area}/{parentresource}/{roomId}/{resource}/{userId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""7d11c820-4bdc-4bca-8957-9d74e32cdd20"",
    ""area"": ""Chat"",
    ""resourceName"": ""Messages"",
    ""routeTemplate"": ""_apis/{area}/{parentresource}/{roomId}/{resource}/{messageId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""3d0e7ee0-a6c9-497e-9a2c-23b687e860e2"",
    ""area"": ""Chat"",
    ""resourceName"": ""Rooms"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{roomId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""81f2ae10-f9f2-4008-b40a-c3ac826050d4"",
    ""area"": ""codelens"",
    ""resourceName"": ""filedetails"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 3,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""347d49f3-3e68-4f0f-a82a-df4ce88999d7"",
    ""area"": ""codelens"",
    ""resourceName"": ""filesummaries"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 3,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""a50ddbe2-1a1d-4c55-857f-73c6a3a31722"",
    ""area"": ""discussion"",
    ""resourceName"": ""threads"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""010054f6-d9ed-4ed2-855f-7f86bff10c02"",
    ""area"": ""discussion"",
    ""resourceName"": ""threads"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{discussionId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""255a0b5e-3c2f-43c2-a688-36c878210ba2"",
    ""area"": ""discussion"",
    ""resourceName"": ""threadsBatch"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""20933fc0-b6a7-4a57-8111-a7458da5441b"",
    ""area"": ""discussion"",
    ""resourceName"": ""comments"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""495211bd-b463-4578-86fe-924ea4953693"",
    ""area"": ""discussion"",
    ""resourceName"": ""comments"",
    ""routeTemplate"": ""_apis/{area}/threads/{discussionId}/{resource}/{commentId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""f8d10759-6e90-48bc-96b0-d19440116797"",
    ""area"": ""distributedtask"",
    ""resourceName"": ""plans"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{planId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""ffe38397-3a9d-4ca6-b06d-49303f287ba5"",
    ""area"": ""distributedtask"",
    ""resourceName"": ""timelines"",
    ""routeTemplate"": ""_apis/{area}/plans/{planId}/{resource}/{timelineId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""50170d5d-f122-492f-9816-e2ef9f8d1756"",
    ""area"": ""distributedtask"",
    ""resourceName"": ""records"",
    ""routeTemplate"": ""_apis/{area}/plans/{planId}/timelines/{timelineId}/{resource}/{recordId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""9ae056f6-d4e4-4d0c-bd26-aee2a22f01f2"",
    ""area"": ""distributedtask"",
    ""resourceName"": ""feed"",
    ""routeTemplate"": ""_apis/{area}/plans/{planId}/timelines/{timelineId}/records/{recordId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""15344176-9e77-4cf4-a7c3-8bc4d0a3c4eb"",
    ""area"": ""distributedtask"",
    ""resourceName"": ""logs"",
    ""routeTemplate"": ""_apis/{area}/plans/{planId}/{resource}/{logId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""5f1e0bb7-84a9-43d3-b1ae-a2f241c6f01a"",
    ""area"": ""distributedtask"",
    ""resourceName"": ""index"",
    ""routeTemplate"": ""_apis/{area}/plans/{planId}/logs/{logId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""225f7195-f9c7-4d14-ab28-a83f7ff77e1f"",
    ""area"": ""git"",
    ""resourceName"": ""repositories"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{repositoryId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""88aea7e8-9501-45dd-ac58-b069aa73b926"",
    ""area"": ""git"",
    ""resourceName"": ""repositories"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/{resource}/{repositoryId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""2d874a60-a811-4f62-9c9f-963a6ea0a55b"",
    ""area"": ""git"",
    ""resourceName"": ""refs"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{*refType}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""4c36aadb-af42-45bb-80ca-6df5cd443e0d"",
    ""area"": ""git"",
    ""resourceName"": ""refs"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{*refType}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""d5b216de-d8d5-4d32-ae76-51df755b16d3"",
    ""area"": ""git"",
    ""resourceName"": ""branchStats"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/stats/branches"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""b32dc299-abe2-41e9-bd15-1e6856b95c9c"",
    ""area"": ""git"",
    ""resourceName"": ""branchStats"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/stats/branches"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""40c1f5b7-2bb6-4c28-b844-0f47cd6bb610"",
    ""area"": ""git"",
    ""resourceName"": ""branchStats"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/stats/branches/{name}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""9b2552e4-9e48-4557-98ec-1982f699615f"",
    ""area"": ""git"",
    ""resourceName"": ""branchStats"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/stats/branches/{name}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""5bf884f5-3e07-42e9-afb8-1b872267bf16"",
    ""area"": ""git"",
    ""resourceName"": ""changes"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/commits/{commitId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""074db773-d674-4de9-a0dd-fcb6adddecf9"",
    ""area"": ""git"",
    ""resourceName"": ""changes"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/commits/{commitId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""c2570c3b-5b3f-41b8-98bf-5407bfde8d58"",
    ""area"": ""git"",
    ""resourceName"": ""commits"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{commitId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""41a3de30-8d9e-4f79-a7e3-ef8cf1299454"",
    ""area"": ""git"",
    ""resourceName"": ""commits"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{commitId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""6400dfb2-0bcb-462b-b992-5a57f8f1416c"",
    ""area"": ""git"",
    ""resourceName"": ""commitsBatch"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""fed1587d-f1c8-475d-925c-b97f2c9dde50"",
    ""area"": ""git"",
    ""resourceName"": ""commitsBatch"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""168b4bb9-d936-4cd9-8a5f-66d6f6b23192"",
    ""area"": ""git"",
    ""resourceName"": ""commits"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/pushes/{pushId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""cc7a4cb0-7377-494a-80d4-ef4d607f6eb2"",
    ""area"": ""git"",
    ""resourceName"": ""commits"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/pushes/{pushId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""ea98d07b-3c87-4971-8ede-a613694ffb55"",
    ""area"": ""git"",
    ""resourceName"": ""pushes"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{pushId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""9777557b-f5a5-4a6b-94f8-39aff53b5b41"",
    ""area"": ""git"",
    ""resourceName"": ""pushes"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{pushId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""fb93c0db-47ed-4a31-8c20-47552878fb44"",
    ""area"": ""git"",
    ""resourceName"": ""items"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{*path}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""433ab753-6ed9-4169-9841-dd3f7611834a"",
    ""area"": ""git"",
    ""resourceName"": ""items"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{*path}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""630fd2e4-fb88-4f85-ad21-13f3fd1fbca9"",
    ""area"": ""git"",
    ""resourceName"": ""itemsBatch"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""567ef866-886b-44cc-81e2-6cc075905ce5"",
    ""area"": ""git"",
    ""resourceName"": ""itemsBatch"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""729f6437-6f92-44ec-8bee-273a7111063c"",
    ""area"": ""git"",
    ""resourceName"": ""trees"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{sha1}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""11e0a184-7e28-4b77-9523-1d4d6dc29241"",
    ""area"": ""git"",
    ""resourceName"": ""trees"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{sha1}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7b28e929-2c99-405d-9c5c-6167a06e6816"",
    ""area"": ""git"",
    ""resourceName"": ""blobs"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{sha1}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""cffac033-c2f1-41a2-acb3-b765e50a8d29"",
    ""area"": ""git"",
    ""resourceName"": ""blobs"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{sha1}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""615588d5-c0c7-4b88-88f8-e625306446e8"",
    ""area"": ""git"",
    ""resourceName"": ""commitDiffs"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/diffs/commits"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""29ba9926-be39-4db5-bbdf-d6c9458195c6"",
    ""area"": ""git"",
    ""resourceName"": ""commitDiffs"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/diffs/commits"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""0a637fcc-5370-4ce8-b0e8-98091f5f9482"",
    ""area"": ""git"",
    ""resourceName"": ""pullRequestWorkItems"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/pullRequests/{pullRequestId}/workitems"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""a92ec66c-5851-41a4-a96b-4a0860958844"",
    ""area"": ""git"",
    ""resourceName"": ""pullRequestWorkItems"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}/workitems"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""4b6702c7-aa35-4b89-9c96-b9abf6d3e540"",
    ""area"": ""git"",
    ""resourceName"": ""pullRequestReviewers"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{reviewerId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""1d5702f2-90e2-4fe0-8794-4fcd822adb9b"",
    ""area"": ""git"",
    ""resourceName"": ""pullRequestReviewers"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/pullRequests/{pullRequestId}/reviewers/{reviewerId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""9946fd70-0d40-406e-b686-b4744cbbcc37"",
    ""area"": ""git"",
    ""resourceName"": ""pullRequests"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{pullRequestId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""5318bf6c-115f-4828-ba3e-73eca825c276"",
    ""area"": ""git"",
    ""resourceName"": ""pullRequests"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{pullRequestId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""33645b30-4853-4236-ab87-ffed6ea1b5d5"",
    ""area"": ""git"",
    ""resourceName"": ""objects"",
    ""routeTemplate"": ""{project}/_apis/{area}/repositories/{repositoryId}/{resource}/{mediaObjectId}/{*includeLinks}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""c96a81cd-52f6-41d9-843c-58c584967ba5"",
    ""area"": ""git"",
    ""resourceName"": ""objects"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/repositories/{repositoryId}/{resource}/{mediaObjectId}/{*includeLinks}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7817faca-c438-430b-9f1e-ddb3cd935fed"",
    ""area"": ""Packaging"",
    ""resourceName"": ""Modules"",
    ""routeTemplate"": ""_apis/{area}/stores/{storeId}/{resource}/{moduleId}/{moduleVersion}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""8533f035-4ebc-4222-96d3-22224aed6170"",
    ""area"": ""Packaging"",
    ""resourceName"": ""ArtifactBatch"",
    ""routeTemplate"": ""_apis/{area}/stores/{storeId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""017e0eb6-5117-4180-a461-9169054c05c7"",
    ""area"": ""Packaging"",
    ""resourceName"": ""Artifacts"",
    ""routeTemplate"": ""_apis/{area}/stores/{storeId}/{resource}/{moduleId}/{moduleVersion}/{*artifactId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""b7c2d651-0472-424f-903f-0e1eba615119"",
    ""area"": ""Packaging"",
    ""resourceName"": ""ModuleBatch"",
    ""routeTemplate"": ""_apis/{area}/stores/{storeId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""d5d419e1-1a96-4d81-ac44-f87440b3ef78"",
    ""area"": ""Packaging"",
    ""resourceName"": ""Lineups"",
    ""routeTemplate"": ""_apis/{area}/stores/{storeId}/{resource}/{lineupId}/{lineupVersion}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""1d5a36c4-db96-4afb-845e-4434c131f7b9"",
    ""area"": ""Packaging"",
    ""resourceName"": ""LineupBatch"",
    ""routeTemplate"": ""_apis/{area}/stores/{storeId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""e971465f-5194-4ea7-9d42-773696ff38d6"",
    ""area"": ""Packaging"",
    ""resourceName"": ""Stores"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""44096322-2d3d-466a-bb30-d1b7de69f61f"",
    ""area"": ""policy"",
    ""resourceName"": ""types"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{typeId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""dad91cbe-d183-45f8-9c6e-9c1164472121"",
    ""area"": ""policy"",
    ""resourceName"": ""configurations"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/{resource}/{configurationId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""fe1e68a2-60d3-43cb-855b-85e41ae97c95"",
    ""area"": ""policy"",
    ""resourceName"": ""versions"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/configurations/{configurationId}/{resource}/{versionId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""65a595c7-de54-419b-8627-04b81c3fd9e9"",
    ""area"": ""policy"",
    ""resourceName"": ""evaluations"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/configurations/{configurationId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""c23ddff5-229c-4d04-a80b-0fdce9f360c8"",
    ""area"": ""policy"",
    ""resourceName"": ""evaluations"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""71ec2b57-742e-4c12-8bd3-ef633b473f65"",
    ""area"": ""Reporting"",
    ""resourceName"": ""ChartConfiguration"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""81aa1f62-c70d-4356-ba6b-d8ee4be4379c"",
    ""area"": ""Reporting"",
    ""resourceName"": ""DataServiceCapabilities"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{scope}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""71ec2b57-742e-4c12-8bd3-ef633b473f66"",
    ""area"": ""Reporting"",
    ""resourceName"": ""TransformQuery"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{scope}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""db4777cd-8e08-4a84-8ba3-c974ea033718"",
    ""area"": ""hooks"",
    ""resourceName"": ""eventTypes"",
    ""routeTemplate"": ""_apis/{area}/publishers/{publisherId}/{resource}/{eventTypeId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""1e83a210-5b53-43bc-90f0-d476a4e5d731"",
    ""area"": ""hooks"",
    ""resourceName"": ""publishers"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{publisherId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""c3428e90-7a69-4194-8ed8-0f153185ee0d"",
    ""area"": ""hooks"",
    ""resourceName"": ""actions"",
    ""routeTemplate"": ""_apis/{area}/consumers/{consumerId}/{resource}/{consumerActionId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""4301c514-5f34-4f5d-a145-f0ea7b5b7d19"",
    ""area"": ""hooks"",
    ""resourceName"": ""consumers"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{consumerId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""0c62d343-21b0-4732-997b-017fde84dc28"",
    ""area"": ""hooks"",
    ""resourceName"": ""notifications"",
    ""routeTemplate"": ""_apis/{area}/subscriptions/{subscriptionId}/{resource}/{notificationId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""1139462c-7e27-4524-a997-31b9b73551fe"",
    ""area"": ""hooks"",
    ""resourceName"": ""testNotifications"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{notificationId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""fc50d02a-849f-41fb-8af1-0a5216103269"",
    ""area"": ""hooks"",
    ""resourceName"": ""subscriptions"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{subscriptionId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""99b44a8a-65a8-4670-8f3e-e7f7842cce64"",
    ""area"": ""hooks"",
    ""resourceName"": ""publishersQuery"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""c7c3c1cf-9e05-4c0d-a425-a0f922c2c6ed"",
    ""area"": ""hooks"",
    ""resourceName"": ""subscriptionsQuery"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""1a57562f-160a-4b5c-9185-905e95b39d36"",
    ""area"": ""hooks"",
    ""resourceName"": ""notificationsQuery"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""140ed26d-ed51-4583-a1bd-0dd3fdd708bd"",
    ""area"": ""hooks"",
    ""resourceName"": ""inputValuesQuery"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""72493ce2-021d-42c4-a9c9-e60d3335d27f"",
    ""area"": ""Test"",
    ""resourceName"": ""Plans"",
    ""routeTemplate"": ""_apis/test/{projectId}/{resource}/{planId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""51712106-7278-4208-8563-1c96f40cf5e4"",
    ""area"": ""Test"",
    ""resourceName"": ""Plans"",
    ""routeTemplate"": ""{project}/_apis/test/{resource}/{planId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""3ecbe2f1-c419-4d6c-be9e-d2919bc7e581"",
    ""area"": ""Test"",
    ""resourceName"": ""Points"",
    ""routeTemplate"": ""_apis/test/{projectId}/Plans/{planId}/Suites/{suiteId}/{resource}/{pointIds}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""3bcfd5c8-be62-488e-b1da-b8289ce9299c"",
    ""area"": ""Test"",
    ""resourceName"": ""Points"",
    ""routeTemplate"": ""{project}/_apis/test/Plans/{planId}/Suites/{suiteId}/{resource}/{pointIds}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""82243633-baf3-423d-8cbd-b272a469febe"",
    ""area"": ""Test"",
    ""resourceName"": ""Suites"",
    ""routeTemplate"": ""_apis/test/{projectId}/Plans/{planId}/{resource}/{suiteId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7b7619a0-cb54-4ab3-bf22-194056f45dd1"",
    ""area"": ""Test"",
    ""resourceName"": ""Suites"",
    ""routeTemplate"": ""{project}/_apis/test/Plans/{planId}/{resource}/{suiteId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""09a6167b-e969-4775-9247-b94cf3819caf"",
    ""area"": ""Test"",
    ""resourceName"": ""Suites"",
    ""routeTemplate"": ""_apis/test/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""f91d0d0b-e292-4132-b818-2503bb2847c2"",
    ""area"": ""Test"",
    ""resourceName"": ""Suites"",
    ""routeTemplate"": ""_apis/test/{projectId}/Plans/{planId}/{resource}/{suiteId}/{action}/{testCaseIds}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""a4a1ec1c-b03f-41ca-8857-704594ecf58e"",
    ""area"": ""Test"",
    ""resourceName"": ""Suites"",
    ""routeTemplate"": ""{project}/_apis/test/Plans/{planId}/{resource}/{suiteId}/{action}/{testCaseIds}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""dedd48a7-82f6-48ac-86e8-3e0a1d99d785"",
    ""area"": ""Test"",
    ""resourceName"": ""Runs"",
    ""routeTemplate"": ""_apis/test/{projectId}/{resource}/{runId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""cadb3810-d47d-4a3c-a234-fe5f3be50138"",
    ""area"": ""Test"",
    ""resourceName"": ""Runs"",
    ""routeTemplate"": ""{project}/_apis/test/{resource}/{runId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""3b3adad0-61fb-462a-b906-c13d1b33d1fa"",
    ""area"": ""Test"",
    ""resourceName"": ""Runs"",
    ""routeTemplate"": ""_apis/test/{projectId}/{resource}/{runId}/Statistics"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""0a42c424-d764-4a16-a2d5-5c85f87d0ae8"",
    ""area"": ""Test"",
    ""resourceName"": ""Runs"",
    ""routeTemplate"": ""{project}/_apis/test/{resource}/{runId}/Statistics"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""ac160fa4-78a2-4e25-87c2-73a0afe8f5d7"",
    ""area"": ""Test"",
    ""resourceName"": ""Runs"",
    ""routeTemplate"": ""_apis/test/{projectId}/{resource}/{runId}/Coverage"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""d370b94c-b134-489a-93b1-497fcb399680"",
    ""area"": ""Test"",
    ""resourceName"": ""Runs"",
    ""routeTemplate"": ""{project}/_apis/test/{resource}/{runId}/Coverage"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""271c7b73-c3f9-4022-8ad6-aa53b600aff9"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""_apis/test/{projectId}/Runs/{runId}/{resource}/{testCaseResultId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""4637d869-3a76-4468-8057-0bb02aa385cf"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""{project}/_apis/test/Runs/{runId}/{resource}/{testCaseResultId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""1fb8192f-1adc-4cc0-9f82-f7799c541da3"",
    ""area"": ""Test"",
    ""resourceName"": ""Results2"",
    ""routeTemplate"": ""_apis/test/{projectId}/{resource}/{testCaseResultId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""5710d5f0-d129-4e85-a830-f8ea22968964"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""_apis/test/{projectId}/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""73eb9074-3446-4c44-8296-2f811950ff8d"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""{project}/_apis/test/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""35e7b463-f205-4c7e-a744-926f0a767f31"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""_apis/test/{projectId}/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}/{action}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7c69810d-3354-4af3-844a-180bd25db08a"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""{project}/_apis/test/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}/{action}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""6b182cf4-90c7-4759-9b1d-27d32e7eb861"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""_apis/test/{projectId}/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}/{action}/{actionPath}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""eaf40c31-ff84-4062-aafd-d5664be11a37"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""{project}/_apis/test/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}/{action}/{actionPath}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a6b80ccb-af66-4f6e-ae20-be845cea3458"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""_apis/test/{projectId}/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}/{action}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""1.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""7bf39f1d-7847-4449-a3f4-87f21a5bd41d"",
    ""area"": ""Test"",
    ""resourceName"": ""Results"",
    ""routeTemplate"": ""{project}/_apis/test/Runs/{runId}/{resource}/{testCaseResultId}/Iterations/{iterationId}/{action}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""0f1857de-6e56-4010-9ea7-f29b80b911c4"",
    ""area"": ""Test"",
    ""resourceName"": ""Agents"",
    ""routeTemplate"": ""_apis/test/{resource}/{id}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""315806b7-1f2b-4368-b94b-0e469f5e12fc"",
    ""area"": ""Test"",
    ""resourceName"": ""AutomationRuns"",
    ""routeTemplate"": ""_apis/test/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""575891b2-50a3-474f-a963-7ca011c97500"",
    ""area"": ""Test"",
    ""resourceName"": ""Slices"",
    ""routeTemplate"": ""_apis/test/{resource}/{testAgentId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""5b78449b-a866-4726-b989-9083eb2d977c"",
    ""area"": ""Test"",
    ""resourceName"": ""Commands"",
    ""routeTemplate"": ""_apis/test/Agents/{testagentId}/{resource}/{commandId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""0755ef73-0a92-4221-a902-6aae57503c2c"",
    ""area"": ""tfvc"",
    ""resourceName"": ""projectInfo"",
    ""routeTemplate"": ""_apis/{area}/{projectId}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""252d9c40-0643-41cf-85b2-044d80f9b675"",
    ""area"": ""tfvc"",
    ""resourceName"": ""projectInfo"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""ba9fc436-9a38-4578-89d6-e4f3241f5040"",
    ""area"": ""tfvc"",
    ""resourceName"": ""items"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{*path}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""fe6f827b-5f64-480f-b8af-1eca3b80e833"",
    ""area"": ""tfvc"",
    ""resourceName"": ""itemBatch"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""f32b86f2-15b9-4fe6-81b1-6f8938617ee5"",
    ""area"": ""tfvc"",
    ""resourceName"": ""changesetChanges"",
    ""routeTemplate"": ""_apis/{area}/changesets/{id}/changes"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""64ae0bea-1d71-47c9-a9e5-fe73f5ea0ff4"",
    ""area"": ""tfvc"",
    ""resourceName"": ""changesetWorkItems"",
    ""routeTemplate"": ""_apis/{area}/changesets/{id}/workItems"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""0bc8f0a4-6bfb-42a9-ba84-139da7b99c49"",
    ""area"": ""tfvc"",
    ""resourceName"": ""changesets"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""b7e7c173-803c-4fea-9ec8-31ee35c5502a"",
    ""area"": ""tfvc"",
    ""resourceName"": ""changesetsBatch"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""31db9770-7614-4718-b0a5-75d2a1e625ff"",
    ""area"": ""tfvc"",
    ""resourceName"": ""shelvesetChanges"",
    ""routeTemplate"": ""_apis/{area}/shelvesets/{shelvesetId}/changes"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""dbaf075b-0445-4c34-9e5b-82292f856522"",
    ""area"": ""tfvc"",
    ""resourceName"": ""shelvesetChanges"",
    ""routeTemplate"": ""_apis/{area}/shelvesets/changes"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""9a1a13e2-a285-4bc9-aa26-b0906cd3c851"",
    ""area"": ""tfvc"",
    ""resourceName"": ""shelvesetWorkItems"",
    ""routeTemplate"": ""_apis/{area}/shelvesets/{shelvesetId}/workitems"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a7a0c1c1-373e-425a-b031-a519474d743d"",
    ""area"": ""tfvc"",
    ""resourceName"": ""shelvesetWorkItems"",
    ""routeTemplate"": ""_apis/{area}/shelvesets/workitems"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""e36d44fb-e907-4b0a-b194-f83f1ed32ad3"",
    ""area"": ""tfvc"",
    ""resourceName"": ""shelvesets"",
    ""routeTemplate"": ""_apis/{area}/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""6aad49e3-4ded-45da-aabd-2f19d35266c7"",
    ""area"": ""tfvc"",
    ""resourceName"": ""shelvesets"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{shelvesetId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a5d9bd7f-b661-4d0e-b9be-d9c16affae54"",
    ""area"": ""tfvc"",
    ""resourceName"": ""labels"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{labelId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""06166e34-de17-4b60-8cd1-23182a346fda"",
    ""area"": ""tfvc"",
    ""resourceName"": ""labelItems"",
    ""routeTemplate"": ""_apis/{area}/labels/{labelId}/items"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""bc1f417e-239d-42e7-85e1-76e80cb2d6eb"",
    ""area"": ""tfvc"",
    ""resourceName"": ""branches"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{*path}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""1a3a1536-dca6-4509-b9c3-dd9bb2981506"",
    ""area"": ""wit"",
    ""resourceName"": ""ruleEngine"",
    ""routeTemplate"": ""_apis/{area}/${resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""8637ac8b-5eb6-4f90-b3f7-4f2ff576a459"",
    ""area"": ""wit"",
    ""resourceName"": ""workItemTypeTemplate"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{type}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""9b9f5734-36c8-415e-ba67-f83b45c31408"",
    ""area"": ""wit"",
    ""resourceName"": ""workItemTypeCategories"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{category}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""7c8d7a76-4a09-43e8-b5df-bd792f4ac6aa"",
    ""area"": ""wit"",
    ""resourceName"": ""workItemTypes"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{type}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""bd293ce5-3d25-4192-8e67-e8092e879efb"",
    ""area"": ""wit"",
    ""resourceName"": ""workItemTypesField"",
    ""routeTemplate"": ""{project}/_apis/{area}/workitemtypes/{type}/fields/{field}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""e07b5fa4-1499-494d-a496-64b860fd64ff"",
    ""area"": ""wit"",
    ""resourceName"": ""attachments"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""b51fd764-e5c2-4b9b-aaf7-3395cf4bdd94"",
    ""area"": ""wit"",
    ""resourceName"": ""fields"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{field}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""f5d33bc9-5b49-4a3c-a9bd-f3cd46dd2165"",
    ""area"": ""wit"",
    ""resourceName"": ""workItemRelationTypes"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{relation}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""7a9f0f1f-ddb3-4c30-9f71-12536d9caf29"",
    ""area"": ""wit"",
    ""resourceName"": ""queryResults"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a02355f5-5f8a-4671-8e32-369d23aac83d"",
    ""area"": ""wit"",
    ""resourceName"": ""wiql"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""1a9c53f7-f243-4447-b110-35ef023636e4"",
    ""area"": ""wit"",
    ""resourceName"": ""wiql"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a3f8e27f-b199-4c44-ae43-5fc7d33cda25"",
    ""area"": ""wit"",
    ""resourceName"": ""queries"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a67d190c-c41f-424b-814d-0e906f659301"",
    ""area"": ""wit"",
    ""resourceName"": ""queries"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/{*query}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""5ab72e1d-d007-459e-967c-2b935043bf96"",
    ""area"": ""wit"",
    ""resourceName"": ""areas"",
    ""routeTemplate"": ""{project}/_apis/{area}/classificationNodes/areas/{*path}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""26ec1d6f-4c51-45d2-bdab-64efa350e901"",
    ""area"": ""wit"",
    ""resourceName"": ""iterations"",
    ""routeTemplate"": ""{project}/_apis/{area}/classificationNodes/iterations/{*path}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""5a172953-1b41-49d3-840a-33f79c3ce89f"",
    ""area"": ""wit"",
    ""resourceName"": ""classificationNodes"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""a00c85a5-80fa-4565-99c3-bcd2181434bb"",
    ""area"": ""wit"",
    ""resourceName"": ""revisions"",
    ""routeTemplate"": ""_apis/{area}/workItems/{id}/revisions/{revisionNumber}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""6570bf97-d02c-4a91-8d93-3abe9895b1a9"",
    ""area"": ""wit"",
    ""resourceName"": ""updates"",
    ""routeTemplate"": ""_apis/{area}/workItems/{id}/updates/{updateNumber}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""f74eba29-47a1-4152-9381-84040aced527"",
    ""area"": ""wit"",
    ""resourceName"": ""history"",
    ""routeTemplate"": ""_apis/{area}/workItems/{id}/history/{revisionNumber}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""72c7ddf8-2cdc-4f60-90cd-ab71c14a399b"",
    ""area"": ""wit"",
    ""resourceName"": ""workItems"",
    ""routeTemplate"": ""_apis/{area}/{resource}/{id}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""62d3d110-0047-428c-ad3c-4fe872c91c74"",
    ""area"": ""wit"",
    ""resourceName"": ""workItems"",
    ""routeTemplate"": ""{project}/_apis/{area}/{resource}/${type}"",
    ""resourceVersion"": 2,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""049929b0-79e1-4ad5-a548-9e192d5c049e"",
    ""area"": ""SBS"",
    ""resourceName"": ""SBSNamespace"",
    ""routeTemplate"": ""_apis/{area}/{securityNamespaceId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""3f95720d-2ef6-47cc-b5d7-733561d13eb9"",
    ""area"": ""SBS"",
    ""resourceName"": ""SBSAcls"",
    ""routeTemplate"": ""_apis/{area}/{securityNamespaceId}/acls"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""ab821a2b-f383-4c72-8274-8425ed30835d"",
    ""area"": ""SBS"",
    ""resourceName"": ""SBSAces"",
    ""routeTemplate"": ""_apis/{area}/{securityNamespaceId}/aces"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""25dcffd2-9f2a-4109-b4cc-000f8472107d"",
    ""area"": ""SBS"",
    ""resourceName"": ""SBSInherit"",
    ""routeTemplate"": ""_apis/{area}/{securityNamespaceId}/inherit"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""466ecead-d7f1-447c-8bc1-52c22592b98e"",
    ""area"": ""SBS"",
    ""resourceName"": ""SBSTokens"",
    ""routeTemplate"": ""_apis/{area}/{securityNamespaceId}/tokens"",
    ""resourceVersion"": 1,
    ""minVersion"": ""1.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""1.0""
  },
  {
    ""id"": ""28010c54-d0c0-4c89-a5b0-1c9e188b9fb7"",
    ""area"": ""IMS"",
    ""resourceName"": ""Identities"",
    ""routeTemplate"": ""_apis/{resource}/{identityId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""0.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""299e50df-fe45-4d3a-8b5b-a5836fac74dc"",
    ""area"": ""IMS"",
    ""resourceName"": ""IdentityBatch"",
    ""routeTemplate"": ""_apis/{resource}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""0.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""8ba35978-138e-41f8-8963-7b1ea2c5f775"",
    ""area"": ""IMS"",
    ""resourceName"": ""Members"",
    ""routeTemplate"": ""_apis/identities/{containerId}/{resource}/{memberId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""0.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""22865b02-9e4a-479e-9e18-e35b8803b8a0"",
    ""area"": ""IMS"",
    ""resourceName"": ""MembersOf"",
    ""routeTemplate"": ""_apis/identities/{memberId}/{resource}/{containerId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""0.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  },
  {
    ""id"": ""d56223df-8ccd-45c9-89b4-eddf692400d7"",
    ""area"": ""IMS"",
    ""resourceName"": ""IdentitySnapshot"",
    ""routeTemplate"": ""_apis/{resource}/{scopeId}"",
    ""resourceVersion"": 1,
    ""minVersion"": ""0.0"",
    ""maxVersion"": ""2.0"",
    ""releasedVersion"": ""0.0""
  }
]
    }";

        public const string JsonProjects =
            @"{
  ""count"": 4,
  ""value"": [
    {
      ""id"": ""88ea01ec-4696-402b-89a7-371c1e16bbcb"",
      ""name"": ""TFS-VSO ClientAPI"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/projects/88ea01ec-4696-402b-89a7-371c1e16bbcb"",
      ""state"": ""wellFormed""
    },
    {
      ""id"": ""a1858ae0-c3e4-4a0f-b81a-4bba16804e7c"",
      ""name"": ""Imaginet-CoreLink"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/projects/a1858ae0-c3e4-4a0f-b81a-4bba16804e7c"",
      ""state"": ""wellFormed""
    },
    {
      ""id"": ""489bf70d-20ff-4f9b-8ce4-4f12f331d0b5"",
      ""name"": ""RestPlaypen"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/projects/489bf70d-20ff-4f9b-8ce4-4f12f331d0b5"",
      ""state"": ""wellFormed""
    },
    {
      ""id"": ""de7f6ca4-07ba-4a6d-b232-78ffaecd10f3"",
      ""name"": ""TestCase-Evaluation"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/projects/de7f6ca4-07ba-4a6d-b232-78ffaecd10f3"",
      ""state"": ""wellFormed""
    }
  ]
}";


        public const string JsonRelationTypes =
            @"{
  ""count"": 14,
  ""value"": [
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": true,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Forward"",
      ""name"": ""Referenced By"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Forward""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": true,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Reverse"",
      ""name"": ""References"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Microsoft.VSTS.TestCase.SharedParameterReferencedBy-Reverse""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": true,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""Microsoft.VSTS.Common.TestedBy-Forward"",
      ""name"": ""Tested By"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Microsoft.VSTS.Common.TestedBy-Forward""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": true,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""Microsoft.VSTS.Common.TestedBy-Reverse"",
      ""name"": ""Tests"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Microsoft.VSTS.Common.TestedBy-Reverse""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": true,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""Microsoft.VSTS.TestCase.SharedStepReferencedBy-Forward"",
      ""name"": ""Test Case"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Microsoft.VSTS.TestCase.SharedStepReferencedBy-Forward""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": true,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""Microsoft.VSTS.TestCase.SharedStepReferencedBy-Reverse"",
      ""name"": ""Shared Steps"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Microsoft.VSTS.TestCase.SharedStepReferencedBy-Reverse""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": false,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""System.LinkTypes.Dependency-Forward"",
      ""name"": ""Successor"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/System.LinkTypes.Dependency-Forward""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": false,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": true,
        ""topology"": ""dependency""
      },
      ""referenceName"": ""System.LinkTypes.Dependency-Reverse"",
      ""name"": ""Predecessor"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/System.LinkTypes.Dependency-Reverse""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": false,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": false,
        ""topology"": ""tree""
      },
      ""referenceName"": ""System.LinkTypes.Hierarchy-Forward"",
      ""name"": ""Child"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/System.LinkTypes.Hierarchy-Forward""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": false,
        ""enabled"": true,
        ""acyclic"": true,
        ""directional"": true,
        ""singleTarget"": false,
        ""topology"": ""tree""
      },
      ""referenceName"": ""System.LinkTypes.Hierarchy-Reverse"",
      ""name"": ""Parent"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/System.LinkTypes.Hierarchy-Reverse""
    },
    {
      ""attributes"": {
        ""usage"": ""workItemLink"",
        ""editable"": false,
        ""enabled"": true,
        ""acyclic"": false,
        ""directional"": false,
        ""singleTarget"": true,
        ""topology"": ""network""
      },
      ""referenceName"": ""System.LinkTypes.Related"",
      ""name"": ""Related"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/System.LinkTypes.Related""
    },
    {
      ""attributes"": {
        ""usage"": ""resourceLink"",
        ""editable"": false,
        ""enabled"": true
      },
      ""referenceName"": ""AttachedFile"",
      ""name"": ""Attached File"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/AttachedFile""
    },
    {
      ""attributes"": {
        ""usage"": ""resourceLink"",
        ""editable"": false,
        ""enabled"": true
      },
      ""referenceName"": ""Hyperlink"",
      ""name"": ""Hyperlink"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/Hyperlink""
    },
    {
      ""attributes"": {
        ""usage"": ""resourceLink"",
        ""editable"": false,
        ""enabled"": true
      },
      ""referenceName"": ""ArtifactLink"",
      ""name"": ""Artifact Link"",
      ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItemRelationTypes/ArtifactLink""
    }
  ]
 }";

        public const string JsonTeamRoom =
            @"{
 ""id"": 11522,
  ""name"": ""Test Room 635546415124328712"",
  ""description"": ""Dummy Room Created by Unit Test"",
  ""lastActivity"": ""2014-12-20T03:05:18.303Z"",
  ""createdBy"": {
    ""id"": ""0356e464-1798-4992-aa6a-ef8f06c662d4"",
    ""displayName"": ""David V. Corbin"",
    ""url"": ""https://davidvcorbin.vssps.visualstudio.com/_apis/Identities/0356e464-1798-4992-aa6a-ef8f06c662d4"",
    ""imageUrl"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=0356e464-1798-4992-aa6a-ef8f06c662d4""
  },
  ""createdDate"": ""2014-12-20T03:05:18.303Z"",
  ""hasAdminPermissions"": true,
  ""hasReadWritePermissions"": true
}";

        public const string JsonWorkItem217 = @"{
  ""id"": 217,
  ""rev"": 1,
  ""fields"": {
    ""System.AreaPath"": ""RestPlaypen"",
    ""System.TeamProject"": ""RestPlaypen"",
    ""System.IterationPath"": ""RestPlaypen"",
    ""System.WorkItemType"": ""Task"",
    ""System.State"": ""New"",
    ""System.Reason"": ""New"",
    ""System.CreatedDate"": ""2014-11-27T08:52:52.85Z"",
    ""System.CreatedBy"": ""David V. Corbin <david.corbin@live.com>"",
    ""System.ChangedDate"": ""2014-11-27T08:52:52.85Z"",
    ""System.ChangedBy"": ""David V. Corbin <david.corbin@live.com>"",
    ""System.Title"": ""Sample Title"",
    ""Microsoft.VSTS.Common.StateChangeDate"": ""2014-11-27T08:52:52.85Z"",
    ""Microsoft.VSTS.Common.Priority"": 2
  },
  ""_links"": {
    ""self"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/217/revisions/1""
    },
    ""workItemRevisions"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/217/revisions""
    },
    ""parent"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/217""
    }
  },
  ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/217/revisions/1""
}";

        public const string JsonWorkItem324 = @"{
  ""id"": 324,
  ""rev"": 1,
  ""fields"": {
    ""System.AreaPath"": ""RestPlaypen"",
    ""System.TeamProject"": ""RestPlaypen"",
    ""System.IterationPath"": ""RestPlaypen"",
    ""System.WorkItemType"": ""Task"",
    ""System.State"": ""New"",
    ""System.Reason"": ""New"",
    ""System.CreatedDate"": ""2014-12-06T09:36:28.303Z"",
    ""System.CreatedBy"": ""David V. Corbin <david.corbin@live.com>"",
    ""System.ChangedDate"": ""2014-12-06T09:36:28.303Z"",
    ""System.ChangedBy"": ""David V. Corbin <david.corbin@live.com>"",
    ""System.Title"": ""WorkItem Created by Unit Testing"",
    ""Microsoft.VSTS.Common.StateChangeDate"": ""2014-12-06T09:36:28.303Z"",
    ""Microsoft.VSTS.Common.Priority"": 2
  },
  ""_links"": {
    ""self"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/324/revisions/1""
    },
    ""workItemRevisions"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/324/revisions""
    },
    ""parent"": {
      ""href"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/324""
    }
  },
  ""url"": ""https://davidvcorbin.visualstudio.com/DefaultCollection/_apis/wit/workItems/324/revisions/1""
}";


        public const string SampleQueries = @"

{
  ""count"": 2,
  ""value"": [
    {
      ""id"": ""3c65fbc1-d427-48ce-9091-633dde9e27e2"",
      ""name"": ""My Queries"",
      ""path"": ""My Queries"",
      ""isFolder"": true,
      ""hasChildren"": true,
      ""children"": [
        {
          ""id"": ""0ea88f4d-5585-41a1-be58-5f1c6b9c2853"",
          ""name"": ""All Work"",
          ""path"": ""My Queries/All Work"",
          ""isPublic"": false,
          ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/0ea88f4d-5585-41a1-be58-5f1c6b9c2853""
        }
      ],
      ""isPublic"": false,
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/3c65fbc1-d427-48ce-9091-633dde9e27e2""
    },
    {
      ""id"": ""eb5c1e25-9b3e-4416-a833-e500122882c7"",
      ""name"": ""Shared Queries"",
      ""path"": ""Shared Queries"",
      ""isFolder"": true,
      ""hasChildren"": true,
      ""children"": [
        {
          ""id"": ""7662ea76-d42d-43db-abb0-19e6f1d0be9b"",
          ""name"": ""Feedback"",
          ""path"": ""Shared Queries/Feedback"",
          ""isPublic"": true,
          ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/7662ea76-d42d-43db-abb0-19e6f1d0be9b""
        },
        {
          ""id"": ""139a3503-6ac6-4fa0-9a91-f76f180e7b65"",
          ""name"": ""Current Sprint"",
          ""path"": ""Shared Queries/Current Sprint"",
          ""isFolder"": true,
          ""hasChildren"": true,
          ""isPublic"": true,
          ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/139a3503-6ac6-4fa0-9a91-f76f180e7b65""
        }
      ],
      ""isPublic"": true,
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/eb5c1e25-9b3e-4416-a833-e500122882c7""
    }
  ]
}
";


        public const string SampleQueryDefinition = @"
{
  ""id"": ""df60fdf6-3b5f-4928-aae8-29ee63df6e31"",
  ""name"": ""All Bugs"",
  ""path"": ""Shared Queries/Website team/All Bugs"",
  ""isPublic"": true,
  ""_links"": {
    ""self"": {
      ""href"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/df60fdf6-3b5f-4928-aae8-29ee63df6e31""
    },
    ""html"": {
      ""href"": ""https://fabrikam.visualstudio.com/web/qr.aspx?pguid=6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c&amp;qid=df60fdf6-3b5f-4928-aae8-29ee63df6e31""
    },
    ""parent"": {
      ""href"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/addcb8b3-12d0-4f2c-b6ca-52bb584ae286""
    },
    ""wiql"": {
      ""href"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/wiql/df60fdf6-3b5f-4928-aae8-29ee63df6e31""
    }
  },
  ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/queries/df60fdf6-3b5f-4928-aae8-29ee63df6e31""
}
";
        public const string SampleWorkItemType = @"

{
  ""name"": ""Bug"",
  ""description"": ""Describes a divergence between required and actual behavior, and tracks the work done to correct the defect and verify the correction."",
  ""xmlForm"": ""<FORM><Layout HideReadOnlyEmptyFields=\""true\"" HideControlBorders=\""true\""><Group Margin=\""(4,0,0,0)\""><Column PercentWidth=\""100\""><Control FieldName=\""System.Title\"" Type=\""FieldControl\"" ControlFontSize=\""large\"" EmptyText=\""&amp;lt;Enter title here&amp;gt;\"" /></Column></Group><Group Margin=\""(10,0,0,0)\""><Column PercentWidth=\""100\""><Control FieldName=\""System.IterationPath\"" Type=\""WorkItemClassificationControl\"" Label=\""Ite&amp;amp;ration\"" LabelPosition=\""Left\"" /></Column></Group><Group Margin=\""(10,0,0,0)\""><Column PercentWidth=\""50\""><Group Label=\""Status\""><Column PercentWidth=\""100\""><Control FieldName=\""System.AssignedTo\"" Type=\""FieldControl\"" Label=\""Assi&amp;amp;gned To\"" LabelPosition=\""Left\"" /><Control FieldName=\""System.State\"" Type=\""FieldControl\"" Label=\""Stat&amp;amp;e\"" LabelPosition=\""Left\"" /><Control FieldName=\""System.Reason\"" Type=\""FieldControl\"" Label=\""Reason\"" LabelPosition=\""Left\"" /></Column></Group></Column><Column PercentWidth=\""50\""><Group Label=\""Details\""><Column PercentWidth=\""100\""><Control FieldName=\""Microsoft.VSTS.Scheduling.Effort\"" Type=\""FieldControl\"" Label=\""Effort\"" LabelPosition=\""Left\"" /><Control FieldName=\""Microsoft.VSTS.Common.Severity\"" Type=\""FieldControl\"" Label=\""Severity\"" LabelPosition=\""Left\"" /><Control FieldName=\""System.AreaPath\"" Type=\""WorkItemClassificationControl\"" Label=\""&amp;amp;Area\"" LabelPosition=\""Left\"" /></Column></Group></Column></Group><Group><Column PercentWidth=\""50\""><TabGroup><Tab Label=\""Steps to Reproduce\""><Control FieldName=\""Microsoft.VSTS.TCM.ReproSteps\"" Type=\""HtmlFieldControl\"" Label=\""\"" LabelPosition=\""Top\"" MinimumSize=\""(100,200)\"" Dock=\""Fill\"" /></Tab><Tab Label=\""System\""><Group Label=\""Build\""><Column PercentWidth=\""100\""><Control FieldName=\""Microsoft.VSTS.Build.FoundIn\"" Type=\""FieldControl\"" Label=\""Found in Build\"" LabelPosition=\""Left\"" /><Control FieldName=\""Microsoft.VSTS.Build.IntegrationBuild\"" Type=\""FieldControl\"" Label=\""Integrated in Build\"" LabelPosition=\""Left\"" /></Column></Group><Control FieldName=\""Microsoft.VSTS.TCM.SystemInfo\"" Type=\""HtmlFieldControl\"" Label=\""System Info\"" LabelPosition=\""Top\"" Dock=\""Fill\"" /></Tab><Tab Label=\""Test Cases\""><Control Type=\""LinksControl\"" Name=\""TestedBy\"" Label=\""\"" LabelPosition=\""Top\""><LinksControlOptions><LinkColumns><LinkColumn RefName=\""System.Id\"" /><LinkColumn RefName=\""System.WorkItemType\"" /><LinkColumn RefName=\""System.Title\"" /><LinkColumn RefName=\""System.AssignedTo\"" /><LinkColumn RefName=\""System.State\"" /></LinkColumns><WorkItemLinkFilters FilterType=\""include\""><Filter LinkType=\""Microsoft.VSTS.Common.TestedBy\"" FilterOn=\""forwardname\"" /></WorkItemLinkFilters><ExternalLinkFilters FilterType=\""excludeAll\"" /><WorkItemTypeFilters FilterType=\""include\""><Filter WorkItemType=\""Test Case\"" /></WorkItemTypeFilters></LinksControlOptions></Control></Tab><Tab Label=\""Tasks\""><Control Type=\""LinksControl\"" Label=\""\"" LabelPosition=\""Top\"" Name=\""TaskLinks\""><LinksControlOptions><LinkColumns><LinkColumn RefName=\""System.Id\"" /><LinkColumn RefName=\""System.WorkItemType\"" /><LinkColumn RefName=\""System.Title\"" /><LinkColumn RefName=\""System.AssignedTo\"" /><LinkColumn RefName=\""System.State\"" /></LinkColumns><WorkItemLinkFilters FilterType=\""include\""><Filter LinkType=\""System.LinkTypes.Hierarchy\"" FilterOn=\""forwardname\"" /></WorkItemLinkFilters><ExternalLinkFilters FilterType=\""excludeAll\"" /><WorkItemTypeFilters FilterType=\""include\""><Filter WorkItemType=\""Task\"" /></WorkItemTypeFilters></LinksControlOptions></Control></Tab></TabGroup></Column><Column PercentWidth=\""50\""><TabGroup Margin=\""(5,0,0,0)\""><Tab Label=\""Acceptance Criteria\""><Control FieldName=\""Microsoft.VSTS.Common.AcceptanceCriteria\"" Type=\""HtmlFieldControl\"" Label=\""\"" LabelPosition=\""Top\"" Dock=\""Fill\"" MinimumSize=\""(100,200)\"" /></Tab><Tab Label=\""History\""><Control FieldName=\""System.History\"" Type=\""WorkItemLogControl\"" Label=\""\"" LabelPosition=\""Top\"" Dock=\""Fill\"" /></Tab><Tab Label=\""Links\""><Control Type=\""LinksControl\"" Name=\""GeneralLinks\"" LabelPosition=\""Top\""><LinksControlOptions><LinkColumns><LinkColumn RefName=\""System.Id\"" /><LinkColumn RefName=\""System.WorkItemType\"" /><LinkColumn RefName=\""System.Title\"" /><LinkColumn RefName=\""System.AssignedTo\"" /><LinkColumn RefName=\""System.State\"" /><LinkColumn LinkAttribute=\""System.Links.Comment\"" /></LinkColumns><WorkItemLinkFilters FilterType=\""includeAll\"" /><ExternalLinkFilters FilterType=\""includeAll\"" /><WorkItemTypeFilters FilterType=\""includeAll\"" /></LinksControlOptions></Control></Tab><Tab Label=\""Attachments\""><Control Type=\""AttachmentsControl\"" LabelPosition=\""Top\"" /></Tab></TabGroup></Column></Group></Layout></FORM>"",
  ""fieldInstances"": [
    {
      ""referenceName"": ""System.IterationPath"",
      ""name"": ""Iteration Path"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.IterationPath""
    },
    {
      ""referenceName"": ""System.IterationId"",
      ""name"": ""Iteration ID"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.IterationId""
    },
    {
      ""referenceName"": ""System.ExternalLinkCount"",
      ""name"": ""External Link Count"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.ExternalLinkCount""
    },
    {
      ""referenceName"": ""System.TeamProject"",
      ""name"": ""Team Project"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.TeamProject""
    },
    {
      ""referenceName"": ""System.HyperLinkCount"",
      ""name"": ""Hyperlink Count"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.HyperLinkCount""
    },
    {
      ""referenceName"": ""System.AttachedFileCount"",
      ""name"": ""Attached File Count"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.AttachedFileCount""
    },
    {
      ""referenceName"": ""System.NodeName"",
      ""name"": ""Node Name"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.NodeName""
    },
    {
      ""referenceName"": ""System.AreaPath"",
      ""name"": ""Area Path"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.AreaPath""
    },
    {
      ""referenceName"": ""System.RevisedDate"",
      ""name"": ""Revised Date"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.RevisedDate""
    },
    {
      ""referenceName"": ""System.ChangedDate"",
      ""name"": ""Changed Date"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.ChangedDate""
    },
    {
      ""referenceName"": ""System.Id"",
      ""name"": ""ID"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Id""
    },
    {
      ""referenceName"": ""System.AreaId"",
      ""name"": ""Area ID"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.AreaId""
    },
    {
      ""referenceName"": ""System.AuthorizedAs"",
      ""name"": ""Authorized As"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.AuthorizedAs""
    },
    {
      ""referenceName"": ""System.Title"",
      ""name"": ""Title"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Title""
    },
    {
      ""referenceName"": ""System.State"",
      ""name"": ""State"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.State""
    },
    {
      ""referenceName"": ""System.AuthorizedDate"",
      ""name"": ""Authorized Date"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.AuthorizedDate""
    },
    {
      ""referenceName"": ""System.Watermark"",
      ""name"": ""Watermark"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Watermark""
    },
    {
      ""referenceName"": ""System.Rev"",
      ""name"": ""Rev"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Rev""
    },
    {
      ""referenceName"": ""System.ChangedBy"",
      ""name"": ""Changed By"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.ChangedBy""
    },
    {
      ""referenceName"": ""System.Reason"",
      ""name"": ""Reason"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Reason""
    },
    {
      ""referenceName"": ""System.AssignedTo"",
      ""name"": ""Assigned To"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.AssignedTo""
    },
    {
      ""referenceName"": ""System.WorkItemType"",
      ""name"": ""Work Item Type"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.WorkItemType""
    },
    {
      ""referenceName"": ""System.CreatedDate"",
      ""name"": ""Created Date"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.CreatedDate""
    },
    {
      ""referenceName"": ""System.CreatedBy"",
      ""name"": ""Created By"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.CreatedBy""
    },
    {
      ""referenceName"": ""System.Description"",
      ""name"": ""Description"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Description""
    },
    {
      ""referenceName"": ""System.History"",
      ""name"": ""History"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.History""
    },
    {
      ""referenceName"": ""System.BISLinks"",
      ""name"": ""BIS Links"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.BISLinks""
    },
    {
      ""referenceName"": ""System.RelatedLinkCount"",
      ""name"": ""Related Link Count"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.RelatedLinkCount""
    },
    {
      ""referenceName"": ""System.Tags"",
      ""name"": ""Tags"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.Tags""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.TCM.SystemInfo"",
      ""name"": ""System Info"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.TCM.SystemInfo""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Common.ClosedDate"",
      ""name"": ""Closed Date"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Common.ClosedDate""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.TCM.ReproSteps"",
      ""name"": ""Repro Steps"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.TCM.ReproSteps""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Common.BacklogPriority"",
      ""name"": ""Backlog Priority"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Common.BacklogPriority""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Scheduling.Effort"",
      ""name"": ""Effort"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Scheduling.Effort""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Common.AcceptanceCriteria"",
      ""name"": ""Acceptance Criteria"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Common.AcceptanceCriteria""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Common.Severity"",
      ""name"": ""Severity"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Common.Severity""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Build.IntegrationBuild"",
      ""name"": ""Integration Build"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Build.IntegrationBuild""
    },
    {
      ""referenceName"": ""Microsoft.VSTS.Build.FoundIn"",
      ""name"": ""Found In"",
      ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/Microsoft.VSTS.Build.FoundIn""
    }
  ],
  ""transitions"": {
    ""Approved"": [
      {
        ""to"": ""Approved""
      },
      {
        ""to"": ""Committed""
      },
      {
        ""to"": ""New""
      },
      {
        ""to"": ""Removed""
      },
      {
        ""to"": ""Done""
      }
    ],
    ""New"": [
      {
        ""to"": ""New""
      },
      {
        ""to"": ""Committed""
      },
      {
        ""to"": ""Approved""
      },
      {
        ""to"": ""Removed""
      },
      {
        ""to"": ""Done""
      }
    ],
    ""Done"": [
      {
        ""to"": ""Done""
      },
      {
        ""to"": ""Committed""
      },
      {
        ""to"": ""Approved""
      },
      {
        ""to"": ""New""
      }
    ],
    ""Committed"": [
      {
        ""to"": ""Committed""
      },
      {
        ""to"": ""Approved""
      },
      {
        ""to"": ""New""
      },
      {
        ""to"": ""Done""
      }
    ],
    ""Removed"": [
      {
        ""to"": ""Removed""
      },
      {
        ""to"": ""New""
      }
    ],
    """": [
      {
        ""to"": ""New""
      }
    ]
  },
  ""_links"": {
    ""self"": {
      ""href"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/workItemTypes/Bug""
    }
  },
  ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/6ce954b1-ce1f-45d1-b94d-e6bf2464ba2c/_apis/wit/workItemTypes/Bug""
}";
        public const string SampleWorkItemsFieldDefinition = @"

{
  ""name"": ""Iteration Path"",
  ""referenceName"": ""System.IterationPath"",
  ""type"": ""treePath"",
  ""readOnly"": true,
  ""supportedOperations"": [
    {
      ""referenceName"": ""SupportedOperations.Under"",
      ""name"": ""Under""
    },
    {
      ""referenceName"": ""SupportedOperations.NotUnder"",
      ""name"": ""Not Under""
    },
    {
      ""referenceName"": ""SupportedOperations.Equals"",
      ""name"": ""=""
    },
    {
      ""referenceName"": ""SupportedOperations.NotEquals"",
      ""name"": ""<>""
    },
    {
      ""referenceName"": ""SupportedOperations.In"",
      ""name"": ""In""
    }
  ],
  ""url"": ""https://fabrikam.visualstudio.com/DefaultCollection/_apis/wit/fields/System.IterationPath""
}

";
    }
}