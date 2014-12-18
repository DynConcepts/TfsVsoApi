using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.ObjectModelClient.Wrappers;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
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
        /// <param name="projectNanme"></param>
        /// <param name="workItemTypeName"></param>
        /// <param name="headings">The headings.</param>
        /// <param name="data">The data.</param>
        /// <returns>IWorkItem.</returns>
        public IWorkItem BuildWorkItem(string projectNanme, string workItemTypeName, IReadOnlyList<string> headings, IReadOnlyList<object> data)
        {
            var dictionary = new Dictionary<string, object>();
            for (int index = 0; index < headings.Count; ++index)
            {
                string fieldName = headings[index];
                object fieldValue = data[index];
                dictionary.Add(fieldName, fieldValue);
            }

            var projectName = (string) FindAndRemove(dictionary, "System.Project");

            IWorkItemStore workItemStore = WorkItemStore();
            IProject project = workItemStore.Projects[projectName];
            IWorkItemTypeCollection workItemTypes = project.WorkItemTypes;
            IWorkItemType workItemType = null;
            foreach (IWorkItemType entry in workItemTypes)
            {
                if (entry.Name == workItemTypeName)
                {
                    workItemType = entry;
                }
            }

            var workItem = new WorkItem(WorkItemTypeWrapper.GetInstance(workItemType));
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
                workItem.Save();
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
                IWorkItemStore workItemStore = WorkItemStore();
                IProject project = workItemStore.Projects[projectName];
                INodeCollection areaRootNodes = project.AreaRootNodes;
                var result = new List<IArea>();
                foreach (INode areaNode in areaRootNodes)
                {
                    result.Add(AreaWrapper.CreateWrapper(areaNode));
                    foreach (INode childNode in areaNode.ChildNodes)
                    {
                        result.Add(AreaWrapper.CreateWrapper(childNode));
                    }
                }
                return (IReadOnlyList<IArea>) result;
            });
        }


        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IFieldDefinition&gt;&gt;.</returns>
        public Task<IReadOnlyList<IFieldDefinition>> GetFieldDefinitions()
        {
            return AsyncOperation(() =>
            {
                IWorkItemStore workItemStore = WorkItemStore();
                var result = new List<IFieldDefinition>();
                foreach (IProject project in workItemStore.Projects)
                {
                    foreach (IWorkItemType workItemType in project.WorkItemTypes)
                    {
                        foreach (IFieldDefinition fieldDefinition in workItemType.FieldDefinitions)
                        {
                            result.Add(fieldDefinition);
                        }
                    }
                }
                return (IReadOnlyList<IFieldDefinition>) result;
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
                IWorkItemStore workItemStore = WorkItemStore();
                IProject project = workItemStore.Projects[projectName];
                var result = new List<IIteration>();
                foreach (INode areaNode in project.IterationRootNodes)
                {
                    result.Add(IterationWrapper.CreateWrapper(areaNode));
                    foreach (INode childNode in areaNode.ChildNodes)
                    {
                        result.Add(IterationWrapper.CreateWrapper(childNode));
                    }
                }
                return (IReadOnlyList<IIteration>) result;
            });
        }

        /// <summary>
        ///     Gets the work item links.
        /// </summary>
        /// <param name="workItem">The work item.</param>
        /// <returns>List&lt;ILink&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<ILinkCollection> GetLinksForWorkItem(IWorkItem workItem) { throw new NotImplementedException(); }

        /// <summary>
        ///     Gets the relation types.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IRelationType&gt;&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IReadOnlyList<IRelationType>> GetRelationTypes() { throw new NotImplementedException(); }

        /// <summary>
        ///     Gets the work item type categories.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;ICategory&gt;&gt;.</returns>
        public Task<IReadOnlyList<ICategory>> GetWorkItemTypeCategories(string projectName)
        {
            return AsyncOperation(() =>
            {
                IWorkItemStore workItemStore = WorkItemStore();
                IProject project = workItemStore.Projects[projectName];
                ICategoryCollection workItemTypeCategoriess = project.Categories;
                var result = new List<ICategory>();
                foreach (ICategory item in workItemTypeCategoriess)
                {
                    result.Add(item);
                }
                return (IReadOnlyList<ICategory>) result;
            });
        }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemType&gt;&gt;.</returns>
        public Task<IReadOnlyDictionary<string, IWorkItemType>> GetWorkItemTypes(string projectName)
        {
            return AsyncOperation(() =>
            {
                IWorkItemStore workItemStore = WorkItemStore();
                IProject project = workItemStore.Projects[projectName];
                IWorkItemTypeCollection workItemTypes = project.WorkItemTypes;
                var result = new Dictionary<string, IWorkItemType>();
                foreach (IWorkItemType item in workItemTypes)
                {
                    result.Add(item.Name, item);
                }
                return (IReadOnlyDictionary<string, IWorkItemType>) result;
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
                IWorkItemStore workItemStore = WorkItemStore();
                var result = (IReadOnlyList<IWorkItem>) ids.Select(id => workItemStore.GetWorkItem(id)).ToList();
                return result;
            });
        }


        /// <summary>
        ///     Wiqls the query.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">if set to <c>true</c> [fully populate].</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItem&gt;&gt;.</returns>
        public Task<IReadOnlyList<IWorkItem>> WiqlQuery(string wiql, bool fullyPopulate)
        {
            return AsyncOperation(() =>
            {
                IWorkItemStore workItemStore = WorkItemStore();
                IWorkItemCollection witCollection = workItemStore.Query(wiql);
                var result = new List<IWorkItem>();
                foreach (IWorkItem item in witCollection)
                {
                    result.Add(item);
                }
                return (IReadOnlyList<IWorkItem>) result;
            });
        }

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