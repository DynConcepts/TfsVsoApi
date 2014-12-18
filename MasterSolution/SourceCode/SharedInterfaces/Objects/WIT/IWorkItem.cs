using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
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
        bool TryGetField(string knownFieldName, out IField fieldValue);

        /// <summary>
        ///     Gets the field names.
        /// </summary>
        /// <value>The field names.</value>
        IReadOnlyList<String> FieldNames { get; }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        ILinkCollection Links { get; }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        IFieldCollection Fields { get; }

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

        /// <summary>
        ///     Gets a WorkItemType object
        ///     that represents the type of this work item.
        /// </summary>
        /// <value>
        ///     A WorkItemType object that
        ///     represents the type of this work item.
        ///     Exceptions:
        ///     Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemTypeDeniedOrNotExistException:
        ///     The Type property is null.
        /// </value>
        IWorkItemType Type { get; }

        /// <summary>
        ///     Gets a WorkItemLinkCollection
        ///     object that represents a collection of the WorkItemLinks
        ///     that currently link to this work item.
        /// </summary>
        /// <value>
        ///     A WorkItemLinkCollection
        ///     object that represents a collection of the WorkItemLink
        ///     that currently link to this work item.
        /// </value>
        IWorkItemLinkCollection WorkItemLinks { get; }

        /// <summary>
        ///     Gets or sets the string value of the History field for this work item.
        /// </summary>
        /// <value>
        ///     The string value of the History field for this work item.
        /// </value>
        string History { get; set; }

        /// <summary>
        ///     Gets the collection.
        /// </summary>
        /// <value>The collection.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        IWorkItemCollection Collection { get; }

        /// <summary>
        ///     Validates the fields of this work item.
        /// </summary>
        /// <value>
        ///     True if all fields are valid. False if at least one field is not valid.
        /// </value>
        bool IsValid();

        /// <summary>
        ///     Opens this work item for modification.
        /// </summary>
        void Open();

        /// <summary>
        ///     Saves any pending changes on this work item.
        ///     Exceptions:
        ///     ValidationException:
        ///     Thrown when at least one field in this WorkItem instance has data that is
        ///     not valid.
        /// </summary>
        void Save();

        /// <summary>
        ///     Gets an ArrayList of fields in this work item that are not valid.
        /// </summary>
        /// <value>
        ///     An ArrayList of the fields in this work item that are not valid.
        /// </value>
        ArrayList Validate();

        /// <summary>
        ///     Gets or sets the value of a field in this work item that is specified by
        ///     the field name.
        ///     Parameters:
        ///     name:
        ///     The string that is passed in name could be either the field name or a reference
        ///     name.
        /// </summary>
        /// <value>
        ///     The object that is contained in this field.
        ///     Exceptions:
        ///     System.ArgumentNullException:
        ///     The name parameter is null.
        /// </value>
        object this[string name] { get; set; }
    }
}