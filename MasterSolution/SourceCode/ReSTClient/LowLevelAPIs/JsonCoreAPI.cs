using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonCoreAPI.
    /// </summary>
    internal class JsonCoreAPI : VsoRestAPIBase
    {
        /// <summary>
        ///     Gets the connected services.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetConnectedServices()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.ConnectedServices);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the details.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetDetails()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.ConnectedServices);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the identity MRU.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetIdentityMru()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.IdentityMru);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetMembers()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Members);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProject>> GetProjects()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Projects);
            IReadOnlyList<JsonProject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the proxies.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProxy>> GetProxies()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Proxies);
            IReadOnlyList<JsonProxy> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProxy.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the teams.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetTeams()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Teams);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }
    }
}