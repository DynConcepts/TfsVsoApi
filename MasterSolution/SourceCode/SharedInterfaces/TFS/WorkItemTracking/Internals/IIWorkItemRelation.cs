using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals
{
    /// <summary>
    /// Interface IIWorkItemRelation
    /// </summary>
    public interface IIWorkItemRelation
    {
        /// <summary>
        /// Gets or sets the is locked.
        /// </summary>
        /// <value>The is locked.</value>
        Boolean IsLocked { get; set; }
        /// <summary>
        /// Gets or sets the link type identifier.
        /// </summary>
        /// <value>The link type identifier.</value>
        Int32 LinkTypeID { get; set; }
        /// <summary>
        /// Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        Int32 SourceID { get; set; }
        /// <summary>
        /// Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        Int32 TargetID { get; set; }
    }
}