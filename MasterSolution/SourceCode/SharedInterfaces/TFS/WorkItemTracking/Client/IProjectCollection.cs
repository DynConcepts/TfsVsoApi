using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IProjectCollection
    /// </summary>
    public interface IProjectCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified project name].
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String projectName);
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IProject value);
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>IProject.</returns>
        IProject GetById(Int32 projectId);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IProject value);
        /// <summary>
        /// Gets the <see cref="IProject"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IProject.</returns>
        IProject this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="IProject"/> with the specified project name.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>IProject.</returns>
        IProject this[String projectName] { get; }
    }
}