using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IWorkItem
    /// </summary>
    public interface IWorkItem
    {
        /// <summary>
        /// Applies the rules.
        /// </summary>
        /// <param name="copyChangedByFromLatest">The copy changed by from latest.</param>
        void ApplyRules(Boolean copyChangedByFromLatest);
        /// <summary>
        /// Applies the rules.
        /// </summary>
        void ApplyRules();
        /// <summary>
        /// Calculates the field lists.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        void CalculateFieldLists(Int32 fieldId);
        /// <summary>
        /// Closes this instance.
        /// </summary>
        void Close();
        /// <summary>
        /// Copies the specified target type.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem Copy(IWorkItemType targetType, IWorkItemCopyFlags flags);
        /// <summary>
        /// Copies the specified target type.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <returns>IWorkItem.</returns>
        IWorkItem Copy(IWorkItemType targetType);
        /// <summary>
        /// Copies this instance.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        IWorkItem Copy();
        /// <summary>
        /// Gets the action object.
        /// </summary>
        /// <param name="actionInfo">The action information.</param>
        /// <returns>Object.</returns>
        Object GetActionObject(IWorkItem_EditActionInfo actionInfo);
        /// <summary>
        /// Gets the actions history.
        /// </summary>
        /// <returns>IWorkItem_EditActionSet[].</returns>
        IWorkItem_EditActionSet[] GetActionsHistory();
        /// <summary>
        /// Gets the field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>Object.</returns>
        Object GetFieldValue(Int32 id, Int32 revision);
        /// <summary>
        /// Gets the field value external.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>Object.</returns>
        Object GetFieldValueExternal(IFieldDefinition fd, Int32 revision);
        /// <summary>
        /// Gets the latest synchronize data.
        /// </summary>
        /// <returns>IWorkItemSyncData.</returns>
        IWorkItemSyncData GetLatestSyncData();
        /// <summary>
        /// Gets the state of the next.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>String.</returns>
        String GetNextState(String action);
        /// <summary>
        /// Determines whether this instance is valid.
        /// </summary>
        /// <returns>Boolean.</returns>
        Boolean IsValid();
        /// <summary>
        /// Opens this instance.
        /// </summary>
        void Open();
        /// <summary>
        /// Partials the open.
        /// </summary>
        void PartialOpen();
        /// <summary>
        /// Resets this instance.
        /// </summary>
        void Reset();
        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();
        /// <summary>
        /// Saves the specified save flags.
        /// </summary>
        /// <param name="saveFlags">The save flags.</param>
        void Save(ISaveFlags saveFlags);
        /// <summary>
        /// Sets the dirty.
        /// </summary>
        /// <param name="isDirty">The is dirty.</param>
        void SetDirty(Boolean isDirty);
        /// <summary>
        /// Synchronizes to latest.
        /// </summary>
        void SyncToLatest();
        /// <summary>
        /// Synchronizes the work item.
        /// </summary>
        /// <param name="syncData">The synchronize data.</param>
        void SyncWorkItem(IWorkItemSyncData syncData);
        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <returns>ArrayList.</returns>
        ArrayList Validate();
        /// <summary>
        /// Gets or sets the area identifier.
        /// </summary>
        /// <value>The area identifier.</value>
        Int32 AreaId { get; set; }
        /// <summary>
        /// Gets or sets the area path.
        /// </summary>
        /// <value>The area path.</value>
        String AreaPath { get; set; }
        /// <summary>
        /// Gets the attached file count.
        /// </summary>
        /// <value>The attached file count.</value>
        Int32 AttachedFileCount { get; }
        /// <summary>
        /// Gets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        IAttachmentCollection Attachments { get; }
        /// <summary>
        /// Gets the authorized date.
        /// </summary>
        /// <value>The authorized date.</value>
        DateTime AuthorizedDate { get; }
        /// <summary>
        /// Gets the changed by.
        /// </summary>
        /// <value>The changed by.</value>
        String ChangedBy { get; }
        /// <summary>
        /// Gets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        DateTime ChangedDate { get; }
        /// <summary>
        /// Gets the collection.
        /// </summary>
        /// <value>The collection.</value>
        IWorkItemCollection Collection { get; }
        /// <summary>
        /// Gets the created by.
        /// </summary>
        /// <value>The created by.</value>
        String CreatedBy { get; }
        /// <summary>
        /// Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        DateTime CreatedDate { get; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; set; }
        /// <summary>
        /// Gets the display form.
        /// </summary>
        /// <value>The display form.</value>
        String DisplayForm { get; }
        /// <summary>
        /// Gets the external link count.
        /// </summary>
        /// <value>The external link count.</value>
        Int32 ExternalLinkCount { get; }
        /// <summary>
        /// Gets the field data.
        /// </summary>
        /// <value>The field data.</value>
        IWorkItemFieldData FieldData { get; }
        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        IFieldCollection Fields { get; }
        /// <summary>
        /// Gets or sets the history.
        /// </summary>
        /// <value>The history.</value>
        String History { get; set; }
        /// <summary>
        /// Gets the hyper link count.
        /// </summary>
        /// <value>The hyper link count.</value>
        Int32 HyperLinkCount { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Int32 Id { get; }
        /// <summary>
        /// Gets the internal version.
        /// </summary>
        /// <value>The internal version.</value>
        Int32 InternalVersion { get; }
        /// <summary>
        /// Gets the is access denied.
        /// </summary>
        /// <value>The is access denied.</value>
        Boolean IsAccessDenied { get; }
        /// <summary>
        /// Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        Boolean IsDirty { get; }
        /// <summary>
        /// Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        Boolean IsNew { get; }
        /// <summary>
        /// Gets the is open.
        /// </summary>
        /// <value>The is open.</value>
        Boolean IsOpen { get; }
        /// <summary>
        /// Gets the is partial open.
        /// </summary>
        /// <value>The is partial open.</value>
        Boolean IsPartialOpen { get; }
        /// <summary>
        /// Gets the is read only.
        /// </summary>
        /// <value>The is read only.</value>
        Boolean IsReadOnly { get; }
        /// <summary>
        /// Gets the is read only open.
        /// </summary>
        /// <value>The is read only open.</value>
        Boolean IsReadOnlyOpen { get; }
        /// <summary>
        /// Gets or sets the <see cref="Object"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        Object this[String name] { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="Object"/> with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Object.</returns>
        Object this[ICoreField id] { get; set; }
        /// <summary>
        /// Gets or sets the iteration identifier.
        /// </summary>
        /// <value>The iteration identifier.</value>
        Int32 IterationId { get; set; }
        /// <summary>
        /// Gets or sets the iteration path.
        /// </summary>
        /// <value>The iteration path.</value>
        String IterationPath { get; set; }
        /// <summary>
        /// Gets the link data.
        /// </summary>
        /// <value>The link data.</value>
        IWorkItemLinkData LinkData { get; }
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        ILinkCollection Links { get; }
        /// <summary>
        /// Gets the name of the node.
        /// </summary>
        /// <value>The name of the node.</value>
        String NodeName { get; }
        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <value>The project.</value>
        IProject Project { get; }
        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        String Reason { get; set; }
        /// <summary>
        /// Gets the related link count.
        /// </summary>
        /// <value>The related link count.</value>
        Int32 RelatedLinkCount { get; }
        /// <summary>
        /// Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        Int32 Rev { get; }
        /// <summary>
        /// Gets the revised date.
        /// </summary>
        /// <value>The revised date.</value>
        DateTime RevisedDate { get; }
        /// <summary>
        /// Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        Int32 Revision { get; }
        /// <summary>
        /// Gets the revisions.
        /// </summary>
        /// <value>The revisions.</value>
        IRevisionCollection Revisions { get; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        String State { get; set; }
        /// <summary>
        /// Gets the store.
        /// </summary>
        /// <value>The store.</value>
        IWorkItemStore Store { get; }
        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        String Tags { get; set; }
        /// <summary>
        /// Gets the temporary identifier.
        /// </summary>
        /// <value>The temporary identifier.</value>
        Int32 TemporaryId { get; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        String Title { get; set; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        IWorkItemType Type { get; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
        /// <summary>
        /// Gets the watermark.
        /// </summary>
        /// <value>The watermark.</value>
        Int32 Watermark { get; }
        /// <summary>
        /// Gets the work item link history.
        /// </summary>
        /// <value>The work item link history.</value>
        IWorkItemLinkCollection WorkItemLinkHistory { get; }
        /// <summary>
        /// Gets the work item links.
        /// </summary>
        /// <value>The work item links.</value>
        IWorkItemLinkCollection WorkItemLinks { get; }
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItem_EditActionSet
    {
    }
}

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItem_EditActionInfo
    {
    }
}