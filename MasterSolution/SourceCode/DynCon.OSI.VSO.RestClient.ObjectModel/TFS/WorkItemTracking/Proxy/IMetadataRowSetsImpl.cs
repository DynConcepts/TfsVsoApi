using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class IMetadataRowSetsImpl.
    /// </summary>
    internal class IMetadataRowSetsImpl : IIMetadataRowSets
    {
        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IIMetadataRowSets.Count { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IIRowSet" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IIRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIRowSet IIMetadataRowSets.this[IMetadataRowSetNames name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IIRowSet" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IIRowSet.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIRowSet IIMetadataRowSets.this[Int32 index] { get { throw new ToBeImplementedException(); } }
    }
}