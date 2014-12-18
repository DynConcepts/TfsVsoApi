using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.APIs
{
    /// <summary>
    ///     Class WorkItemAPI.
    /// </summary>
    internal class WorkItemAPI : ClientObjectModelBasedAPI, IWorkItemAPI
    {
        /// <summary>
        ///     Builds the work item.
        /// </summary>
        /// <param name="headings">The headings.</param>
        /// <param name="data">The data.</param>
        /// <returns>IWorkItem.</returns>
        public IWorkItem BuildWorkItem(IReadOnlyList<string> headings, IReadOnlyList<object> data)
        {
            var dictionary = new Dictionary<string, object>();
            for (int index = 0; index < headings.Count; ++index)
            {
                string fieldName = headings[index];
                object fieldValue = data[index];
                dictionary.Add(fieldName, fieldValue);
            }

            var projectName = (string) FindAndRemove(dictionary, "System.Project");
            var workItemTypeName = (string) FindAndRemove(dictionary, "System.WorkItemType");

            WorkItemStoreHelper workItemStore = WorkItemStore();
            Project project = workItemStore.Projects[projectName];
            WorkItemTypeCollection workItemTypes = project.WorkItemTypes;
            WorkItemType workItemType = null;
            foreach (WorkItemType entry in workItemTypes)
            {
                if (entry.Name == workItemTypeName)
                {
                    workItemType = entry;
                }
            }

            var workItem = new WorkItem(workItemType);
            foreach (KeyValuePair<string, object> pair in dictionary)
            {
                string fieldName = pair.Key;
                object fieldValue = pair.Value;
                workItem[fieldName] = fieldValue;
            }
            return WorkItemWrapper.GetWrapper(workItem);
        }

        /// <summary>
        ///     Creates the work item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="workItem">The work item.</param>
        /// <returns>Task&lt;IWorkItem&gt;.</returns>
        public Task<IWorkItem> CreateWorkItem(string project, IWorkItem workItem)
        {
            return AsyncOperation(() =>
            {
                var wrapper = workItem as WorkItemWrapper;
                int originalId = wrapper.Id;
                wrapper.Save();
                int finalId = wrapper.Id;
                int exposedId = workItem.Id;
                return workItem;
            });
        }

        /// <summary>
        ///     Gets the areas.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IArea&gt;&gt;.</returns>
        public Task<IReadOnlyList<IArea>> GetAreas(string projectName, int depth)
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                Project project = workItemStore.Projects[projectName];
                var result = new List<IArea>();
                foreach (Node areaNode in project.AreaRootNodes)
                {
                    result.Add(new AreaWrapper(areaNode));
                    foreach (Node childNode in areaNode.ChildNodes)
                    {
                        result.Add(new AreaWrapper(childNode));
                    }
                }
                return (IReadOnlyList<IArea>) result;
            });
        }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemFieldDefinition&gt;&gt;.</returns>
        public Task<IReadOnlyList<IWorkItemFieldDefinition>> GetFields()
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                var result = new List<IWorkItemFieldDefinition>();
                foreach (Project project in workItemStore.Projects.Values)
                {
                    foreach (WorkItemType workItemType in project.WorkItemTypes)
                    {
                        foreach (FieldDefinition fieldDefinition in workItemType.FieldDefinitions)
                        {
                            result.Add(new WorkItemFieldWrapper(fieldDefinition));
                        }
                    }
                }
                return (IReadOnlyList<IWorkItemFieldDefinition>) result;
            });
        }

        /// <summary>
        ///     Gets the iterations.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IIteration&gt;&gt;.</returns>
        public Task<IReadOnlyList<IIteration>> GetIterations(string projectName, int depth)
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                Project project = workItemStore.Projects[projectName];
                var result = new List<IIteration>();
                foreach (Node areaNode in project.IterationRootNodes)
                {
                    result.Add(new IterationWrapper(areaNode));
                    foreach (Node childNode in areaNode.ChildNodes)
                    {
                        result.Add(new IterationWrapper(childNode));
                    }
                }
                return (IReadOnlyList<IIteration>) result;
            });
        }

        /// <summary>
        ///     Gets the work item type categories.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemTypeCategory&gt;&gt;.</returns>
        public Task<IReadOnlyList<IWorkItemTypeCategory>> GetWorkItemTypeCategories(string projectName)
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                Project item = workItemStore.Projects[projectName];
                CategoryCollection workItemTypeCategoriess = item.Categories;
                List<IWorkItemTypeCategory> result = (from Category workItemTypCategory in workItemTypeCategoriess select new WorkItemTypeCategoryWrapper(workItemTypCategory)).Cast<IWorkItemTypeCategory>().ToList();
                return (IReadOnlyList<IWorkItemTypeCategory>) result;
            });
        }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemType&gt;&gt;.</returns>
        public Task<IReadOnlyList<IWorkItemType>> GetWorkItemTypes(string projectName)
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                Project item = workItemStore.Projects[projectName];
                WorkItemTypeCollection workItemTypes = item.WorkItemTypes;
                List<IWorkItemType> result = (from WorkItemType workItemType in workItemTypes select WorkItemTypeWrapper.GetWrapper(workItemType)).ToList();
                return (IReadOnlyList<IWorkItemType>) result;
            });
        }

        /// <summary>
        ///     Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public Task<IReadOnlyList<IWorkItem>> GetWorkItems(IEnumerable<int> ids)
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                var result = (IReadOnlyList<IWorkItem>) ids.Select(workItemStore.GetWorkItem).Cast<IWorkItem>().ToList();
                return result;
            });
        }


        /// <summary>
        ///     Wiqls the query.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">if set to <c>true</c> [fully populate].</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItem&gt;&gt;.</returns>
        public Task<IReadOnlyList<IWorkItem>> WiqlQuery(string project, string wiql, bool fullyPopulate)
        {
            return AsyncOperation(() =>
            {
                WorkItemStoreHelper workItemStore = WorkItemStore();
                WorkItemCollection witCollection = workItemStore.Query(wiql);
                var wrapper = new WorkItemCollectionWrapper(witCollection);
                List<IWorkItem> result = wrapper.Cast<IWorkItem>().ToList();
                return (IReadOnlyList<IWorkItem>) result;
            });
        }

        /// <summary>
        /// Gets the relation types.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IRelationType&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IReadOnlyList<IRelationType>> GetRelationTypes() { throw new System.NotImplementedException(); }

        /// <summary>
        /// Gets the work item links.
        /// </summary>
        /// <param name="workItem">The work item.</param>
        /// <returns>List&lt;ILink&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IReadOnlyList<ILink>> GetWorkItemLinks(IWorkItem workItem) { throw new System.NotImplementedException(); }

        /// <summary>
        ///     Finds the and remove.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>System.Object.</returns>
        private static object FindAndRemove(Dictionary<string, object> dictionary, string fieldName)
        {
            object value = dictionary[fieldName];
            dictionary.Remove(fieldName);
            return value;
        }
    }
}