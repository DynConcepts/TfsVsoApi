using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.SharedInterfaces.Interfaces
{
    /// <summary>
    /// Represents the TFS/VSO WorkItem ReST Service Calls
    /// </summary>
    public interface IWorkItemAPI
    {
        /// <summary>
        /// Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        Task<IReadOnlyList<IWorkItem>> GetWorkItems(IEnumerable<int> ids);
    }
}