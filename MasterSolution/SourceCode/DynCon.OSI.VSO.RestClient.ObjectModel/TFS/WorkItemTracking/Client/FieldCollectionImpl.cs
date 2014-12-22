using System;
using System.Collections.Generic;
using System.Linq;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldCollectionImpl.
    /// </summary>
    internal class FieldCollectionImpl : JsonFieldCollection, IFieldCollection
    {
        internal static FieldCollectionImpl FromToken(JToken token)
        {
            var instance = new FieldCollectionImpl(token);
            return instance;
        }

        protected FieldCollectionImpl(JToken json) : base(json) {
        }

        /// <summary>
        ///     Determines whether [contains] [the specified field name].
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IFieldCollection.Contains(String fieldName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IFieldCollection.Contains(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldCollection.Contains(IField value) { return ItemList.Contains((FieldImpl)value); }

        /// <summary>
        ///     Drops the cached data.
        /// </summary>
        /// <exception cref="ToBeImplementedException"></exception>
        void IFieldCollection.DropCachedData() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IField IFieldCollection.GetById(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldCollection.IndexOf(IField value) { return ItemList.IndexOf((FieldImpl)value); }

        /// <summary>
        ///     Gets the <see cref="IField" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IField.</returns>
        IField IFieldCollection.this[Int32 index] { get { return (IField) ItemList[index]; } }

        /// <summary>
        ///     Gets the <see cref="IField" /> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IField.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IField IFieldCollection.this[ICoreField coreField] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IField" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IField.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IField IFieldCollection.this[String name] { get { return (IField) ItemDictionary[name]; } }

        /// <summary>
        ///     Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IField IFieldCollection.TryGetById(Int32 id) { throw new ToBeImplementedException(); }

         private static readonly JsonBackedDictionary<IField> sr_Fields = new JsonBackedDictionary<IField>(String.Empty, FieldImpl.FromToken);
        protected override IReadOnlyList<JsonField> ItemSource { get { return sr_Fields.Eval(this).Values.Cast<JsonField>().ToList(); } }

        public bool IsFixedSize { get { throw new NotImplementedException(); } }

        public bool IsSynchronized { get { throw new NotImplementedException(); } }

        public object SyncRoot { get { throw new NotImplementedException(); } }
    }
}