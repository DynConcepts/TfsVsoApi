using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItemTypeCollection
    /// </summary>
    public interface IWorkItemTypeCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified type name].
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String typeName);
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IWorkItemType value);
        /// <summary>
        /// Imports the specified definition.
        /// </summary>
        /// <param name="definition">The definition.</param>
        void Import(String definition);
        /// <summary>
        /// Imports the specified definition element.
        /// </summary>
        /// <param name="definitionElement">The definition element.</param>
        void Import(XmlElement definitionElement);
        /// <summary>
        /// Imports the specified definition.
        /// </summary>
        /// <param name="definition">The definition.</param>
        /// <param name="methodologyName">Name of the methodology.</param>
        void Import(String definition, String methodologyName);
        /// <summary>
        /// Imports the specified definition element.
        /// </summary>
        /// <param name="definitionElement">The definition element.</param>
        /// <param name="methodologyName">Name of the methodology.</param>
        void Import(XmlElement definitionElement, String methodologyName);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IWorkItemType value);
        /// <summary>
        /// Gets the <see cref="IWorkItemType"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IWorkItemType.</returns>
        IWorkItemType this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="IWorkItemType"/> with the specified type name.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <returns>IWorkItemType.</returns>
        IWorkItemType this[String typeName] { get; }
    }
}