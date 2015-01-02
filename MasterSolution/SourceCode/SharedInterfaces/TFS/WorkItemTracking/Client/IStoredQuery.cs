using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IStoredQuery
    /// </summary>
    public interface IStoredQuery : IComparable
    {
        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        /// <returns>Int32.</returns>
        Int32 CompareTo(IStoredQuery storedQuery);
        /// <summary>
        /// Resets this instance.
        /// </summary>
        void Reset();
        /// <summary>
        /// Updates this instance.
        /// </summary>
        void Update();
        /// <summary>
        /// Gets the creation time.
        /// </summary>
        /// <value>The creation time.</value>
        DateTime CreationTime { get; }
        /// <summary>
        /// Gets the creation time UTC.
        /// </summary>
        /// <value>The creation time UTC.</value>
        DateTime CreationTimeUtc { get; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; set; }
        /// <summary>
        /// Gets the is saved.
        /// </summary>
        /// <value>The is saved.</value>
        Boolean IsSaved { get; }
        /// <summary>
        /// Gets the last write time.
        /// </summary>
        /// <value>The last write time.</value>
        DateTime LastWriteTime { get; }
        /// <summary>
        /// Gets the last write time UTC.
        /// </summary>
        /// <value>The last write time UTC.</value>
        DateTime LastWriteTimeUtc { get; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        String Name { get; set; }
        /// <summary>
        /// Gets the owner.
        /// </summary>
        /// <value>The owner.</value>
        String Owner { get; }
        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <value>The project.</value>
        IProject Project { get; }
        /// <summary>
        /// Gets the query unique identifier.
        /// </summary>
        /// <value>The query unique identifier.</value>
        Guid QueryGuid { get; }
        /// <summary>
        /// Gets or sets the query scope.
        /// </summary>
        /// <value>The query scope.</value>
        IQueryScope QueryScope { get; set; }
        /// <summary>
        /// Gets or sets the query text.
        /// </summary>
        /// <value>The query text.</value>
        String QueryText { get; set; }
    }
}