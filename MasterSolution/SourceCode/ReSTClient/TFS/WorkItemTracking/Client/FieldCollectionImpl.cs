using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldCollectionImpl.
    /// </summary>
    internal class FieldCollectionImpl : ReadOnlyListImpl<IField>, IFieldCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified field name].
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IFieldCollection.Contains(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IFieldCollection.Contains(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldCollection.Contains(IField value) { return Items.Contains(value); }

        /// <summary>
        ///     Drops the cached data.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IFieldCollection.DropCachedData() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IField IFieldCollection.GetById(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldCollection.IndexOf(IField value) { return Items.IndexOf(value); }

        /// <summary>
        ///     Gets the <see cref="IField" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Gets the <see cref="IField" /> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IField.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IField IFieldCollection.this[ICoreField coreField] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IField" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IField.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IField IFieldCollection.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IField IFieldCollection.TryGetById(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FieldCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected FieldCollectionImpl(IReadOnlyList<IField> items)
            : base(items) { }
    }
}