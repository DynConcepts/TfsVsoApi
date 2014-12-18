namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItem
  {
    void Open();
    System.Object GetFieldValueExternal( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinition fd, System.Int32 revision);
    void ApplyRules( System.Boolean copyChangedByFromLatest);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem_EditActionSet[] GetActionsHistory();
    void PartialOpen();
    void Close();
    void Reset();
    void SyncToLatest();
    void Save();
    void Save( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ISaveFlags saveFlags);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem Copy( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType targetType, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCopyFlags flags);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem Copy( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType targetType);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem Copy();
    System.Collections.ArrayList Validate();
    System.Boolean IsValid();
    System.String GetNextState( System.String action);
    void SetDirty( System.Boolean isDirty);
    System.Object GetFieldValue( System.Int32 id, System.Int32 revision);
    void ApplyRules();
    void CalculateFieldLists( System.Int32 fieldId);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemSyncData GetLatestSyncData();
    void SyncWorkItem( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemSyncData syncData);
    System.Object GetActionObject( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItem_EditActionInfo actionInfo);
    System.Int32 Id  { get;   }
    System.Int32 TemporaryId  { get;   }
    System.Uri Uri  { get;   }
    System.Int32 Revision  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevisionCollection Revisions  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IAttachmentCollection Attachments  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkCollection WorkItemLinks  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILinkCollection Links  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkCollection WorkItemLinkHistory  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore Store  { get;   }
    System.String Title  { get; set;   }
    System.String State  { get; set;   }
    System.String Reason  { get; set;   }
    System.Int32 Rev  { get;   }
    System.String Description  { get; set;   }
    System.String History  { get; set;   }
    System.String ChangedBy  { get;   }
    System.DateTime RevisedDate  { get;   }
    System.Int32 Watermark  { get;   }
    System.DateTime ChangedDate  { get;   }
    System.DateTime AuthorizedDate  { get;   }
    System.DateTime CreatedDate  { get;   }
    System.String CreatedBy  { get;   }
    System.String Tags  { get; set;   }
    System.String NodeName  { get;   }
    System.String AreaPath  { get; set;   }
    System.Int32 AreaId  { get; set;   }
    System.String IterationPath  { get; set;   }
    System.Int32 IterationId  { get; set;   }
    System.Int32 ExternalLinkCount  { get;   }
    System.Int32 HyperLinkCount  { get;   }
    System.Int32 AttachedFileCount  { get;   }
    System.Int32 RelatedLinkCount  { get;   }
    System.Boolean IsOpen  { get;   }
    System.Boolean IsPartialOpen  { get;   }
    System.Boolean IsReadOnly  { get;   }
    System.Boolean IsReadOnlyOpen  { get;   }
    System.Boolean IsNew  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldCollection Fields  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject Project  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType Type  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemCollection Collection  { get;   }
    System.Object this[System.String name] { get; set;   }
    System.Object this[DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICoreField id] { get; set;   }
    System.Boolean IsDirty  { get;   }
    System.String DisplayForm  { get;   }
    System.Int32 InternalVersion  { get;   }
    System.Boolean IsAccessDenied  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData FieldData  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemLinkData LinkData  { get;   }
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
