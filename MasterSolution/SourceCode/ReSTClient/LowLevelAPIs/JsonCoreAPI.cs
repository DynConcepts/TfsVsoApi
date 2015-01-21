using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    /// Class JsonCoreAPI.
    /// </summary>
    internal class JsonCoreAPI : VsoRestAPIBase
    {
        /// <summary>
        /// Gets the connected services.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetConnectedServices(string projectId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.ConnectedServices);
            exchange.SetRoute("{projectId}", projectId);
            exchange.SetRoute("{name}", String.Empty);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetDetails()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.ConnectedServices);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the identity MRU.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetIdentityMru()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.IdentityMru);
            exchange.SetRoute("{mruName}", String.Empty);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the members.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="teamId">The team identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonIdentity&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonIdentity>> GetMembers(string projectId, string teamId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Members);
            exchange.SetRoute("{projectId}", projectId);
            exchange.SetRoute("{teamId}", teamId);
            IReadOnlyList<JsonIdentity> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonIdentity.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProject>> GetProjects()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Projects);
            IReadOnlyList<JsonProject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProject.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the proxies.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProxy>> GetProxies()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Proxies);
            IReadOnlyList<JsonProxy> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProxy.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the teams.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonTeam>> GetTeams(string projectId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(CoreRestCalls.Teams);
            exchange.SetRoute("{projectId}", projectId);
            exchange.SetRoute("{*teamId}", String.Empty);
            IReadOnlyList<JsonTeam> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonTeam.FromToken));
            return result;
        }
    }
}