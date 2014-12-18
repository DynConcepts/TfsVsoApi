using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.SharedInterfaces.APIs
{
    /// <summary>
    ///     Represents the TFS/VSO WorkItem ReST Service Calls
    /// </summary>
    public interface IWorkItemAPI
    {
        /// <summary>
        ///     Builds the work item.
        /// </summary>
        /// <param name="headings">The headings.</param>
        /// <param name="data">The data.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem BuildWorkItem(IReadOnlyList<string> headings, IReadOnlyList<object> data);

        /// <summary>
        ///     Creates the work item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="workItem">The work item.</param>
        /// <returns>Task&lt;IWorkItem&gt;.</returns>
        Task<IWorkItem> CreateWorkItem(string project, IWorkItem workItem);

        /// <summary>
        ///     Gets the areas.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IList&lt;IArea&gt;&gt;.</returns>
        Task<IReadOnlyList<IArea>> GetAreas(string project, int depth);

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemFieldDefinition&gt;&gt;.</returns>
        Task<IReadOnlyList<IWorkItemFieldDefinition>> GetFields();

        /// <summary>
        ///     Gets the iterations.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IIteration&gt;&gt;.</returns>
        Task<IReadOnlyList<IIteration>> GetIterations(string project, int depth);

        /// <summary>
        ///     Gets the work item type categories.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IList&lt;IWorkItemTypeCategory&gt;&gt;.</returns>
        Task<IReadOnlyList<IWorkItemTypeCategory>> GetWorkItemTypeCategories(string project);

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemType&gt;&gt;.</returns>
        Task<IReadOnlyList<IWorkItemType>> GetWorkItemTypes(string project);

        /// <summary>
        ///     Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        Task<IReadOnlyList<IWorkItem>> GetWorkItems(IEnumerable<int> ids);

        /// <summary>
        ///     Wiqls the query.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">if set to <c>true</c> [fully populate].</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItem&gt;&gt;.</returns>
        Task<IReadOnlyList<IWorkItem>> WiqlQuery(string project, string wiql, bool fullyPopulate);


        /// <summary>
        /// Gets the relation types.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IRelationType&gt;&gt;.</returns>
        Task<IReadOnlyList<IRelationType>> GetRelationTypes();

        /// <summary>
        /// Gets the work item links.
        /// </summary>
        /// <param name="workItem">The work item.</param>
        /// <returns>List&lt;ILink&gt;.</returns>
        Task<IReadOnlyList<ILink>> GetWorkItemLinks(IWorkItem workItem);
    }
}