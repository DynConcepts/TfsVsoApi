using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItem
    {
        void ApplyRules(Boolean copyChangedByFromLatest);
        void ApplyRules();
        void CalculateFieldLists(Int32 fieldId);
        void Close();
        IWorkItem Copy(IWorkItemType targetType, IWorkItemCopyFlags flags);
        IWorkItem Copy(IWorkItemType targetType);
        IWorkItem Copy();
        Object GetActionObject(IWorkItem_EditActionInfo actionInfo);
        IWorkItem_EditActionSet[] GetActionsHistory();
        Object GetFieldValue(Int32 id, Int32 revision);
        Object GetFieldValueExternal(IFieldDefinition fd, Int32 revision);
        IWorkItemSyncData GetLatestSyncData();
        String GetNextState(String action);
        Boolean IsValid();
        void Open();
        void PartialOpen();
        void Reset();
        void Save();
        void Save(ISaveFlags saveFlags);
        void SetDirty(Boolean isDirty);
        void SyncToLatest();
        void SyncWorkItem(IWorkItemSyncData syncData);
        ArrayList Validate();
        Int32 AreaId { get; set; }
        String AreaPath { get; set; }
        Int32 AttachedFileCount { get; }
        IAttachmentCollection Attachments { get; }
        DateTime AuthorizedDate { get; }
        String ChangedBy { get; }
        DateTime ChangedDate { get; }
        IWorkItemCollection Collection { get; }
        String CreatedBy { get; }
        DateTime CreatedDate { get; }
        String Description { get; set; }
        String DisplayForm { get; }
        Int32 ExternalLinkCount { get; }
        IWorkItemFieldData FieldData { get; }
        IFieldCollection Fields { get; }
        String History { get; set; }
        Int32 HyperLinkCount { get; }
        Int32 Id { get; }
        Int32 InternalVersion { get; }
        Boolean IsAccessDenied { get; }
        Boolean IsDirty { get; }
        Boolean IsNew { get; }
        Boolean IsOpen { get; }
        Boolean IsPartialOpen { get; }
        Boolean IsReadOnly { get; }
        Boolean IsReadOnlyOpen { get; }
        Object this[String name] { get; set; }
        Object this[ICoreField id] { get; set; }
        Int32 IterationId { get; set; }
        String IterationPath { get; set; }
        IWorkItemLinkData LinkData { get; }
        ILinkCollection Links { get; }
        String NodeName { get; }
        IProject Project { get; }
        String Reason { get; set; }
        Int32 RelatedLinkCount { get; }
        Int32 Rev { get; }
        DateTime RevisedDate { get; }
        Int32 Revision { get; }
        IRevisionCollection Revisions { get; }
        String State { get; set; }
        IWorkItemStore Store { get; }
        String Tags { get; set; }
        Int32 TemporaryId { get; }
        String Title { get; set; }
        IWorkItemType Type { get; }
        Uri Uri { get; }
        Int32 Watermark { get; }
        IWorkItemLinkCollection WorkItemLinkHistory { get; }
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