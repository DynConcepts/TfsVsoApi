using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.APIs;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.APIs
{
    /// <summary>
    ///     Generated Test Template
    /// </summary>
    public partial class WorkItemAPI_UnitTests : DynTestClassBase
    {
        /// <summary>
        ///     Builds the work item_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="workItemType">Type of the work item.</param>
        /// <param name="fieldValues">The field values.</param>
        partial void BuildWorkItem_PreCondition(WorkItemAPI instance, ref String projectName, ref String workItemType, ref IReadOnlyList<KeyValuePair<String, Object>> fieldValues)
        {
            projectName = "RestPlaypen";
            workItemType = "Task";
            var values = new List<KeyValuePair<string, object>>();
            values.Add(new KeyValuePair<string, object>("System.Title", "Task Created from UnitTest"));
            fieldValues = values;
        }

        /// <summary>
        ///     Creates the work item_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="workItem">The work item.</param>
        partial void CreateWorkItem_PreCondition(WorkItemAPI instance, ref String project, ref IWorkItem workItem)
        {
            project = "RestPlaypen";
            workItem = new FauxWorkItem
            {
                Type = new FauxWorkItemType {Name = "Task"}
            };
        }

        /// <summary>
        ///     Gets the areas_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        partial void GetAreas_PreCondition(WorkItemAPI instance, ref String project, ref Int32 depth)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the iterations_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        partial void GetIterations_PreCondition(WorkItemAPI instance, ref String project, ref Int32 depth)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work item type categories_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetWorkItemTypeCategories_PreCondition(WorkItemAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work item types_ post validate.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        /// <param name="_retVal">The _ret value.</param>
        partial void GetWorkItemTypes_PostValidate(WorkItemAPI instance, String project, Task<IReadOnlyDictionary<String, IWorkItemType>> _retVal)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work item types_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="project">The project.</param>
        partial void GetWorkItemTypes_PreCondition(WorkItemAPI instance, ref String project)
        {
            project = "RestPlaypen";
        }

        /// <summary>
        ///     Gets the work items_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="ids">The ids.</param>
        partial void GetWorkItems_PreCondition(WorkItemAPI instance, ref IEnumerable<Int32> ids)
        {
            ids = new List<int> {1, 2, 3};
        }

        /// <summary>
        ///     Wiqls the query_ pre condition.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">The fully populate.</param>
        partial void WiqlQuery_PreCondition(WorkItemAPI instance, ref String wiql, ref Boolean fullyPopulate)
        {
            wiql = "SELECT * FROM WorkItems WHERE [System.TeamProject] = 'RestPlaypen' ORDER BY [System.Id] ";
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        /// <summary>
        ///     The SR_ disabled tests
        /// </summary>
        private static readonly List<String> sr_DisabledTests = new List<string>();

        internal class FauxWorkItem : IWorkItem
        {
            public void ApplyRules(bool copyChangedByFromLatest)
            {
                throw new NotImplementedException();
            }

            public void ApplyRules()
            {
                throw new NotImplementedException();
            }

            public void CalculateFieldLists(int fieldId)
            {
                throw new NotImplementedException();
            }

            public void Close()
            {
                throw new NotImplementedException();
            }

            public IWorkItem Copy(IWorkItemType targetType, IWorkItemCopyFlags flags)
            {
                throw new NotImplementedException();
            }

            public IWorkItem Copy(IWorkItemType targetType)
            {
                throw new NotImplementedException();
            }

            public IWorkItem Copy()
            {
                throw new NotImplementedException();
            }

            public object GetActionObject(IWorkItem_EditActionInfo actionInfo)
            {
                throw new NotImplementedException();
            }

            public IWorkItem_EditActionSet[] GetActionsHistory()
            {
                throw new NotImplementedException();
            }

            public object GetFieldValue(int id, int revision)
            {
                throw new NotImplementedException();
            }

            public object GetFieldValueExternal(IFieldDefinition fd, int revision)
            {
                throw new NotImplementedException();
            }

            public IWorkItemSyncData GetLatestSyncData()
            {
                throw new NotImplementedException();
            }

            public string GetNextState(string action)
            {
                throw new NotImplementedException();
            }

            public bool IsValid()
            {
                throw new NotImplementedException();
            }

            public void Open()
            {
                throw new NotImplementedException();
            }

            public void PartialOpen()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Save()
            {
                throw new NotImplementedException();
            }

            public void Save(ISaveFlags saveFlags)
            {
                throw new NotImplementedException();
            }

            public void SetDirty(bool isDirty)
            {
                throw new NotImplementedException();
            }

            public void SyncToLatest()
            {
                throw new NotImplementedException();
            }

            public void SyncWorkItem(IWorkItemSyncData syncData)
            {
                throw new NotImplementedException();
            }

            public ArrayList Validate()
            {
                throw new NotImplementedException();
            }

            public int AreaId { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public string AreaPath { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public int AttachedFileCount { get { throw new NotImplementedException(); } }

            public IAttachmentCollection Attachments { get { throw new NotImplementedException(); } }

            public DateTime AuthorizedDate { get { throw new NotImplementedException(); } }

            public string ChangedBy { get { throw new NotImplementedException(); } }

            public DateTime ChangedDate { get { throw new NotImplementedException(); } }

            public IWorkItemCollection Collection { get { throw new NotImplementedException(); } }

            public string CreatedBy { get { throw new NotImplementedException(); } }

            public DateTime CreatedDate { get { throw new NotImplementedException(); } }

            public string Description { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public string DisplayForm { get { throw new NotImplementedException(); } }

            public int ExternalLinkCount { get { throw new NotImplementedException(); } }

            public IWorkItemFieldData FieldData { get { throw new NotImplementedException(); } }

            public IFieldCollection Fields { get { return r_Fields; } }

            public string History { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public int HyperLinkCount { get { throw new NotImplementedException(); } }

            public int Id { get { throw new NotImplementedException(); } }

            public int InternalVersion { get { throw new NotImplementedException(); } }

            public bool IsAccessDenied { get { throw new NotImplementedException(); } }

            public bool IsDirty { get { throw new NotImplementedException(); } }

            public bool IsNew { get { throw new NotImplementedException(); } }

            public bool IsOpen { get { throw new NotImplementedException(); } }

            public bool IsPartialOpen { get { throw new NotImplementedException(); } }

            public bool IsReadOnly { get { throw new NotImplementedException(); } }

            public bool IsReadOnlyOpen { get { throw new NotImplementedException(); } }

            public int IterationId { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public string IterationPath { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public IWorkItemLinkData LinkData { get { throw new NotImplementedException(); } }

            public ILinkCollection Links { get { throw new NotImplementedException(); } }

            public string NodeName { get { throw new NotImplementedException(); } }

            public IProject Project { get { throw new NotImplementedException(); } }

            public string Reason { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public int RelatedLinkCount { get { throw new NotImplementedException(); } }

            public int Rev { get { throw new NotImplementedException(); } }

            public DateTime RevisedDate { get { throw new NotImplementedException(); } }

            public int Revision { get { throw new NotImplementedException(); } }

            public IRevisionCollection Revisions { get { throw new NotImplementedException(); } }

            public string State { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public IWorkItemStore Store { get { throw new NotImplementedException(); } }

            public string Tags { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public int TemporaryId { get { throw new NotImplementedException(); } }

            public string Title { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            public IWorkItemType Type { get; set; }

            public Uri Uri { get { throw new NotImplementedException(); } }

            public int Watermark { get { throw new NotImplementedException(); } }

            public IWorkItemLinkCollection WorkItemLinkHistory { get { throw new NotImplementedException(); } }

            public IWorkItemLinkCollection WorkItemLinks { get { throw new NotImplementedException(); } }
            object IWorkItem.this[string name] { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

            object IWorkItem.this[ICoreField id] { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
            private readonly IFieldCollection r_Fields = new FauxFieldCollection();

            private class FauxFieldCollection : List<IField>, IFieldCollection
            {
                public bool Contains(string fieldName)
                {
                    throw new NotImplementedException();
                }

                public bool Contains(int id)
                {
                    throw new NotImplementedException();
                }

                public void CopyTo(Array array, int index)
                {
                    throw new NotImplementedException();
                }

                public void DropCachedData()
                {
                    throw new NotImplementedException();
                }

                public IField GetById(int id)
                {
                    throw new NotImplementedException();
                }

                public IField TryGetById(int id)
                {
                    throw new NotImplementedException();
                }

                public bool IsFixedSize { get { throw new NotImplementedException(); } }

                public bool IsReadOnly { get { throw new NotImplementedException(); } }

                public bool IsSynchronized { get { throw new NotImplementedException(); } }

                public object SyncRoot { get { throw new NotImplementedException(); } }

                IField IFieldCollection.this[ICoreField coreField] { get { throw new NotImplementedException(); } }

                IField IFieldCollection.this[string name] { get { throw new NotImplementedException(); } }
            }
        }

        private class FauxWorkItemType : IWorkItemType
        {
            public XmlDocument Export(bool includeGlobalListsFlag)
            {
                throw new NotImplementedException();
            }

            public string GetNextState(string currentState, string action)
            {
                throw new NotImplementedException();
            }

            public IWorkItem NewWorkItem()
            {
                throw new NotImplementedException();
            }

            public string Description { get { throw new NotImplementedException(); } }

            public string DisplayForm { get { throw new NotImplementedException(); } }

            public IFieldDefinitionCollection FieldDefinitions { get { throw new NotImplementedException(); } }

            public string Name { get; set; }

            public IProject Project { get { throw new NotImplementedException(); } }

            public IWorkItemStore Store { get { throw new NotImplementedException(); } }
        }
    }
}