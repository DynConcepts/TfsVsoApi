using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonBuildAPI.
    /// </summary>
    internal class JsonBuildAPI : VsoRestAPIBase
    {
        /// <summary>
        ///     Gets the artifacts.
        /// </summary>
        /// <returns>
        ///     System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        ///     DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.
        /// </returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetArtifacts()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Artifacts);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the commits.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="buildId">The build identifier.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        /// DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetCommits(string project, int buildId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Commits);
            exchange.SetRoute("{buildId}", buildId);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the logs.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="buildId">The build identifier.</param>
        /// <returns>System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        /// DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetLogs(string project, int buildId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Logs);
            exchange.SetRoute("{buildId}", buildId);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the options.
        /// </summary>
        /// <returns>
        ///     System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        ///     DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.
        /// </returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetOptions()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Options);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the revisions.
        /// </summary>
        /// <returns>
        ///     System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        ///     DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.
        /// </returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetRevisions()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Revisions);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        public async Task<IReadOnlyList<JsonBuildDefinition>> GetDefinitions(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Definitions);
            IReadOnlyList<JsonBuildDefinition> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonBuildDefinition.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the tags_0.
        /// </summary>
        /// <returns>
        ///     System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        ///     DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.
        /// </returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetTags_0(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Tags0);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the tags_1.
        /// </summary>
        /// <returns>
        ///     System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        ///     DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.
        /// </returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetTags_1(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Tags1);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the templates.
        /// </summary>
        /// <returns>
        ///     System.Threading.Tasks.Task&lt;System.Collections.Generic.IReadOnlyList&lt;
        ///     DynCon.OSI.VSO.ReSTClient.Objects.WIT.JsonGeneralPurposeObject&gt;&gt;.
        /// </returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetTemplates(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(BuildRestCalls.Templates);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessProjectRequest(project, exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }
    }
}