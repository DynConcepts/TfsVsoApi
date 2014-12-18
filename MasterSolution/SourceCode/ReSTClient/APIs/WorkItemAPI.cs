using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    /// <summary>
    /// Class WorkItemAPI.
    /// </summary>
    public class WorkItemAPI : IWorkItemAPI
    {
        /// <summary>
        /// The r_ json API
        /// </summary>
        private readonly JsonWorkItemAPI r_JsonAPI = new JsonWorkItemAPI();

        /// <summary>
        /// Builds the work item.
        /// </summary>
        /// <param name="projectNanme">The project nanme.</param>
        /// <param name="workItemType">Type of the work item.</param>
        /// <param name="fieldValues">The field values.</param>
        /// <returns>IWorkItem.</returns>
        public IWorkItem BuildWorkItem(string projectNanme, string workItemType, IReadOnlyList<KeyValuePair<string, object>> fieldValues)
        {
            var result = r_JsonAPI.BuildWorkItem(projectNanme, workItemType, fieldValues, WorkItemImpl.FromToken);
            return result;
        }

        /// <summary>
        /// Creates the work item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="workItem">The work item.</param>
        /// <returns>Task&lt;IWorkItem&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IWorkItem> CreateWorkItem(string project, IWorkItem workItem) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets the areas.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IList&lt;IArea&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IArea>> GetAreas(string project, int depth)
        { 
            var result = await r_JsonAPI.GetAreas(project, depth, AreaImpl.FromToken);
            return result;
        }
        /// <summary>
        /// Gets the iterations.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IIteration&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IIteration>> GetIterations(string project, int depth)
       {
           var result = await r_JsonAPI.GetIterations(project, depth, IterationImpl.FromToken);
            return result;
        }

        /// <summary>
        /// Gets the work item type categories.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IList&lt;ICategory&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IReadOnlyList<ICategory>> GetWorkItemTypeCategories(string project) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets the work item types.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemType&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IReadOnlyDictionary<string, IWorkItemType>> GetWorkItemTypes(string project)
        {
            IReadOnlyDictionary<string, WorkItemTypeImpl> values = await r_JsonAPI.GetWorkItemTypes(project, WorkItemTypeImpl.FromToken);
            return values.ToDictionary<KeyValuePair<string, WorkItemTypeImpl>, string, IWorkItemType>(pair => pair.Key, pair => pair.Value);
        }

        /// <summary>
        /// Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItem>> GetWorkItems(IEnumerable<int> ids)
        {
            var result = await r_JsonAPI.GetWorkItems(ids, WorkItemImpl.FromToken);
            return result;
           
        }

        /// <summary>
        /// Wiqls the query.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">if set to <c>true</c> [fully populate].</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItem&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public async Task<IReadOnlyList<IWorkItem>> WiqlQuery(string wiql, bool fullyPopulate)
        {
            var result = await r_JsonAPI.WiqlQuery(wiql, fullyPopulate, WorkItemImpl.FromToken);
            return result;
        }

        /// <summary>
        /// Gets the relation types.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IRelationType&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IReadOnlyList<IRelationType>> GetRelationTypes() { throw new NotImplementedException(); }

        /// <summary>
        /// Gets the links for work item.
        /// </summary>
        /// <param name="workItem">The work item.</param>
        /// <returns>Task&lt;ILinkCollection&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<ILinkCollection> GetLinksForWorkItem(IWorkItem workItem) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IFieldDefinition&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IReadOnlyList<IFieldDefinition>> GetFieldDefinitions() { throw new NotImplementedException(); }
    }

    public class AreaImpl : JsonArea, IArea
    {
        protected AreaImpl(JToken content)
            : base(content)
        {
        }

        public static AreaImpl FromToken(JObject content)
        {
            var instance = new AreaImpl(content);
            return instance;
        }

        public new IList<IArea> Children { get { throw new NotImplementedException(); } }

        public new IArea Parent { get { throw new NotImplementedException(); } }
    }
    public class IterationImpl : JsonIteration, IIteration
    {
        protected IterationImpl(JToken content)
            : base(content)
        {
        }

        public static IterationImpl FromToken(JObject content)
        {
            var instance = new IterationImpl(content);
            return instance;
        }

        public new IList<IIteration> Children { get { throw new NotImplementedException(); } }

        public new IIteration Parent { get { throw new NotImplementedException(); } }
    }
}
