using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldDefinitionCollectionImpl.
    /// </summary>
    internal class FieldDefinitionCollectionImpl : JsonFieldDefinitionCollection, IFieldDefinitionCollection
    {

        public new static FieldDefinitionCollectionImpl FromToken(JToken token)
        {
            var instance = new FieldDefinitionCollectionImpl(token);
            return instance;
        }

        private readonly ReadOnlyListImpl<IFieldDefinition> Items;

        public FieldDefinitionCollectionImpl(JToken json) : base(json)
        {
            var list = new List<IFieldDefinition>();
            foreach (JsonFieldDefinition  item in base.ItemList)
            {
                list.Add((FieldDefinitionImpl)item);
            }
            Items = new ReadOnlyListImpl<IFieldDefinition>(list);
        }


        protected override IReadOnlyList<JsonFieldDefinition> ItemSource { get
        {
            return sr_Fields.Eval(this);
        }
        }
        /// <summary>
        /// The SR_ fields
        /// </summary>
        private static readonly JsonBackedList<FieldDefinitionImpl> sr_Fields = new JsonBackedList<FieldDefinitionImpl>(token => JsonParsers.JArrayToObjects((JArray)token, FieldDefinitionImpl.FromToken));

        /// <summary>
        ///     Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IFieldDefinitionCollection.Contains(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        Boolean IFieldDefinitionCollection.Contains(Int32 id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified field definition].
        /// </summary>
        /// <param name="fieldDefinition">The field definition.</param>
        /// <returns>Boolean.</returns>
        Boolean IFieldDefinitionCollection.Contains(IFieldDefinition fieldDefinition) { return Items.Contains(fieldDefinition); }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.GetById(Int32 id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="fieldDefinition">The field definition.</param>
        /// <returns>Int32.</returns>
        Int32 IFieldDefinitionCollection.IndexOf(IFieldDefinition fieldDefinition) { return Items.IndexOf(fieldDefinition); }

        /// <summary>
        ///     Gets the <see cref="IFieldDefinition" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition IFieldDefinitionCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Gets the <see cref="IFieldDefinition" /> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.this[ICoreField coreField] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IFieldDefinition" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.this[String name] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }

        /// <summary>
        ///     Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.TryGetById(Int32 id) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

        /// <summary>
        ///     Tries the name of the get by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.TryGetByName(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }

      }
}