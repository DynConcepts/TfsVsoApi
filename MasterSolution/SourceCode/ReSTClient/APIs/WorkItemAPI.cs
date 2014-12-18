using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    internal class WorkItemAPI : VsoRestAPIBase, IWorkItemAPI
    {
        /// <summary>
        /// Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItem>> GetWorkItems(IEnumerable<int> ids)
        {
            var result = await JsonWorkItemsInternal(ids);
            return result;
        }

        /// <summary>
        /// Gets the work item as JsonWorkItem. This is used privately to allow for manipulations
        /// that would not be feasible (without casting) using the IWorkItem interface.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonWorkItem&gt;&gt;.</returns>
        private async Task<IReadOnlyList<JsonWorkItem>> JsonWorkItemsInternal(IEnumerable<int> ids)
        {
            string request = "/wit/workitems?ids=" + ToCommaList(ids);

            IReadOnlyList<JsonWorkItem> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonWorkItem.FromToken));
            return result;
        }
    }
}
