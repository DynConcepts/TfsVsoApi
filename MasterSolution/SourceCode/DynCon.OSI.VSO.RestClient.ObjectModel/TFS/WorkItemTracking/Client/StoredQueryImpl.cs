using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class StoredQueryImpl.
    /// </summary>
    internal class StoredQueryImpl : IStoredQuery, IComparable
    {
        /// <summary>
        ///     Compares to.
        /// </summary>
        /// <param name="storedQuery">The stored query.</param>
        /// <returns>Int32.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IStoredQuery.CompareTo(IStoredQuery storedQuery) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Compares the current instance with another object of the same type and returns an integer that indicates whether
        ///     the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        ///     A value that indicates the relative order of the objects being compared. The return value has these meanings:
        ///     Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance
        ///     occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows
        ///     <paramref name="obj" /> in the sort order.
        /// </returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IComparable.CompareTo(Object obj) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the creation time.
        /// </summary>
        /// <value>The creation time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IStoredQuery.CreationTime { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the creation time UTC.
        /// </summary>
        /// <value>The creation time UTC.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IStoredQuery.CreationTimeUtc { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IStoredQuery.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is saved.
        /// </summary>
        /// <value>The is saved.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IStoredQuery.IsSaved { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the last write time.
        /// </summary>
        /// <value>The last write time.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IStoredQuery.LastWriteTime { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the last write time UTC.
        /// </summary>
        /// <value>The last write time UTC.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        DateTime IStoredQuery.LastWriteTimeUtc { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IStoredQuery.Name { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the owner.
        /// </summary>
        /// <value>The owner.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IStoredQuery.Owner { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <value>The project.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IProject IStoredQuery.Project { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the query unique identifier.
        /// </summary>
        /// <value>The query unique identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Guid IStoredQuery.QueryGuid { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the query scope.
        /// </summary>
        /// <value>The query scope.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IQueryScope IStoredQuery.QueryScope { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the query text.
        /// </summary>
        /// <value>The query text.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IStoredQuery.QueryText { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Resets this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IStoredQuery.Reset() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Updates this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IStoredQuery.Update() { throw new ToBeImplementedException(); }
    }
}