using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonBuildAPI.
    /// </summary>
    internal class JsonProjectAPI : VsoRestAPIBase
    {
        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>Task&lt;JsonProject&gt;.</returns>
        public async Task<JsonProject> GetProject(Guid projectId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ProjectRestCalls.ProjectById);
            exchange.SetRoute("{projectId}", projectId);
            JsonProject result = await ProcessCollectionRequest(exchange, JsonProject.FromToken);
            return result;
        }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Task&lt;JsonProject&gt;.</returns>
        public async Task<JsonProject> GetProject(string projectName)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ProjectRestCalls.ProjectByName);
            exchange.SetRoute("{projectName}", projectName);
            JsonProject result = await ProcessCollectionRequest(exchange, JsonProject.FromToken);
            return result;
        }

        /// <summary>
        ///     Gets the project team.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="teamId">The team identifier.</param>
        /// <returns>Task&lt;JsonProjectTeam&gt;.</returns>
        public async Task<JsonProjectTeam> GetProjectTeam(Guid projectId, Guid teamId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ProjectRestCalls.ProjectTeam);
            exchange.SetRoute("{projectId}", projectId);
            exchange.SetRoute("{teamId}", teamId);
            JsonProjectTeam result = await ProcessCollectionRequest(exchange, JsonProjectTeam.FromToken);
            return result;
        }

        /// <summary>
        ///     Gets the project team members.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <param name="teamId">The team identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonProjectTeamMember&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProjectTeamMember>> GetProjectTeamMembers(Guid projectId, Guid teamId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ProjectRestCalls.ProjectTeamMembers);
            exchange.SetRoute("{projectId}", projectId);
            exchange.SetRoute("{teamId}", teamId);
            IReadOnlyList<JsonProjectTeamMember> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProjectTeamMember.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the project teams.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonProjectTeam&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProjectTeam>> GetProjectTeams(Guid projectId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ProjectRestCalls.ProjectTeams);
            exchange.SetRoute("{projectId}", projectId);
            IReadOnlyList<JsonProjectTeam> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProjectTeam.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the projects.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonProject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProject>> GetProjects()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(ProjectRestCalls.Projects);
            IReadOnlyList<JsonProject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProject.FromToken));
            return result;
        }
    }
}