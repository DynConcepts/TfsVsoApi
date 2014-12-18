using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class ProjectCollectionImpl.
    /// </summary>
    internal class ProjectCollectionImpl : ReadOnlyListImpl<IProject>, IProjectCollection
    {

        /// <summary>
        ///     Determines whether [contains] [the specified project name].
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IProjectCollection.Contains(String projectName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IProjectCollection.Contains(IProject value) { return Items.Contains(value); }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>IProject.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IProject IProjectCollection.GetById(Int32 projectId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IProjectCollection.IndexOf(IProject value) { return Items.IndexOf(value); }

        /// <summary>
        ///     Gets the <see cref="IProject" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IProject.</returns>
        IProject IProjectCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Gets the <see cref="IProject" /> with the specified project name.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>IProject.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IProject IProjectCollection.this[String projectName] {
            get
            {
                foreach (IProject item in Items)
                {
                    if (item.Name == projectName)
                        return item;
                }
                throw new KeyNotFoundException();
            } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        internal ProjectCollectionImpl(IReadOnlyList<IProject> items)
            : base(items) { }
    }
}