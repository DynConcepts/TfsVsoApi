using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class RegisteredLinkTypeCollectionImpl.
    /// </summary>
    internal class RegisteredLinkTypeCollectionImpl : ReadOnlyListImpl<IRegisteredLinkType>, IRegisteredLinkTypeCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IRegisteredLinkTypeCollection.Contains(IRegisteredLinkType value) { return Items.Contains(value); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IRegisteredLinkTypeCollection.IndexOf(IRegisteredLinkType value) { return Items.IndexOf(value); }

        /// <summary>
        ///     Gets the <see cref="IRegisteredLinkType" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IRegisteredLinkType.</returns>
        IRegisteredLinkType IRegisteredLinkTypeCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Gets the <see cref="IRegisteredLinkType" /> with the specified registered type.
        /// </summary>
        /// <param name="registeredType">Type of the registered.</param>
        /// <returns>IRegisteredLinkType.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRegisteredLinkType IRegisteredLinkTypeCollection.this[IRegisteredLinkType registeredType] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IRegisteredLinkType" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IRegisteredLinkType.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IRegisteredLinkType IRegisteredLinkTypeCollection.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RegisteredLinkTypeCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected RegisteredLinkTypeCollectionImpl(IReadOnlyList<IRegisteredLinkType> items)
            : base(items) { }
    }
}