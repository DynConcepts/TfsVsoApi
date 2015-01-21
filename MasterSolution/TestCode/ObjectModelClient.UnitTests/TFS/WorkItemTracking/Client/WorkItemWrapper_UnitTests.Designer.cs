using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ApplyRules_UnitTest()
        {
            Boolean copyChangedByFromLatest = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    copyChangedByFromLatest = default(Boolean); //No Constructor
                    ApplyRules_PreCondition(instance, ref copyChangedByFromLatest);
                },
                instance => { instance.ApplyRules(copyChangedByFromLatest); },
                instance => { ApplyRules_PostValidate(instance, copyChangedByFromLatest); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AreaId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    AreaId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AreaId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AreaId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AreaPath_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    AreaPath_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AreaPath = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AreaPath; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AttachedFileCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AttachedFileCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthorizedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AuthorizedDate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CalculateFieldLists_UnitTest()
        {
            Int32 fieldId = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    fieldId = default(Int32); //No Constructor
                    CalculateFieldLists_PreCondition(instance, ref fieldId);
                },
                instance => { instance.CalculateFieldLists(fieldId); },
                instance => { CalculateFieldLists_PostValidate(instance, fieldId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChangedBy_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ChangedBy; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Collection_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Collection; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Copy_UnitTest()
        {
            IWorkItemType targetType = default(IWorkItemType);
            IWorkItemCopyFlags flags = default(IWorkItemCopyFlags);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    targetType = WorkItemTypeWrapper_UnitTests.GetInstance();
                    flags = WorkItemCopyFlagsWrapper_UnitTests.GetInstance();
                    Copy_PreCondition(instance, ref targetType, ref flags);
                },
                instance => { instance.Copy(targetType, flags); },
                instance => { Copy_PostValidate(instance, targetType, flags); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreatedBy_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CreatedBy; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreatedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.CreatedDate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ExternalLinkCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ExternalLinkCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldData_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.FieldData; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetActionObject_UnitTest()
        {
            IWorkItem_EditActionInfo actionInfo = default(IWorkItem_EditActionInfo);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    actionInfo = WorkItem_EditActionInfoWrapper_UnitTests.GetInstance();
                    GetActionObject_PreCondition(instance, ref actionInfo);
                },
                instance => { instance.GetActionObject(actionInfo); },
                instance => { GetActionObject_PostValidate(instance, actionInfo); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetActionsHistory_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance => { GetActionsHistory_PreCondition(instance); },
                instance => { instance.GetActionsHistory(); },
                instance => { GetActionsHistory_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldValueExternal_UnitTest()
        {
            IFieldDefinition fd = default(IFieldDefinition);
            Int32 revision = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    fd = FieldDefinitionWrapper_UnitTests.GetInstance();
                    revision = default(Int32); //No Constructor
                    GetFieldValueExternal_PreCondition(instance, ref fd, ref revision);
                },
                instance => { instance.GetFieldValueExternal(fd, revision); },
                instance => { GetFieldValueExternal_PostValidate(instance, fd, revision); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetFieldValue_UnitTest()
        {
            Int32 id = default(Int32);
            Int32 revision = default(Int32);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    id = default(Int32); //No Constructor
                    revision = default(Int32); //No Constructor
                    GetFieldValue_PreCondition(instance, ref id, ref revision);
                },
                instance => { instance.GetFieldValue(id, revision); },
                instance => { GetFieldValue_PostValidate(instance, id, revision); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetLatestSyncData_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance => { GetLatestSyncData_PreCondition(instance); },
                instance => { instance.GetLatestSyncData(); },
                instance => { GetLatestSyncData_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void History_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    History_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.History = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.History; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HyperLinkCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HyperLinkCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void InternalVersion_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.InternalVersion; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsAccessDenied_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsAccessDenied; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsOpen_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsOpen; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsPartialOpen_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsPartialOpen; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsReadOnlyOpen_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsReadOnlyOpen; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IterationId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    IterationId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IterationId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IterationId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IterationPath_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    IterationPath_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.IterationPath = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.IterationPath; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkData_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.LinkData; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NodeName_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.NodeName; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Open_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance => { Open_PreCondition(instance); },
                instance => { instance.Open(); },
                instance => { Open_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PartialOpen_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance => { PartialOpen_PreCondition(instance); },
                instance => { instance.PartialOpen(); },
                instance => { PartialOpen_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Reason_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Reason_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Reason = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Reason; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RelatedLinkCount_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RelatedLinkCount; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Rev_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Rev; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void RevisedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.RevisedDate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Revisions_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Revisions; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SetDirty_UnitTest()
        {
            Boolean isDirty = default(Boolean);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    isDirty = default(Boolean); //No Constructor
                    SetDirty_PreCondition(instance, ref isDirty);
                },
                instance => { instance.SetDirty(isDirty); },
                instance => { SetDirty_PostValidate(instance, isDirty); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncToLatest_UnitTest()
        {
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance => { SyncToLatest_PreCondition(instance); },
                instance => { instance.SyncToLatest(); },
                instance => { SyncToLatest_PostValidate(instance); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void SyncWorkItem_UnitTest()
        {
            IWorkItemSyncData syncData = default(IWorkItemSyncData);
            ExecuteMethod(
                () => { return (IWorkItem) GetInstance(); },
                instance =>
                {
                    syncData = WorkItemSyncDataWrapper_UnitTests.GetInstance();
                    SyncWorkItem_PreCondition(instance, ref syncData);
                },
                instance => { instance.SyncWorkItem(syncData); },
                instance => { SyncWorkItem_PostValidate(instance, syncData); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Tags_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Tags_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Tags = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Tags; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void TemporaryId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.TemporaryId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Title_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Title_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Title = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Title; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Watermark_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Watermark; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemLinkHistory_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemLinkHistory; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void WorkItemLinks_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItem) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.WorkItemLinks; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void ApplyRules_PostValidate(IWorkItem instance, Boolean copyChangedByFromLatest);
        partial void ApplyRules_PreCondition(IWorkItem instance, ref Boolean copyChangedByFromLatest);
        partial void AreaId_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void AreaPath_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void AttachedFileCount_SetCondition(ref IWorkItem instance, ref Int32 setValue);

        partial void AuthorizedDate_SetCondition(ref IWorkItem instance, ref DateTime setValue);
        partial void CalculateFieldLists_PostValidate(IWorkItem instance, Int32 fieldId);
        partial void CalculateFieldLists_PreCondition(IWorkItem instance, ref Int32 fieldId);
        partial void ChangedBy_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void Collection_SetCondition(ref IWorkItem instance, ref IWorkItemCollection setValue);
        partial void Copy_PostValidate(IWorkItem instance, IWorkItemType targetType, IWorkItemCopyFlags flags);
        partial void Copy_PreCondition(IWorkItem instance, ref IWorkItemType targetType, ref IWorkItemCopyFlags flags);

        partial void CreatedBy_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void CreatedDate_SetCondition(ref IWorkItem instance, ref DateTime setValue);

        partial void ExternalLinkCount_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void FieldData_SetCondition(ref IWorkItem instance, ref IWorkItemFieldData setValue);
        partial void GetActionObject_PostValidate(IWorkItem instance, IWorkItem_EditActionInfo actionInfo);
        partial void GetActionObject_PreCondition(IWorkItem instance, ref IWorkItem_EditActionInfo actionInfo);
        partial void GetActionsHistory_PostValidate(IWorkItem instance);
        partial void GetActionsHistory_PreCondition(IWorkItem instance);
        partial void GetFieldValueExternal_PostValidate(IWorkItem instance, IFieldDefinition fd, Int32 revision);
        partial void GetFieldValueExternal_PreCondition(IWorkItem instance, ref IFieldDefinition fd, ref Int32 revision);
        partial void GetFieldValue_PostValidate(IWorkItem instance, Int32 id, Int32 revision);
        partial void GetFieldValue_PreCondition(IWorkItem instance, ref Int32 id, ref Int32 revision);
        internal static IEnumerable<WorkItemWrapper> GetIEnumerableInstance() { return new List<WorkItemWrapper> {GetInstance()}; }

        internal static WorkItemWrapper GetInstance([CallerMemberName] string callerName = "")
        {
            WorkItem real = default(WorkItem);
            RealInstanceFactory(ref real);
            var instance = (WorkItemWrapper) WorkItemWrapper.GetWrapper(real);
            InstanceFactory(ref instance, callerName);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void GetLatestSyncData_PostValidate(IWorkItem instance);
        partial void GetLatestSyncData_PreCondition(IWorkItem instance);
        partial void History_SetCondition(ref IWorkItem instance, ref String setValue);

        partial void HyperLinkCount_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        static partial void InstanceFactory(ref WorkItemWrapper instance, [CallerMemberName] string callerName = "");
        partial void InternalVersion_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void IsAccessDenied_SetCondition(ref IWorkItem instance, ref Boolean setValue);

        partial void IsOpen_SetCondition(ref IWorkItem instance, ref Boolean setValue);

        partial void IsPartialOpen_SetCondition(ref IWorkItem instance, ref Boolean setValue);

        partial void IsReadOnlyOpen_SetCondition(ref IWorkItem instance, ref Boolean setValue);
        partial void IterationId_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void IterationPath_SetCondition(ref IWorkItem instance, ref String setValue);

        partial void LinkData_SetCondition(ref IWorkItem instance, ref IWorkItemLinkData setValue);
        partial void NodeName_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void Open_PostValidate(IWorkItem instance);
        partial void Open_PreCondition(IWorkItem instance);
        partial void PartialOpen_PostValidate(IWorkItem instance);
        partial void PartialOpen_PreCondition(IWorkItem instance);
        static partial void RealInstanceFactory(ref WorkItem real, [CallerMemberName] string callerName = "");
        partial void Reason_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void RelatedLinkCount_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void Rev_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void RevisedDate_SetCondition(ref IWorkItem instance, ref DateTime setValue);
        partial void Revisions_SetCondition(ref IWorkItem instance, ref IRevisionCollection setValue);
        partial void SetDirty_PostValidate(IWorkItem instance, Boolean isDirty);
        partial void SetDirty_PreCondition(IWorkItem instance, ref Boolean isDirty);
        partial void SyncToLatest_PostValidate(IWorkItem instance);
        partial void SyncToLatest_PreCondition(IWorkItem instance);
        partial void SyncWorkItem_PostValidate(IWorkItem instance, IWorkItemSyncData syncData);
        partial void SyncWorkItem_PreCondition(IWorkItem instance, ref IWorkItemSyncData syncData);
        partial void Tags_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void TemporaryId_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void Title_SetCondition(ref IWorkItem instance, ref String setValue);
        partial void Watermark_SetCondition(ref IWorkItem instance, ref Int32 setValue);
        partial void WorkItemLinkHistory_SetCondition(ref IWorkItem instance, ref IWorkItemLinkCollection setValue);
        partial void WorkItemLinks_SetCondition(ref IWorkItem instance, ref IWorkItemLinkCollection setValue);
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItem_EditActionSetWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItem_EditActionSetWrapper> GetIEnumerableInstance() { return new List<WorkItem_EditActionSetWrapper> {GetInstance()}; }

        internal static WorkItem_EditActionSetWrapper GetInstance()
        {
            WorkItem.EditActionSet real = default(WorkItem.EditActionSet);
            RealInstanceFactory(ref real);
            WorkItem_EditActionSetWrapper instance = WorkItem_EditActionSetWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItem_EditActionSetWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItem.EditActionSet real, [CallerMemberName] string callerName = "");
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItem_EditActionInfoWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<WorkItem_EditActionInfoWrapper> GetIEnumerableInstance() { return new List<WorkItem_EditActionInfoWrapper> {GetInstance()}; }

        internal static WorkItem_EditActionInfoWrapper GetInstance()
        {
            WorkItem.EditActionInfo real = default(WorkItem.EditActionInfo);
            RealInstanceFactory(ref real);
            WorkItem_EditActionInfoWrapper instance = WorkItem_EditActionInfoWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref WorkItem_EditActionInfoWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WorkItem.EditActionInfo real, [CallerMemberName] string callerName = "");
    }
}