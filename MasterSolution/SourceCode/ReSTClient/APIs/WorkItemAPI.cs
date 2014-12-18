using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.Objects;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    internal class WorkItemAPI : RestAPIBase 
    {
        /// <summary>
        /// Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        private async Task<IList<JsonWorkItem>> GetWorkItems(IEnumerable<int> ids)
        {
            string request = "/wit/workitems?ids=" + ToCommaList(ids);

            IList<JsonWorkItem> result = await ProcessGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonWorkItem.FromToken));
            return result;
        }
    }
}
