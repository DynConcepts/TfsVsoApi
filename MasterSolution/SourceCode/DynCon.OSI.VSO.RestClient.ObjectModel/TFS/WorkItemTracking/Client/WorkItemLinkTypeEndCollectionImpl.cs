using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemLinkTypeEndCollectionImpl.
    /// </summary>
    internal class WorkItemLinkTypeEndCollectionImpl : IWorkItemLinkTypeEndCollection, IEnumerable
    {
        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkTypeEndCollection.Contains(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified link type name].
        /// </summary>
        /// <param name="linkTypeName">Name of the link type.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkTypeEndCollection.Contains(String linkTypeName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IWorkItemLinkTypeEndCollection.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IWorkItemLinkTypeEnd.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd IWorkItemLinkTypeEndCollection.GetById(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the <see cref="IWorkItemLinkTypeEnd" /> with the specified link type end name.
        /// </summary>
        /// <param name="linkTypeEndName">End name of the link type.</param>
        /// <returns>IWorkItemLinkTypeEnd.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemLinkTypeEnd IWorkItemLinkTypeEndCollection.this[String linkTypeEndName] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="linkTypeEnd">The link type end.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkTypeEndCollection.TryGetById(Int32 id, out IWorkItemLinkTypeEnd linkTypeEnd) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Tries the name of the get by.
        /// </summary>
        /// <param name="linkTypeEndName">End name of the link type.</param>
        /// <param name="linkTypeEnd">The link type end.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemLinkTypeEndCollection.TryGetByName(String linkTypeEndName, out IWorkItemLinkTypeEnd linkTypeEnd) { throw new ToBeImplementedException(); }
    }
}