using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

// ReSharper disable EmptyNamespace

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
// ReSharper restore EmptyNamespace
{
    /// <summary>
    ///     Class WorkItemWrapper.
    /// </summary>
    internal class WorkItemWrapper : MappedObjectBase<IWorkItemOM, WorkItem>, IWorkItemOM
    {
        public static void SetMapper() { Mapper = new ObjectMapper<IWorkItemOM, WorkItem>(src => ((WorkItemWrapper) src).r_Instance, src => new WorkItemWrapper(src)); }

        /// <summary>
        ///     Applies the rules.
        /// </summary>
        public void ApplyRules() { r_Instance.ApplyRules(); }

        /// <summary>
        ///     Applies the rules.
        /// </summary>
        /// <param name="copyChangedByFromLatest">if set to <c>true</c> [copy changed by from latest].</param>
        public void ApplyRules(bool copyChangedByFromLatest) { r_Instance.ApplyRules(copyChangedByFromLatest); }

        /// <summary>
        ///     Calculates the field lists.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        public void CalculateFieldLists(int fieldId) { r_Instance.CalculateFieldLists(fieldId); }

        /// <summary>
        ///     Changes the type of the work item.
        /// </summary>
        /// <param name="workItemType">Type of the work item.</param>
        /// <exception cref="System.NotSupportedException"></exception>
        public void ChangeWorkItemType(string workItemType) { throw new NotSupportedException(); }

        /// <summary>
        ///     Closes this instance.
        /// </summary>
        public void Close() { r_Instance.Close(); }

        /// <summary>
        ///     Copies this instance.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        public IWorkItem Copy() { return new WorkItemWrapper(r_Instance.Copy()); }

        /// <summary>
        ///     Copies the specified target type.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <returns>IWorkItem.</returns>
        public IWorkItem Copy(IWorkItemType targetType) { return new WorkItemWrapper(r_Instance.Copy(WorkItemTypeWrapper.GetInstance(targetType))); }

        /// <summary>
        ///     Copies the specified target type.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>IWorkItem.</returns>
        public IWorkItem Copy(IWorkItemType targetType, WorkItemCopyFlags flags) { return new WorkItemWrapper(r_Instance.Copy(WorkItemTypeWrapper.GetInstance(targetType), flags)); }

        /// <summary>
        ///     Gets the action object.
        /// </summary>
        /// <param name="actionInfo">The action information.</param>
        /// <returns>System.Object.</returns>
        public object GetActionObject(WorkItem.EditActionInfo actionInfo) { return r_Instance.GetActionObject(actionInfo); }

        /// <summary>
        ///     Gets the actions history.
        /// </summary>
        /// <returns>WorkItem.EditActionSet[].</returns>
        public WorkItem.EditActionSet[] GetActionsHistory() { return r_Instance.GetActionsHistory(); }

        /// <summary>
        ///     Gets the type of the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Type.</returns>
        public Type GetFieldType(string fieldName)
        {
            Field field = r_Instance.Fields[fieldName];
            return field.FieldDefinition.SystemType;
        }

        /// <summary>
        ///     Gets the field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>System.Object.</returns>
        public object GetFieldValue(int id, int revision) { return r_Instance.GetFieldValue(id, revision); }

        /// <summary>
        ///     Gets the field value external.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>System.Object.</returns>
        public object GetFieldValueExternal(FieldDefinition fd, int revision) { return r_Instance.GetFieldValueExternal(fd, revision); }

        /// <summary>
        ///     Gets the latest synchronize data.
        /// </summary>
        /// <returns>WorkItemSyncData.</returns>
        public WorkItemSyncData GetLatestSyncData() { return r_Instance.GetLatestSyncData(); }

        /// <summary>
        ///     Gets the state of the next.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>System.String.</returns>
        public string GetNextState(string action) { return r_Instance.GetNextState(action); }

        /// <summary>
        ///     Determines whether this instance is valid.
        /// </summary>
        /// <returns><c>true</c> if this instance is valid; otherwise, <c>false</c>.</returns>
        public bool IsValid() { return r_Instance.IsValid(); }

        /// <summary>
        ///     Opens this instance.
        /// </summary>
        public void Open() { r_Instance.Open(); }

        /// <summary>
        ///     Partials the open.
        /// </summary>
        public void PartialOpen() { r_Instance.PartialOpen(); }

        /// <summary>
        ///     Resets this instance.
        /// </summary>
        public void Reset() { r_Instance.Reset(); }

        /// <summary>
        ///     Saves this instance.
        /// </summary>
        public void Save() { r_Instance.Save(); }

        /// <summary>
        ///     Saves the specified save flags.
        /// </summary>
        /// <param name="saveFlags">The save flags.</param>
        public void Save(SaveFlags saveFlags) { r_Instance.Save(saveFlags); }

        /// <summary>
        ///     Sets the dirty.
        /// </summary>
        /// <param name="isDirty">if set to <c>true</c> [is dirty].</param>
        public void SetDirty(bool isDirty) { r_Instance.SetDirty(isDirty); }

        /// <summary>
        ///     Synchronizes to latest.
        /// </summary>
        public void SyncToLatest() { r_Instance.SyncToLatest(); }

        /// <summary>
        ///     Synchronizes the work item.
        /// </summary>
        /// <param name="syncData">The synchronize data.</param>
        public void SyncWorkItem(WorkItemSyncData syncData) { r_Instance.SyncWorkItem(syncData); }

        /// <summary>
        ///     Tries the get field.
        /// </summary>
        /// <param name="knownFieldName">Name of the known field.</param>
        /// <param name="fieldValue">The field value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool TryGetField(string knownFieldName, out object fieldValue)
        {
            if (r_Instance.Fields.Contains(knownFieldName))
            {
                fieldValue = r_Instance[knownFieldName];
                return true;
            }
            fieldValue = null;
            return false;
        }

        /// <summary>
        ///     Validates this instance.
        /// </summary>
        /// <returns>ArrayList.</returns>
        public ArrayList Validate() { return r_Instance.Validate(); }

        /// <summary>
        ///     Gets or sets the area identifier.
        /// </summary>
        /// <value>The area identifier.</value>
        public int AreaId { get { return r_Instance.AreaId; } set { r_Instance.AreaId = value; } }

        /// <summary>
        ///     Gets or sets the area path.
        /// </summary>
        /// <value>The area path.</value>
        public string AreaPath { get { return r_Instance.AreaPath; } set { r_Instance.AreaPath = value; } }

        /// <summary>
        ///     Gets the attached file count.
        /// </summary>
        /// <value>The attached file count.</value>
        public int AttachedFileCount { get { return r_Instance.AttachedFileCount; } }

        /// <summary>
        ///     Gets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        public IAttachmentCollectionOM Attachments { get { return r_AttachmentCollection; } }

        /// <summary>
        ///     Gets the authorized date.
        /// </summary>
        /// <value>The authorized date.</value>
        public DateTime AuthorizedDate { get { return r_Instance.AuthorizedDate; } }

        /// <summary>
        ///     Gets the changed by.
        /// </summary>
        /// <value>The changed by.</value>
        public string ChangedBy { get { return r_Instance.ChangedBy; } }

        /// <summary>
        ///     Gets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        public DateTime ChangedDate { get { return r_Instance.ChangedDate; } }

        /// <summary>
        ///     Gets the collection.
        /// </summary>
        /// <value>The collection.</value>
        public IWorkItemCollectionOM Collection { get { return r_WorkItemCollectionWrapper; } }

        /// <summary>
        ///     Gets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public string CreatedBy { get { return r_Instance.CreatedBy; } }

        /// <summary>
        ///     Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get { return r_Instance.CreatedDate; } }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get { return r_Instance.Description; } set { r_Instance.Description = value; } }

        /// <summary>
        ///     Gets the display form.
        /// </summary>
        /// <value>The display form.</value>
        public string DisplayForm { get { return r_Instance.DisplayForm; } }

        /// <summary>
        ///     Gets the external link count.
        /// </summary>
        /// <value>The external link count.</value>
        public int ExternalLinkCount { get { return r_Instance.ExternalLinkCount; } }

        /// <summary>
        ///     Gets the field data.
        /// </summary>
        /// <value>The field data.</value>
        public WorkItemFieldData FieldData { get { return r_Instance.FieldData; } }

        /// <summary>
        ///     Gets the field names.
        /// </summary>
        /// <value>The field names.</value>
        public IReadOnlyList<string> FieldNames { get; private set; }

        /// <summary>
        /// Gets the collection of the links in this work item.
        /// </summary>
        /// <value>The collection of links in this work item.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        IReadOnlyList<ILink> IWorkItem.Links { get { return r_LinkCollectionWrapper.AsList(); } }

        /// <summary>
        ///     Gets or sets the history.
        /// </summary>
        /// <value>The history.</value>
        public string History { get { return r_Instance.History; } set { r_Instance.History = value; } }

        /// <summary>
        ///     Gets the hyper link count.
        /// </summary>
        /// <value>The hyper link count.</value>
        public int HyperLinkCount { get { return r_Instance.HyperLinkCount; } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get { return r_Instance.Id; } }

        /// <summary>
        ///     Gets the internal version.
        /// </summary>
        /// <value>The internal version.</value>
        public int InternalVersion { get { return r_Instance.InternalVersion; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is access denied.
        /// </summary>
        /// <value><c>true</c> if this instance is access denied; otherwise, <c>false</c>.</value>
        public bool IsAccessDenied { get { return r_Instance.IsAccessDenied; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is dirty.
        /// </summary>
        /// <value><c>true</c> if this instance is dirty; otherwise, <c>false</c>.</value>
        public bool IsDirty { get { return r_Instance.IsDirty; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is new.
        /// </summary>
        /// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
        public bool IsNew { get { return r_Instance.IsNew; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is open.
        /// </summary>
        /// <value><c>true</c> if this instance is open; otherwise, <c>false</c>.</value>
        public bool IsOpen { get { return r_Instance.IsOpen; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is partial open.
        /// </summary>
        /// <value><c>true</c> if this instance is partial open; otherwise, <c>false</c>.</value>
        public bool IsPartialOpen { get { return r_Instance.IsPartialOpen; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is read only.
        /// </summary>
        /// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
        public bool IsReadOnly { get { return r_Instance.IsReadOnly; } }

        /// <summary>
        ///     Gets a value indicating whether this instance is read only open.
        /// </summary>
        /// <value><c>true</c> if this instance is read only open; otherwise, <c>false</c>.</value>
        public bool IsReadOnlyOpen { get { return r_Instance.IsReadOnlyOpen; } }

        /// <summary>
        ///     Gets or sets the <see cref="System.Object" /> with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.Object.</returns>
        public object this[CoreField id] { get { return r_Instance[id]; } set { r_Instance[id] = value; } }

        /// <summary>
        ///     Gets or sets the <see cref="System.Object" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.Object.</returns>
        public object this[string name] { get { return r_Instance[name]; } set { r_Instance[name] = value; } }

        /// <summary>
        ///     Gets or sets the iteration identifier.
        /// </summary>
        /// <value>The iteration identifier.</value>
        public int IterationId { get { return r_Instance.IterationId; } set { r_Instance.IterationId = value; } }

        /// <summary>
        ///     Gets or sets the iteration path.
        /// </summary>
        /// <value>The iteration path.</value>
        public string IterationPath { get { return r_Instance.IterationPath; } set { r_Instance.IterationPath = value; } }

        /// <summary>
        ///     Gets the link data.
        /// </summary>
        /// <value>The link data.</value>
        public WorkItemLinkData LinkData { get { return r_Instance.LinkData; } }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        public ILinkCollectionOM Links { get { return r_LinkCollectionWrapper; } }

        /// <summary>
        ///     Gets the name of the node.
        /// </summary>
        /// <value>The name of the node.</value>
        public string NodeName { get { return r_Instance.NodeName; } }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <value>The project.</value>
        public Project Project { get { return r_Instance.Project; } }

        /// <summary>
        ///     Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        public string Reason { get { return r_Instance.Reason; } set { r_Instance.Reason = value; } }

        /// <summary>
        ///     Gets the related link count.
        /// </summary>
        /// <value>The related link count.</value>
        public int RelatedLinkCount { get { return r_Instance.RelatedLinkCount; } }

        /// <summary>
        ///     Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        public int Rev { get { return r_Instance.Rev; } }

        /// <summary>
        ///     Gets the revised date.
        /// </summary>
        /// <value>The revised date.</value>
        public DateTime RevisedDate { get { return r_Instance.RevisedDate; } }

        /// <summary>
        ///     Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        public int Revision { get { return r_Instance.Revision; } }

        /// <summary>
        ///     Gets the revisions.
        /// </summary>
        /// <value>The revisions.</value>
        public IRevisionCollectionOM Revisions { get { return new RevisionCollectionWrapper(r_Instance.Revisions); } }

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get { return r_Instance.State; } set { r_Instance.State = value; } }

        /// <summary>
        ///     Gets the store.
        /// </summary>
        /// <value>The store.</value>
        public WorkItemStore Store { get { return r_Instance.Store; } }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public string Tags { get { return r_Instance.Tags; } set { r_Instance.Tags = value; } }

        /// <summary>
        ///     Gets the temporary identifier.
        /// </summary>
        /// <value>The temporary identifier.</value>
        public int TemporaryId { get { return r_Instance.TemporaryId; } }

        /// <summary>
        ///     Gets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get { return r_Instance.Title; } set { r_Instance.Title = value; } }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public IWorkItemType Type { get { return WorkItemTypeWrapper.GetWrapper(r_Instance.Type); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public Uri Uri { get { return r_Instance.Uri; } }

        /// <summary>
        ///     Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; private set; }

        /// <summary>
        ///     Gets the watermark.
        /// </summary>
        /// <value>The watermark.</value>
        public int Watermark { get { return r_Instance.Watermark; } }

        /// <summary>
        ///     Gets the work item link history.
        /// </summary>
        /// <value>The work item link history.</value>
        public WorkItemLinkCollection WorkItemLinkHistory { get { return r_Instance.WorkItemLinkHistory; } }

        /// <summary>
        ///     Gets the work item links.
        /// </summary>
        /// <value>The work item links.</value>
        public WorkItemLinkCollection WorkItemLinks { get { return r_Instance.WorkItemLinks; } }

        /// <summary>
        ///     Gets the type of the work item.
        /// </summary>
        /// <value>The type of the work item.</value>
        public string WorkItemType { get; private set; }

        /// <summary>
        ///     Occurs when [field changed].
        /// </summary>
        public event WorkItemFieldChangeEventHandler FieldChanged { add { r_Instance.FieldChanged += value; } remove { r_Instance.FieldChanged -= value; } }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        IReadOnlyDictionary<string, object> IWorkItem.Fields { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Occurs when [saving].
        /// </summary>
        public event WorkItemPreSaveEventHandler Saving { add { r_Instance.Saving += value; } remove { r_Instance.Saving -= value; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="WorkItemWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        private WorkItemWrapper(WorkItem instance)
        {
            r_Instance = instance;
            r_AttachmentCollection = new AttachmentCollectionWrapper(r_Instance.Attachments);
            r_WorkItemCollectionWrapper = new WorkItemCollectionWrapper(r_Instance.Collection);
            r_LinkCollectionWrapper = new LinkCollectionWrapper(r_Instance.Links);
        }

        /// <summary>
        ///     The _attachment collection
        /// </summary>
        private readonly AttachmentCollectionWrapper r_AttachmentCollection;

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly WorkItem r_Instance;

        /// <summary>
        ///     The _link collection wrapper
        /// </summary>
        private readonly LinkCollectionWrapper r_LinkCollectionWrapper;

        /// <summary>
        ///     The _work item collection wrapper
        /// </summary>
        private readonly WorkItemCollectionWrapper r_WorkItemCollectionWrapper;
    }
}