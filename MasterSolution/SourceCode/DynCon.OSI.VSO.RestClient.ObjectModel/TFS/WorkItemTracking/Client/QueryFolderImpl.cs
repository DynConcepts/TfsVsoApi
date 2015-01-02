using System;
using System.Collections;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryFolderImpl.
    /// </summary>
    internal class QueryFolderImpl : QueryItemImpl, IQueryFolder, IEnumerable
    {
        /// <summary>
        ///     Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IQueryFolder.Add(IQueryItem item) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryFolder.Contains(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryFolder.Contains(IQueryItem item) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryFolder.Contains(Guid id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IQueryFolder.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the is root node.
        /// </summary>
        /// <value>The is root node.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IQueryFolder.IsRootNode { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IQueryItem" /> with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IQueryItem.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryItem IQueryFolder.this[Guid id] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IQueryItem" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IQueryItem.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryItem IQueryFolder.this[String name] { get { throw new ToBeImplementedException(); } }
    }
}