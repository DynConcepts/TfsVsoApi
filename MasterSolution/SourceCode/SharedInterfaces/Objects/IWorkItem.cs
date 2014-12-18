using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects
{
    /// <summary>
    ///     Represents a TFS/VSO WorkItem
    /// </summary>
    public interface IWorkItem
    {
        /// <summary>
        ///     Changes the type of the work item.
        /// </summary>
        /// <param name="workItemType">Type of the work item.</param>
        void ChangeWorkItemType(string workItemType);

        /// <summary>
        ///     Gets the type of the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Type.</returns>
        Type GetFieldType(string fieldName);

        /// <summary>
        ///     Tries the get field.
        /// </summary>
        /// <param name="knownFieldName">Name of the known field.</param>
        /// <param name="fieldValue">The field value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool TryGetField(string knownFieldName, out object fieldValue);

        /// <summary>
        ///     Gets the field names.
        /// </summary>
        /// <value>The field names.</value>
        IReadOnlyList<String> FieldNames { get; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        IReadOnlyList<ILink> Links { get; }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        IReadOnlyDictionary<string, object> Fields { get; }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }

        /// <summary>
        ///     Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        int Rev { get; }

        /// <summary>
        ///     Gets the title.
        /// </summary>
        /// <value>The title.</value>
        string Title { get; set; }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        string Url { get; }

        /// <summary>
        ///     Gets the type of the work item.
        /// </summary>
        /// <value>The type of the work item.</value>
        string WorkItemType { get; }
    }
}