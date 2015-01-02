using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemTypeCollectionImpl.
    /// </summary>
    internal class WorkItemTypeCollectionImpl : ReadOnlyListImpl<IWorkItemType>, IWorkItemTypeCollection
    {
        /// <summary>
        ///     Determines whether [contains] [the specified type name].
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IWorkItemTypeCollection.Contains(String typeName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IWorkItemTypeCollection.Contains(IWorkItemType value) { return Items.Contains(value); }

        /// <summary>
        ///     Imports the specified definition.
        /// </summary>
        /// <param name="definition">The definition.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemTypeCollection.Import(String definition) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified definition element.
        /// </summary>
        /// <param name="definitionElement">The definition element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemTypeCollection.Import(XmlElement definitionElement) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified definition.
        /// </summary>
        /// <param name="definition">The definition.</param>
        /// <param name="methodologyName">Name of the methodology.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemTypeCollection.Import(String definition, String methodologyName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Imports the specified definition element.
        /// </summary>
        /// <param name="definitionElement">The definition element.</param>
        /// <param name="methodologyName">Name of the methodology.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IWorkItemTypeCollection.Import(XmlElement definitionElement, String methodologyName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IWorkItemTypeCollection.IndexOf(IWorkItemType value) { return Items.IndexOf(value); }

        /// <summary>
        ///     Gets the <see cref="IWorkItemType" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemType.</returns>
        IWorkItemType IWorkItemTypeCollection.this[Int32 index] { get { return Items[index]; } }

        /// <summary>
        ///     Gets the <see cref="IWorkItemType" /> with the specified type name.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <returns>IWorkItemType.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IWorkItemType IWorkItemTypeCollection.this[String typeName] { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemTypeCollectionImpl" /> class.
        /// </summary>
        /// <param name="items">The items.</param>
        internal WorkItemTypeCollectionImpl(IReadOnlyList<IWorkItemType> items) : base(items) { }
    }
}