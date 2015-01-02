using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class RevisionCollectionImpl.
    /// </summary>
    internal class RevisionCollectionImpl : ReadOnlyListImpl<IRevision>, IRevisionCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IRevisionCollection.Contains(IRevision value) { return Items.Contains(value); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IRevisionCollection.IndexOf(IRevision value) { return Items.IndexOf(value); }

        /// <summary>
        ///     Gets the <see cref="IRevision" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IRevision.</returns>
        IRevision IRevisionCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RevisionCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        internal RevisionCollectionImpl(IReadOnlyList<IRevision> items)
            : base(items)
        {
            for (int index = 0; index < Items.Count; ++index)
                ((RevisionImpl) items[index]).SetIndex(index);
        }
    }
}