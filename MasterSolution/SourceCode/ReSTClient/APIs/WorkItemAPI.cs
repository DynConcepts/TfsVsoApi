using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    internal class WorkItemAPI : VsoRestAPIBase, IWorkItemAPI
    {
        /// <summary>
        /// Gets the work item links.
        /// </summary>
        /// <param name="workItem">The work item.</param>
        /// <returns>List&lt;ILink&gt;.</returns>
        public async Task<IReadOnlyList<ILink>> GetWorkItemLinks(IWorkItem workItem)
        {
            string request = String.Format("/wit/workitems/{0}/revisions/{1}/?$expand=relations", workItem.Id, workItem.Rev);
            JsonWorkItem result = await ProcessCollectionGetRequest(request, o => JsonParsers.JObjectToInstance(o, JsonWorkItem.FromToken));
            var resultLinks = result.Links;
            return resultLinks;
        }

        public async Task<IReadOnlyList<IRelationType>> GetRelationTypes()
        {
            const string request = "/wit/workitemrelationtypes";
            IReadOnlyList<IRelationType> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonRelationType.FromToken));
            return result;
        }

        /// <summary>
        /// Initializes static members of the <see cref="WorkItemAPI"/> class.
        /// </summary>
        static WorkItemAPI()
        {
            JsonWorkItem.APIFactory = ()=> new WorkItemAPI();
        }


        /// <summary>
        ///     Builds the work item.
        /// </summary>
        /// <param name="headings">The headings.</param>
        /// <param name="data">The data.</param>
        /// <returns>IWorkItem.</returns>
        public IWorkItem BuildWorkItem(IReadOnlyList<string> headings, IReadOnlyList<object> data)
        {
            var retVal = new JsonWorkItem();
            for (int index = 0; index < headings.Count; ++index)
                retVal.SetField(headings[index], data[index]);
            return retVal;
        }

        /// <summary>
        ///     Creates the work item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="workItem">The work item.</param>
        /// <returns>Task&lt;IWorkItem&gt;.</returns>
        public async Task<IWorkItem> CreateWorkItem(string project, IWorkItem workItem)
        {
            Task<IReadOnlyList<IWorkItemFieldDefinition>> task = GetFields();
            IReadOnlyList<IWorkItemFieldDefinition> fieldDefinitions = task.Result;

            string request = String.Format("/wit/workitems/${0}", workItem.WorkItemType.Replace(" ", "%20"));

            JArray elements = JsonWorkItem.ToJArray(fieldDefinitions, workItem);
            string body = ToJsonString(elements);
            IWorkItem result = await ProcessProjectPatchRequest(project, request, body, jObject =>
            {
                ((JsonWorkItem) workItem).SetJsonContent(jObject);

                return workItem;
            });
            return result;
        }

        /// <summary>
        ///     Gets the areas.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IList&lt;IArea&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IArea>> GetAreas(string project, int depth)
        {
            string request = "/wit/classificationNodes/areas?$depth=" + depth;
            IArea result = await ProcessProjectGetRequest(project, request, o => JsonParsers.JObjectToInstance(o, JsonArea.FromToken));
            var retVal = new List<IArea> {result};
            AddChildren(retVal, result);
            return retVal;
        }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <returns>Task&lt;IList&lt;IWorkItemFieldDefinition&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItemFieldDefinition>> GetFields()
        {
            const string request = "/wit/fields";
            IReadOnlyList<IWorkItemFieldDefinition> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonWorkItemFieldDefinition.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the iterations.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IIteration&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IIteration>> GetIterations(string project, int depth)
        {
            string request = "/wit/classificationNodes/iterations?$depth=" + depth;
            IIteration result = await ProcessProjectGetRequest(project, request, o => JsonParsers.JObjectToInstance(o, JsonIteration.FromToken));
            var retVal = new List<IIteration> {result};
            AddChildren(retVal, result);
            return retVal;
        }

        /// <summary>
        ///     Gets the work item type categories.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IList&lt;IWorkItemTypeCategory&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItemTypeCategory>> GetWorkItemTypeCategories(string project)
        {
            const string request = "/wit//workitemtypecategories";
            IReadOnlyList<IWorkItemTypeCategory> result = await ProcessProjectGetRequest(project, request, o => JsonParsers.ValuesToObjects(o, JsonWorkItemTypeCategory.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;IWorkItemType&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItemType>> GetWorkItemTypes(string project)
        {
            const string request = "/wit/workitemtypes";
            IReadOnlyList<IWorkItemType> result = await ProcessProjectGetRequest(project, request, o => JsonParsers.ValuesToObjects(o, JsonWorkItemType.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItem>> GetWorkItems(IEnumerable<int> ids)
        {
            IReadOnlyList<JsonWorkItem> result = await JsonWorkItemsLoader(ids);
            return result;
        }

        /// <summary>
        ///     Wiqls the query.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">if set to <c>true</c> [fully populate].</param>
        /// <returns>Task&lt;IList&lt;IWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<IWorkItem>> WiqlQuery(string project, string wiql, bool fullyPopulate)
        {
            const string request = "/wit/wiql";
            const string format = " \"query\": \"{0}\" ";
            string body = "{" + String.Format(format, wiql) + "}";
            IReadOnlyList<JsonWorkItem> result = await ProcessProjectPostRequest(project, request, body, JsonParsers.WiqlQueryParse);

            var retVal = new List<IWorkItem>();
            if (fullyPopulate)
            {
                List<int> ids = result.Select(workItem => workItem.Id).ToList();
                Task<IReadOnlyList<JsonWorkItem>> populated = JsonWorkItemsLoader(ids);
                retVal.AddRange(populated.Result);
            }
            else
            {
                retVal.AddRange(result);
            }
            return retVal;
        }

        /// <summary>
        ///     Adds the children.
        /// </summary>
        /// <param name="retVal">The ret value.</param>
        /// <param name="result">The result.</param>
        private static void AddChildren(List<IArea> retVal, IArea result)
        {
            foreach (IArea child in result.Children)
            {
                retVal.Add(child);
                AddChildren(retVal, child);
            }
        }

        private static void AddChildren(List<IIteration> retVal, IIteration result)
        {
            foreach (IIteration child in result.Children)
            {
                retVal.Add(child);
                AddChildren(retVal, child);
            }
        }

        /// <summary>
        ///     Gets the work item as JsonWorkItem. This is used privately to allow for manipulations
        ///     that would not be feasible (without casting) using the IWorkItem interface.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonWorkItem&gt;&gt;.</returns>
        private async Task<IReadOnlyList<JsonWorkItem>> JsonWorkItemsLoader(IEnumerable<int> ids)
        {
            string request = "/wit/workitems?ids=" + ToCommaList(ids);

            IReadOnlyList<JsonWorkItem> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonWorkItem.FromToken));
            return result;
        }

        public IWorkItem GetWorkItem(Uri uri) { return ProcessGetRequest(uri, JsonWorkItem.FromToken).Result; }
    }
}