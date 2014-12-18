using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItem
  {
    void Open();
    Object GetFieldValueExternal( IFieldDefinition fd, Int32 revision);
    void ApplyRules( Boolean copyChangedByFromLatest);
    IWorkItem_EditActionSet[] GetActionsHistory();
    void PartialOpen();
    void Close();
    void Reset();
    void SyncToLatest();
    void Save();
    void Save( ISaveFlags saveFlags);
    IWorkItem Copy( IWorkItemType targetType, IWorkItemCopyFlags flags);
    IWorkItem Copy( IWorkItemType targetType);
    IWorkItem Copy();
    ArrayList Validate();
    Boolean IsValid();
    String GetNextState( String action);
    void SetDirty( Boolean isDirty);
    Object GetFieldValue( Int32 id, Int32 revision);
    void ApplyRules();
    void CalculateFieldLists( Int32 fieldId);
    IWorkItemSyncData GetLatestSyncData();
    void SyncWorkItem( IWorkItemSyncData syncData);
    Object GetActionObject( IWorkItem_EditActionInfo actionInfo);
    Int32 Id  { get;   }
    Int32 TemporaryId  { get;   }
    Uri Uri  { get;   }
    Int32 Revision  { get;   }
    IRevisionCollection Revisions  { get;   }
    IAttachmentCollection Attachments  { get;   }
    IWorkItemLinkCollection WorkItemLinks  { get;   }
    ILinkCollection Links  { get;   }
    IWorkItemLinkCollection WorkItemLinkHistory  { get;   }
    IWorkItemStore Store  { get;   }
    String Title  { get; set;   }
    String State  { get; set;   }
    String Reason  { get; set;   }
    Int32 Rev  { get;   }
    String Description  { get; set;   }
    String History  { get; set;   }
    String ChangedBy  { get;   }
    DateTime RevisedDate  { get;   }
    Int32 Watermark  { get;   }
    DateTime ChangedDate  { get;   }
    DateTime AuthorizedDate  { get;   }
    DateTime CreatedDate  { get;   }
    String CreatedBy  { get;   }
    String Tags  { get; set;   }
    String NodeName  { get;   }
    String AreaPath  { get; set;   }
    Int32 AreaId  { get; set;   }
    String IterationPath  { get; set;   }
    Int32 IterationId  { get; set;   }
    Int32 ExternalLinkCount  { get;   }
    Int32 HyperLinkCount  { get;   }
    Int32 AttachedFileCount  { get;   }
    Int32 RelatedLinkCount  { get;   }
    Boolean IsOpen  { get;   }
    Boolean IsPartialOpen  { get;   }
    Boolean IsReadOnly  { get;   }
    Boolean IsReadOnlyOpen  { get;   }
    Boolean IsNew  { get;   }
    IFieldCollection Fields  { get;   }
    IProject Project  { get;   }
    IWorkItemType Type  { get;   }
    IWorkItemCollection Collection  { get;   }
    Object this[String name] { get; set;   }
    Object this[ICoreField id] { get; set;   }
    Boolean IsDirty  { get;   }
    String DisplayForm  { get;   }
    Int32 InternalVersion  { get;   }
    Boolean IsAccessDenied  { get;   }
    IWorkItemFieldData FieldData  { get;   }
    IWorkItemLinkData LinkData  { get;   }
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
