using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IBatchReadParameter
    /// </summary>
    public interface IBatchReadParameter
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets or sets the project hint.
        /// </summary>
        /// <value>The project hint.</value>
        Int32 ProjectHint { get; set; }
        /// <summary>
        /// Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        Int32 Revision { get; }
    }
}