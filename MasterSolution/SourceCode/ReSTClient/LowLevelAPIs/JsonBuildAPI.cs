using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.RestCalls;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonBuildAPI.
    /// </summary>
    internal class JsonBuildAPI : VsoRestAPIBase
    {
        public async Task<IReadOnlyList<JsonBuild>> GetBuilds(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Builds);
            IReadOnlyList<JsonBuild> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonBuild.FromToken));
            return result;
        }

        public async Task<JsonBuild> GetBuild(string project, int buildId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Build);
            exchange.SetRoute("{buildId}", buildId);
            JsonBuild result = await ProcessProjectRequest(project, exchange, JsonBuild.FromToken);
            return result;
        }

        public async Task<IReadOnlyList<JsonBuildDetails>> GetBuildDetails(string project, int buildId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.BuildDetails);
            exchange.SetRoute("{buildId}", buildId);
            IReadOnlyList<JsonBuildDetails> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonBuildDetails.FromToken));
            return result;
        }

        public async Task<IReadOnlyList<JsonBuildDefinition>> GetDefinitions(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Definitions);
            IReadOnlyList<JsonBuildDefinition> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonBuildDefinition.FromToken));
            return result;
        }

        public async Task<JsonBuildDefinition> GetDefinition(string project, int definitionId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Definition);
            exchange.SetRoute("{definitionId}", definitionId);
            JsonBuildDefinition result = await ProcessProjectRequest(project, exchange, JsonBuildDefinition.FromToken);
            return result;
        }


        public async Task<IReadOnlyList<JsonBuildQuality>> GetQualities(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Qualities);
            IReadOnlyList<JsonBuildQuality> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.JArrayToObjects(o["value"].Value<JArray>(), JsonBuildQuality.FromToken));
            return result;
        }

        public async Task<JsonBuildQuality> GetQuality(string project, int qualityId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Quality);
            exchange.SetRoute("{qualityId}", qualityId);
            JsonBuildQuality result = await ProcessProjectRequest(project, exchange, JsonBuildQuality.FromToken);
            return result;
        }

        public async Task<IReadOnlyList<JsonBuildQueue>> GetQueues()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Queues);
            IReadOnlyList<JsonBuildQueue> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonBuildQueue.FromToken));
            return result;
        }

        public async Task<JsonBuildQueue> GetQueue(int queueId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Queue);
            exchange.SetRoute("{queueId}", queueId);
            JsonBuildQueue result = await ProcessCollectionRequest(exchange, JsonBuildQueue.FromToken);
            return result;
        }

        public async Task<IReadOnlyList<JsonBuildRequest>> GetRequests(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Requests);
            IReadOnlyList<JsonBuildRequest> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonBuildRequest.FromToken));
            return result;
        }

        public async Task<JsonBuildRequest> GetRequest(string project, int requestId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Request);
            exchange.SetRoute("{requestId}", requestId);
            JsonBuildRequest result = await ProcessProjectRequest(project, exchange, JsonBuildRequest.FromToken);
            return result;
        }


    }
}