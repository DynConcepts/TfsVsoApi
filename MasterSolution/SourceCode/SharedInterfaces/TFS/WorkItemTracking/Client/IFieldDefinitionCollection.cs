using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IFieldDefinitionCollection
    /// </summary>
    public interface IFieldDefinitionCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified name].
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String name);
        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(Int32 id);
        /// <summary>
        /// Determines whether [contains] [the specified field definition].
        /// </summary>
        /// <param name="fieldDefinition">The field definition.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IFieldDefinition fieldDefinition);
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition GetById(Int32 id);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="fieldDefinition">The field definition.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IFieldDefinition fieldDefinition);
        /// <summary>
        /// Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition TryGetById(Int32 id);
        /// <summary>
        /// Tries the name of the get by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition TryGetByName(String name);
        /// <summary>
        /// Gets the <see cref="IFieldDefinition"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="IFieldDefinition"/> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition this[ICoreField coreField] { get; }
        /// <summary>
        /// Gets the <see cref="IFieldDefinition"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IFieldDefinition.</returns>
        IFieldDefinition this[String name] { get; }
    }
}