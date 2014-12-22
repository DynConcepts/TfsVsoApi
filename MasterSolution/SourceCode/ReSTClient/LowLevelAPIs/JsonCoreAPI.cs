using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;

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
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.connectedServices);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the details.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetDetails()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.connectedServices);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the identity MRU.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetIdentityMru()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.identityMru);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetMembers()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.members);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetProjects()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.projects);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the proxies.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetProxies()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.proxies);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the teams.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetTeams()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(coreRestCalls.teams);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }
    }
}