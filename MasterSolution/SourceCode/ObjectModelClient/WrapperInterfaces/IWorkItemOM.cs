using System;
using System.Collections;
using System.ComponentModel;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces
{
    /// <summary>
    ///     Interface IWorkItemOM
    /// </summary>
    public interface IWorkItemOM : IWorkItem
    {
        /// <summary>
        ///     Applies the rules.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void ApplyRules();

        /// <summary>
        ///     Applies the rules.
        /// </summary>
        /// <param name="copyChangedByFromLatest">if set to <c>true</c> [copy changed by from latest].</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void ApplyRules(bool copyChangedByFromLatest);

        /// <summary>
        ///     Calculates the field lists.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void CalculateFieldLists(int fieldId);

        /// <summary>
        ///     Closes this WorkItem instance and frees memory that is associated with it.
        /// </summary>
        void Close();

        /// <summary>
        ///     Creates a copy of this WorkItem instance.
        /// </summary>
        /// <value>
        ///     A new WorkItem instance that is a copy of this WorkItem instance.
        /// </value>
        IWorkItem Copy();

        /// <summary>
        ///     Creates a copy of this WorkItem instance that is of the specified WorkItemType.
        ///     Parameters:
        ///     targetType:
        ///     The type of the target work item.
        /// </summary>
        /// <value>
        ///     A new WorkItem instance of the specified WorkItemType
        ///     that is a copy of this WorkItem instance.
        ///     Exceptions:
        ///     System.ArgumentNullException:
        ///     Thrown when targetType is null.
        /// </value>
        IWorkItem Copy(IWorkItemType targetType);

        /// <summary>
        ///     Creates a copy of this WorkItem instance that is of the specified WorkItemType.
        ///     Parameters:
        ///     targetType:
        ///     The type of the target work item.
        ///     flags:
        ///     Flags that specify items to copy in addition to fields.
        /// </summary>
        /// <value>
        ///     A new WorkItem instance of the specified WorkItemType
        ///     that is a copy of this WorkItem instance.
        ///     Exceptions:
        ///     System.ArgumentNullException:
        ///     Thrown when targetType is null.
        /// </value>
        IWorkItem Copy(IWorkItemType targetType, WorkItemCopyFlags flags);

        /// <summary>
        ///     Gets the action object.
        /// </summary>
        /// <param name="actionInfo">The action information.</param>
        /// <returns>System.Object.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object GetActionObject(WorkItem.EditActionInfo actionInfo);

        /// <summary>
        ///     Gets the actions history.
        /// </summary>
        /// <returns>Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem.EditActionSet[].</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        WorkItem.EditActionSet[] GetActionsHistory();

        /// <summary>
        ///     Gets the field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>System.Object.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object GetFieldValue(int id, int revision);

        /// <summary>
        ///     Gets the field value external.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>System.Object.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object GetFieldValueExternal(FieldDefinition fd, int revision);

        /// <summary>
        ///     Gets the latest synchronize data.
        /// </summary>
        /// <returns>Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemSyncData.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        WorkItemSyncData GetLatestSyncData();

        /// <summary>
        ///     Gets the next state of this work item based on the action of a user.
        ///     Parameters:
        ///     action:
        ///     The action of the user.
        /// </summary>
        /// <value>
        ///     The next state of this work item.
        /// </value>
        string GetNextState(string action);

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
        ///     Opens this work item for modification when transmitting minimal amounts of
        ///     data over the network.
        ///     Exceptions:
        ///     ValidationException:
        ///     This WorkItem instance does not belong to A WorkItemCollection.
        ///     DeniedOrNotExistException:
        ///     This WorkItem instance could not be opened for edit correctly.
        /// </summary>
        void PartialOpen();

        /// <summary>
        ///     Reverts all changes that were made since the last save.
        /// </summary>
        void Reset();

        /// <summary>
        ///     Saves any pending changes on this work item.
        ///     Exceptions:
        ///     ValidationException:
        ///     Thrown when at least one field in this WorkItem instance has data that is
        ///     not valid.
        /// </summary>
        void Save();

        /// <summary>
        ///     Saves any pending changes on this work item.
        ///     Parameters:
        ///     saveFlags:
        ///     If set to SaveFlags.MergeLinks,
        ///     does not return errors if the link that is being added already exists or
        ///     the link that is being removed was already removed.
        ///     Exceptions:
        ///     ValidationException:
        ///     Thrown when at least one field in this WorkItem instance has data that is
        ///     not valid.
        /// </summary>
        void Save(SaveFlags saveFlags);

        /// <summary>
        ///     Temporarily overrides the dirty state of a work item. Any modification to
        ///     the work item will cause this to be reset to the correct value, depending
        ///     on the work item's modification state.
        /// </summary>
        void SetDirty(bool isDirty);

        /// <summary>
        ///     Synchronizes the work item to the latest revision.
        /// </summary>
        void SyncToLatest();

        /// <summary>
        ///     Synchronizes the work item.
        /// </summary>
        /// <param name="syncData">The synchronize data.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SyncWorkItem(WorkItemSyncData syncData);

        /// <summary>
        ///     Gets an ArrayList of fields in this work item that are not valid.
        /// </summary>
        /// <value>
        ///     An ArrayList of the fields in this work item that are not valid.
        /// </value>
        ArrayList Validate();

        /// <summary>
        ///     Gets or sets the integer value of the AreaId field for this work item.
        /// </summary>
        /// <value>
        ///     The integer value of the AreaId field for this work item.
        /// </value>
        int AreaId { get; set; }

        /// <summary>
        ///     Gets or sets the string value of the AreaPath field for this work item.
        /// </summary>
        /// <value>
        ///     The string value of the AreaPath field for this work item.
        /// </value>
        string AreaPath { get; set; }

        /// <summary>
        ///     Gets the number of attached files for this work item.
        /// </summary>
        /// <value>
        ///     The number of attached files for this work item.
        /// </value>
        int AttachedFileCount { get; }

        /// <summary>
        ///     Gets the AttachmentCollection
        ///     object that represents the attachments that belong to this work item.
        /// </summary>
        /// <value>
        ///     The AttachmentCollection
        ///     object that represents the attachments that belong to this work item.
        /// </value>
        IAttachmentCollectionOM Attachments { get; }

        /// <summary>
        ///     Gets the authorized date.
        /// </summary>
        /// <value>The authorized date.</value>
        DateTime AuthorizedDate { get; }

        /// <summary>
        ///     Gets the string value of the ChangedBy field for this work item.
        /// </summary>
        /// <value>
        ///     The string value of the ChangedBy field of this work item.
        /// </value>
        string ChangedBy { get; }

        /// <summary>
        ///     Gets the System.DateTime object that represents the date and time that this
        ///     work item was last changed.
        /// </summary>
        /// <value>
        ///     The System.DateTime object that represents the date and time that this work
        ///     item was last changed.
        /// </value>
        DateTime ChangedDate { get; }

        /// <summary>
        ///     Gets the collection.
        /// </summary>
        /// <value>The collection.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        IWorkItemCollectionOM Collection { get; }

        /// <summary>
        ///     Gets the string value of the CreatedBy field for this work item.
        /// </summary>
        /// <value>
        ///     The string value of the CreatedBy of this work item.
        /// </value>
        string CreatedBy { get; }

        /// <summary>
        ///     Gets the System.DateTime object that represents the date and time that this
        ///     work item was created.
        /// </summary>
        /// <value>
        ///     The System.DateTime object that represents the date and time that this work
        ///     item was created.
        /// </value>
        DateTime CreatedDate { get; }

        /// <summary>
        ///     Gets or sets a string that describes this work item.
        /// </summary>
        /// <value>
        ///     A string that describes this work item.
        /// </value>
        string Description { get; set; }

        /// <summary>
        ///     Gets the display form that is associated with this work item.
        /// </summary>
        /// <value>
        ///     The display form that is associated with this work item.
        /// </value>
        string DisplayForm { get; }

        /// <summary>
        ///     Gets the number of external links in this work item.
        /// </summary>
        /// <value>
        ///     The number of external links in this work item.
        /// </value>
        int ExternalLinkCount { get; }

        /// <summary>
        ///     Gets the field data.
        /// </summary>
        /// <value>The field data.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        WorkItemFieldData FieldData { get; }

        /// <summary>
        ///     Gets or sets the string value of the History field for this work item.
        /// </summary>
        /// <value>
        ///     The string value of the History field for this work item.
        /// </value>
        string History { get; set; }

        /// <summary>
        ///     Gets the number of hyperlinks in this work item.
        /// </summary>
        /// <value>
        ///     The number of hyperlinks in this work item.
        /// </value>
        int HyperLinkCount { get; }

        /// <summary>
        ///     Gets the ID of this work item.
        /// </summary>
        /// <value>
        ///     The ID of this work item.
        /// </value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        int InternalVersion { get; }

        /// <summary>
        ///     Gets a value indicating whether this instance is access denied.
        /// </summary>
        /// <value><c>true</c> if this instance is access denied; otherwise, <c>false</c>.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool IsAccessDenied { get; }

        /// <summary>
        ///     Gets a flag that describes whether this work item has been changed since
        ///     its last save.
        /// </summary>
        /// <value>
        ///     True if the item has been changed since its last save; otherwise, false.
        /// </value>
        bool IsDirty { get; }

        /// <summary>
        ///     Gets a flag that describes whether this work item is new.
        /// </summary>
        /// <value>
        ///     True if this work item is new; otherwise, false.
        /// </value>
        bool IsNew { get; }

        /// <summary>
        ///     Gets a flag that describes whether this work item is currently open for edit.
        /// </summary>
        /// <value>
        ///     True if this work item is open for edit; otherwise, false.
        /// </value>
        bool IsOpen { get; }

        /// <summary>
        ///     Gets a flag that describes whether the work item is partially opened.
        /// </summary>
        /// <value>
        ///     True if the work item is partially open; otherwise, false.
        /// </value>
        bool IsPartialOpen { get; }

        /// <summary>
        ///     Gets a flag that describes whether the work item is read-only.
        /// </summary>
        /// <value>
        ///     True if the work item is read-only; otherwise, false.
        /// </value>
        bool IsReadOnly { get; }

        /// <summary>
        ///     Gets a flag that describes whether the work item is open as read-only.
        /// </summary>
        /// <value>
        ///     True if the work item is open as read-only; otherwise, false.
        /// </value>
        bool IsReadOnlyOpen { get; }

        /// <summary>
        ///     Gets or sets the value of a field in this work item that is specified by
        ///     the field ID.
        ///     Parameters:
        ///     id:
        ///     The field ID.
        /// </summary>
        /// <value>
        ///     The object that is contained by the specified field.
        ///     Exceptions:
        ///     System.ArgumentNullException:
        ///     The id parameter is null.
        /// </value>
        object this[CoreField id] { get; set; }

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

        /// <summary>
        ///     Gets or sets the integer value of the IterationId field of this work item.
        /// </summary>
        /// <value>
        ///     The integer value of the IterationId of this work item.
        /// </value>
        int IterationId { get; set; }

        /// <summary>
        ///     Gets or sets the string value of the IterationPath field of this work item.
        /// </summary>
        /// <value>
        ///     The string value of the IterationPath of this work item.
        /// </value>
        string IterationPath { get; set; }

        /// <summary>
        ///     Gets the link data.
        /// </summary>
        /// <value>The link data.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        WorkItemLinkData LinkData { get; }

        /// <summary>
        ///     Gets the collection of the links in this work item.
        /// </summary>
        /// <value>
        ///     The collection of links in this work item.
        /// </value>
        new ILinkCollectionOM Links { get; }

        /// <summary>
        ///     Gets or sets the string value of the NodeName field of this work item.
        /// </summary>
        /// <value>
        ///     The string value of the NodeName of this work item.
        /// </value>
        string NodeName { get; }

        /// <summary>
        ///     Gets the current project that is associated with this work item.
        /// </summary>
        /// <value>
        ///     The current project that is associated with this work item.
        ///     Exceptions:
        ///     DeniedOrNotExistException:
        ///     The Project field is null.
        /// </value>
        Project Project { get; }

        /// <summary>
        ///     Gets or sets the string value of the Reason field for this work item.
        /// </summary>
        /// <value>
        ///     The string value of the Reason of this work item.
        /// </value>
        string Reason { get; set; }

        /// <summary>
        ///     Gets the number of related links of this work item.
        /// </summary>
        /// <value>
        ///     The number of related links of this work item.
        /// </value>
        int RelatedLinkCount { get; }

        /// <summary>
        ///     Gets a System.DateTime object that represents the revision date and time
        ///     of this work item.
        /// </summary>
        /// <value>
        ///     A System.DateTime object that represents the revision date and time of this
        ///     work item.
        /// </value>
        DateTime RevisedDate { get; }

        /// <summary>
        ///     Gets the integer that represents the revision number of this work item.
        /// </summary>
        /// <value>
        ///     The integer that represents the revision number of this work item.
        /// </value>
        int Revision { get; }

        /// <summary>
        ///     Gets a RevisionCollection
        ///     object that represents a collection of valid revision numbers for this work
        ///     item.
        /// </summary>
        /// <value>
        ///     A RevisionCollection object
        ///     that represents a collection of valid revision numbers for this work item.
        /// </value>
        IRevisionCollectionOM Revisions { get; }

        /// <summary>
        ///     Gets or sets a string that describes the state of this work item.
        /// </summary>
        /// <value>
        ///     A string that describes the state of this work item.
        /// </value>
        string State { get; set; }

        /// <summary>
        ///     Gets the WorkItemStore to
        ///     which this work item belongs.
        /// </summary>
        /// <value>
        ///     The WorkItemStore to which
        ///     this work item belongs.
        /// </value>
        WorkItemStore Store { get; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        string Tags { get; set; }

        /// <summary>
        ///     Gets the temporary ID of this work item.
        /// </summary>
        /// <value>
        ///     The temporary ID of this work item.
        /// </value>
        int TemporaryId { get; }

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
        ///     Gets the uniform resource identifier (System.Uri) of this work item.
        /// </summary>
        /// <value>
        ///     The System.Uri of this work item.
        /// </value>
        Uri Uri { get; }

        /// <summary>
        ///     Gets the watermark.
        /// </summary>
        /// <value>The watermark.</value>
        int Watermark { get; }

        /// <summary>
        ///     Gets a WorkItemLinkCollection
        ///     object that represents a collection of the WorkItemLinks
        ///     that link to this work item now or linked to it in the past.
        /// </summary>
        /// <value>
        ///     A WorkItemLinkCollection
        ///     object that represents a collection of the WorkItemLinks
        ///     that link to this work item now or linked to it in the past.
        /// </value>
        WorkItemLinkCollection WorkItemLinkHistory { get; }

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
        WorkItemLinkCollection WorkItemLinks { get; }

        /// <summary>
        ///     Occurs when a field is updated in this WorkItem instance.
        /// </summary>
        event WorkItemFieldChangeEventHandler FieldChanged;

        /// <summary>
        ///     The event gets fired every time that the work item is about to be saved.
        /// </summary>
        /// s
        event WorkItemPreSaveEventHandler Saving;
    }
}