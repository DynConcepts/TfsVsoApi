using System;
using System.Collections;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemWrapper : WorkItemWrapper<IWorkItem, WorkItem>, IWorkItem
    {
        protected WorkItemWrapper(WorkItem instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItem, WorkItem>(src => src==null ? null : ((WorkItemWrapper) src).r_Instance, src => new WorkItemWrapper(src)); }
    }


    internal class WorkItemWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItem where TInterface : class where TWrapper : class
    {

        void IWorkItem.ApplyRules(Boolean copyChangedByFromLatest) { r_Instance.ApplyRules(copyChangedByFromLatest); }
        void IWorkItem.ApplyRules() { r_Instance.ApplyRules(); }

        Int32 IWorkItem.AreaId
        {
            get
            {
                int nativeCallResult = r_Instance.AreaId;
                return nativeCallResult;
            }
            set { r_Instance.AreaId = value; }
        }

        String IWorkItem.AreaPath
        {
            get
            {
                string nativeCallResult = r_Instance.AreaPath;
                return nativeCallResult;
            }
            set { r_Instance.AreaPath = value; }
        }

        Int32 IWorkItem.AttachedFileCount
        {
            get
            {
                int nativeCallResult = r_Instance.AttachedFileCount;
                return nativeCallResult;
            }
        }

        IAttachmentCollection IWorkItem.Attachments
        {
            get
            {
                AttachmentCollection nativeCallResult = r_Instance.Attachments;
                IAttachmentCollection wrappedCallResult = AttachmentCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        DateTime IWorkItem.AuthorizedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.AuthorizedDate;
                return nativeCallResult;
            }
        }

        void IWorkItem.CalculateFieldLists(Int32 fieldId) { r_Instance.CalculateFieldLists(fieldId); }

        String IWorkItem.ChangedBy
        {
            get
            {
                string nativeCallResult = r_Instance.ChangedBy;
                return nativeCallResult;
            }
        }

        DateTime IWorkItem.ChangedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.ChangedDate;
                return nativeCallResult;
            }
        }



        void IWorkItem.Close() { r_Instance.Close(); }

        IWorkItemCollection IWorkItem.Collection
        {
            get
            {
                WorkItemCollection nativeCallResult = r_Instance.Collection;
                IWorkItemCollection wrappedCallResult = WorkItemCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }



        IWorkItem IWorkItem.Copy(IWorkItemType targetType, IWorkItemCopyFlags flags)
        {
            WorkItem nativeCallResult = r_Instance.Copy(WorkItemTypeWrapper.GetInstance(targetType), WorkItemCopyFlagsWrapper.GetInstance(flags));
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItem.Copy(IWorkItemType targetType)
        {
            WorkItem nativeCallResult = r_Instance.Copy(WorkItemTypeWrapper.GetInstance(targetType));
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IWorkItem IWorkItem.Copy()
        {
            WorkItem nativeCallResult = r_Instance.Copy();
            IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        String IWorkItem.CreatedBy
        {
            get
            {
                string nativeCallResult = r_Instance.CreatedBy;
                return nativeCallResult;
            }
        }

        DateTime IWorkItem.CreatedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreatedDate;
                return nativeCallResult;
            }
        }

        String IWorkItem.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        String IWorkItem.DisplayForm
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayForm;
                return nativeCallResult;
            }
        }

        Int32 IWorkItem.ExternalLinkCount
        {
            get
            {
                int nativeCallResult = r_Instance.ExternalLinkCount;
                return nativeCallResult;
            }
        }

        IWorkItemFieldData IWorkItem.FieldData
        {
            get
            {
                WorkItemFieldData nativeCallResult = r_Instance.FieldData;
                IWorkItemFieldData wrappedCallResult = WorkItemFieldDataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IFieldCollection IWorkItem.Fields
        {
            get
            {
                FieldCollection nativeCallResult = r_Instance.Fields;
                IFieldCollection wrappedCallResult = FieldCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Object IWorkItem.GetActionObject(IWorkItem_EditActionInfo actionInfo)
        {
            object nativeCallResult = r_Instance.GetActionObject(WorkItem_EditActionInfoWrapper.GetInstance(actionInfo));
            return nativeCallResult;
        }

        IWorkItem_EditActionSet[] IWorkItem.GetActionsHistory()
        {
            WorkItem.EditActionSet[] nativeCallResult = r_Instance.GetActionsHistory();
            IWorkItem_EditActionSet[] wrappedCallResult = WorkItem_EditActionSetWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }



        Object IWorkItem.GetFieldValue(Int32 id, Int32 revision)
        {
            object nativeCallResult = r_Instance.GetFieldValue(id, revision);
            return nativeCallResult;
        }

        Object IWorkItem.GetFieldValueExternal(IFieldDefinition fd, Int32 revision)
        {
            object nativeCallResult = r_Instance.GetFieldValueExternal(FieldDefinitionWrapper.GetInstance(fd), revision);
            return nativeCallResult;
        }



        IWorkItemSyncData IWorkItem.GetLatestSyncData()
        {
            WorkItemSyncData nativeCallResult = r_Instance.GetLatestSyncData();
            IWorkItemSyncData wrappedCallResult = WorkItemSyncDataWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        String IWorkItem.GetNextState(String action)
        {
            string nativeCallResult = r_Instance.GetNextState(action);
            return nativeCallResult;
        }



        String IWorkItem.History
        {
            get
            {
                string nativeCallResult = r_Instance.History;
                return nativeCallResult;
            }
            set { r_Instance.History = value; }
        }

        Int32 IWorkItem.HyperLinkCount
        {
            get
            {
                int nativeCallResult = r_Instance.HyperLinkCount;
                return nativeCallResult;
            }
        }

        Int32 IWorkItem.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Int32 IWorkItem.InternalVersion
        {
            get
            {
                int nativeCallResult = r_Instance.InternalVersion;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsAccessDenied
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAccessDenied;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsDirty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDirty;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsNew
        {
            get
            {
                bool nativeCallResult = r_Instance.IsNew;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsOpen
        {
            get
            {
                bool nativeCallResult = r_Instance.IsOpen;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsPartialOpen
        {
            get
            {
                bool nativeCallResult = r_Instance.IsPartialOpen;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsReadOnly
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReadOnly;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsReadOnlyOpen
        {
            get
            {
                bool nativeCallResult = r_Instance.IsReadOnlyOpen;
                return nativeCallResult;
            }
        }

        Boolean IWorkItem.IsValid()
        {
            bool nativeCallResult = r_Instance.IsValid();
            return nativeCallResult;
        }

        Object IWorkItem.this[String name]
        {
            get
            {
                object nativeCallResult = r_Instance[name];
                return nativeCallResult;
            }
            set { r_Instance[name] = value; }
        }

        Object IWorkItem.this[ICoreField id]
        {
            get
            {
                object nativeCallResult = r_Instance[CoreFieldWrapper.GetInstance(id)];
                return nativeCallResult;
            }
            set { r_Instance[CoreFieldWrapper.GetInstance(id)] = value; }
        }

        Int32 IWorkItem.IterationId
        {
            get
            {
                int nativeCallResult = r_Instance.IterationId;
                return nativeCallResult;
            }
            set { r_Instance.IterationId = value; }
        }

        String IWorkItem.IterationPath
        {
            get
            {
                string nativeCallResult = r_Instance.IterationPath;
                return nativeCallResult;
            }
            set { r_Instance.IterationPath = value; }
        }

        IWorkItemLinkData IWorkItem.LinkData
        {
            get
            {
                WorkItemLinkData nativeCallResult = r_Instance.LinkData;
                IWorkItemLinkData wrappedCallResult = WorkItemLinkDataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ILinkCollection IWorkItem.Links
        {
            get
            {
                LinkCollection nativeCallResult = r_Instance.Links;
                ILinkCollection wrappedCallResult = LinkCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IWorkItem.NodeName
        {
            get
            {
                string nativeCallResult = r_Instance.NodeName;
                return nativeCallResult;
            }
        }

        void IWorkItem.Open() { r_Instance.Open(); }
        void IWorkItem.PartialOpen() { r_Instance.PartialOpen(); }

        IProject IWorkItem.Project
        {
            get
            {
                Project nativeCallResult = r_Instance.Project;
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String IWorkItem.Reason
        {
            get
            {
                string nativeCallResult = r_Instance.Reason;
                return nativeCallResult;
            }
            set { r_Instance.Reason = value; }
        }

        Int32 IWorkItem.RelatedLinkCount
        {
            get
            {
                int nativeCallResult = r_Instance.RelatedLinkCount;
                return nativeCallResult;
            }
        }

        void IWorkItem.Reset() { r_Instance.Reset(); }

        Int32 IWorkItem.Rev
        {
            get
            {
                int nativeCallResult = r_Instance.Rev;
                return nativeCallResult;
            }
        }

        DateTime IWorkItem.RevisedDate
        {
            get
            {
                DateTime nativeCallResult = r_Instance.RevisedDate;
                return nativeCallResult;
            }
        }

        Int32 IWorkItem.Revision
        {
            get
            {
                int nativeCallResult = r_Instance.Revision;
                return nativeCallResult;
            }
        }

        IRevisionCollection IWorkItem.Revisions
        {
            get
            {
                RevisionCollection nativeCallResult = r_Instance.Revisions;
                IRevisionCollection wrappedCallResult = RevisionCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IWorkItem.Save() { r_Instance.Save(); }

        void IWorkItem.Save(ISaveFlags saveFlags) { r_Instance.Save(SaveFlagsWrapper.GetInstance(saveFlags)); }
        void IWorkItem.SetDirty(Boolean isDirty) { r_Instance.SetDirty(isDirty); }

        String IWorkItem.State
        {
            get
            {
                string nativeCallResult = r_Instance.State;
                return nativeCallResult;
            }
            set { r_Instance.State = value; }
        }

        IWorkItemStore IWorkItem.Store
        {
            get
            {
                WorkItemStore nativeCallResult = r_Instance.Store;
                IWorkItemStore wrappedCallResult = WorkItemStoreWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IWorkItem.SyncToLatest() { r_Instance.SyncToLatest(); }
        void IWorkItem.SyncWorkItem(IWorkItemSyncData syncData) { r_Instance.SyncWorkItem(WorkItemSyncDataWrapper.GetInstance(syncData)); }

        String IWorkItem.Tags
        {
            get
            {
                string nativeCallResult = r_Instance.Tags;
                return nativeCallResult;
            }
            set { r_Instance.Tags = value; }
        }

        Int32 IWorkItem.TemporaryId
        {
            get
            {
                int nativeCallResult = r_Instance.TemporaryId;
                return nativeCallResult;
            }
        }

        String IWorkItem.Title
        {
            get
            {
                string nativeCallResult = r_Instance.Title;
                return nativeCallResult;
            }
            set { r_Instance.Title = value; }
        }

        IWorkItemType IWorkItem.Type
        {
            get
            {
                WorkItemType nativeCallResult = r_Instance.Type;
                IWorkItemType wrappedCallResult = WorkItemTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Uri IWorkItem.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        ArrayList IWorkItem.Validate()
        {
            ArrayList nativeCallResult = r_Instance.Validate();
            return nativeCallResult;
        }

        Int32 IWorkItem.Watermark
        {
            get
            {
                int nativeCallResult = r_Instance.Watermark;
                return nativeCallResult;
            }
        }

        IWorkItemLinkCollection IWorkItem.WorkItemLinkHistory
        {
            get
            {
                WorkItemLinkCollection nativeCallResult = r_Instance.WorkItemLinkHistory;
                IWorkItemLinkCollection wrappedCallResult = WorkItemLinkCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IWorkItemLinkCollection IWorkItem.WorkItemLinks
        {
            get
            {
                WorkItemLinkCollection nativeCallResult = r_Instance.WorkItemLinks;
                IWorkItemLinkCollection wrappedCallResult = WorkItemLinkCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemWrapper(WorkItem instance) { r_Instance = instance; }
        protected readonly WorkItem r_Instance;
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItem_EditActionSetWrapper : IWorkItem_EditActionSet
    {
        public static WorkItem.EditActionSet GetInstance(IWorkItem_EditActionSet src) { return default(WorkItem.EditActionSet); }
        public static WorkItem.EditActionSet[] GetInstance(IWorkItem_EditActionSet[] src) { return null; }
        public static WorkItem_EditActionSetWrapper GetWrapper(WorkItem.EditActionSet src) { return default(WorkItem_EditActionSetWrapper); }
        public static IWorkItem_EditActionSet[] GetWrapper(WorkItem.EditActionSet[] src) { return null; }
        private WorkItem_EditActionSetWrapper(WorkItem.EditActionSet instance) { r_Instance = instance; }
        private WorkItem.EditActionSet r_Instance;
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItem_EditActionInfoWrapper : IWorkItem_EditActionInfo
    {
        public static WorkItem.EditActionInfo GetInstance(IWorkItem_EditActionInfo src) { return default(WorkItem.EditActionInfo); }
        public static WorkItem.EditActionInfo[] GetInstance(IWorkItem_EditActionInfo[] src) { return null; }
        public static WorkItem_EditActionInfoWrapper GetWrapper(WorkItem.EditActionInfo src) { return default(WorkItem_EditActionInfoWrapper); }
        public static IWorkItem_EditActionInfo[] GetWrapper(WorkItem.EditActionInfo[] src) { return null; }
        private WorkItem_EditActionInfoWrapper(WorkItem.EditActionInfo instance) { r_Instance = instance; }
        private WorkItem.EditActionInfo r_Instance;
    }
}