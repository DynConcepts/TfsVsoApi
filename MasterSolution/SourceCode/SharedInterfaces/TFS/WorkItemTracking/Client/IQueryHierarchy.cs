using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryHierarchy
    /// </summary>
    public interface IQueryHierarchy : IQueryFolder
    {
        /// <summary>
        /// Finds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryItem.</returns>
        IQueryItem Find(Guid id);
        /// <summary>
        /// Gets the refresh data.
        /// </summary>
        /// <returns>IQueryHierarchyRefreshData.</returns>
        IQueryHierarchyRefreshData GetRefreshData();
        /// <summary>
        /// Refreshes the specified refresh data.
        /// </summary>
        /// <param name="refreshData">The refresh data.</param>
        void Refresh(IQueryHierarchyRefreshData refreshData);
        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void Refresh();
        /// <summary>
        /// Resets this instance.
        /// </summary>
        void Reset();
        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();
        /// <summary>
        /// Gets the supports folders.
        /// </summary>
        /// <value>The supports folders.</value>
        Boolean SupportsFolders { get; }
        /// <summary>
        /// Gets the supports permissions.
        /// </summary>
        /// <value>The supports permissions.</value>
        Boolean SupportsPermissions { get; }
    }
}