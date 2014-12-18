using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class FieldDefinitionCollectionImpl.
    /// </summary>
    internal class FieldDefinitionCollectionImpl : ReadOnlyListImpl<IFieldDefinition>, IFieldDefinitionCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IFieldDefinitionCollection.Contains(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IFieldDefinitionCollection.Contains(Int32 id) { throw new ToBeImplementedException(); }

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
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.GetById(Int32 id) { throw new ToBeImplementedException(); }

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
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.this[ICoreField coreField] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the <see cref="IFieldDefinition" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.this[String name] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.TryGetById(Int32 id) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Tries the name of the get by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IFieldDefinition IFieldDefinitionCollection.TryGetByName(String name) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FieldDefinitionCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        protected FieldDefinitionCollectionImpl(IReadOnlyList<IFieldDefinition> items)
            : base(items) { }
    }
}