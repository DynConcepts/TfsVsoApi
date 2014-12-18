using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.SharedInterfaces.APIs
{
    /// <summary>
    ///     Interface IVSOApi
    /// </summary>
    public interface IVSOApi
    {
        /// <summary>
        ///     Gets the available rest calls.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IAvailableRestCalls&gt;&gt;.</returns>
        Task<IReadOnlyList<IAvailableRestCalls>> GetAvailableRestCalls();
    }
}