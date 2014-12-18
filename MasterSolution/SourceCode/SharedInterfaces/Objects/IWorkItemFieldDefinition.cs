using System;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects
{
    /// <summary>
    ///     Represents a TFS/VSO WorkItem Field Definition
    /// </summary>
    public interface IWorkItemFieldDefinition
    {
        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        ///     Gets a value indicating whether [read o inly].
        /// </summary>
        /// <value><c>true</c> if [read o inly]; otherwise, <c>false</c>.</value>
        bool ReadOInly { get; }

        /// <summary>
        ///     Gets the name of the reference.
        /// </summary>
        /// <value>The name of the reference.</value>
        string ReferenceName { get; }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        Type Type { get; }
    }
}