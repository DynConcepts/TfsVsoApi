using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class BatchReadParameterCollectionImpl.
    /// </summary>
    internal class BatchReadParameterCollectionImpl : VariableSizeListImpl<IBatchReadParameter>, IBatchReadParameterCollection
    {
        /// <summary>
        ///     Adds.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.Int32.</returns>
        Int32 IBatchReadParameterCollection.Add(IBatchReadParameter item)
        {
            Items.Add(item);
            return Items.Count;
        }

        /// <summary>
        ///     Containses.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.Boolean.</returns>
        Boolean IBatchReadParameterCollection.Contains(Int32 id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException();  }

        /// <summary>
        ///     Containses.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.Boolean.</returns>
        Boolean IBatchReadParameterCollection.Contains(IBatchReadParameter item) { return Items.Contains(item); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.Int32.</returns>
        Int32 IBatchReadParameterCollection.IndexOf(IBatchReadParameter item) { return Items.IndexOf(item); }

        /// <summary>
        ///     Gets the <see cref="DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter" /> at the
        ///     specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBatchReadParameter.</returns>
        IBatchReadParameter IBatchReadParameterCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Removes.
        /// </summary>
        /// <param name="item">The item.</param>
        void IBatchReadParameterCollection.Remove(IBatchReadParameter item) { Items.Remove(item); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BatchReadParameterCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected BatchReadParameterCollectionImpl(IReadOnlyList<IBatchReadParameter> items)
            : base(items) { }
    }
}