using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    /// <summary>
    ///     Class JsonWorkItemAPI.
    /// </summary>
    public class JsonWorkItemAPI : VsoRestAPIBase
    {
        /// <summary>
        ///     Builds the work item.
        /// </summary>
        /// <param name="projectNanme">The project nanme.</param>
        /// <param name="workItemTypeName">Name of the work item type.</param>
        /// <param name="headings">The headings.</param>
        /// <param name="data">The data.</param>
        /// <returns>JsonWorkItem.</returns>
        public JsonWorkItem BuildWorkItem(string projectNanme, string workItemTypeName, IReadOnlyList<string> headings, IReadOnlyList<object> data)
        {
            Task<IReadOnlyDictionary<string, JsonWorkItemType>> workItemTypes = JsonWorkItem.APIFactory().GetWorkItemTypes(projectNanme);
            JsonWorkItemType workItemType = workItemTypes.Result[workItemTypeName];
            JsonFieldDefinitionCollection definitions = workItemType.FieldDefinitions;
            var json = new JObject();
            var jFieldContainer = new JObject();
            var jProperty = new JProperty("fields", jFieldContainer);
            foreach (JsonFieldDefinition fieldDefinition in definitions)
            {
                jFieldContainer.Add(new JProperty(fieldDefinition.ReferenceName, null));
            }
            json.Add(jProperty);
            var retVal = JsonWorkItem.FromToken(json);
            for (int index = 0; index < headings.Count; ++index)
                retVal.SetFieldValue(headings[index], data[index]);
            return retVal;
        }

        /// <summary>
        ///     Creates the work item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="workItem">The work item.</param>
        /// <returns>Task&lt;JsonWorkItem&gt;.</returns>
        public async Task<JsonWorkItem> CreateWorkItem(string project, JsonWorkItem workItem)
        {
            string request = String.Format("/wit/workitems/${0}", workItem.WorkItemTypeName.Replace(" ", "%20"));

            JArray elements = JsonWorkItem.FieldsToJArray(workItem);
            string body = ToJsonString(elements);
            JsonWorkItem result = await ProcessProjectPatchRequest(project, request, body, jObject =>
            {
                var newWorkItem = JsonWorkItem.FromToken(jObject);
                return newWorkItem;
            });
            return result;
        }

        /// <summary>
        ///     Gets the areas.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IList&lt;IArea&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonArea>> GetAreas(string project, int depth)
        {
            string request = "/wit/classificationNodes/areas?$depth=" + depth;
            JsonArea result = await ProcessProjectGetRequest(project, request, o => JsonParsers.JObjectToInstance(o, JsonArea.FromToken));
            var retVal = new List<JsonArea> {result};
            AddChildren(retVal, result);
            return retVal;
        }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <returns>Task&lt;IList&lt;JsonFieldDefinition&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonFieldDefinition>> GetFieldDefinitions()
        {
            const string request = "/wit/fields";
            IReadOnlyList<JsonFieldDefinition> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonFieldDefinition.FromToken));
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
        /// Gets the links for work item.
        /// </summary>
        /// <typeparam name="TLinkCollection">The type of the t link collection.</typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="rev">The rev.</param>
        /// <param name="fromToken">From token.</param>
        /// <returns>System.Threading.Tasks.Task&lt;TLinkCollection&gt;.</returns>
        public async Task<TLinkCollection> GetLinksForWorkItem<TLinkCollection>(int id, int rev, Func<JArray, TLinkCollection> fromToken)
            where TLinkCollection : JsonLinkCollection
        {
            string request = String.Format("/wit/workitems/{0}/revisions/{1}/?$expand=relations", id, rev);
            var result = await ProcessCollectionGetRequest(request, o =>
            {
                JProperty rootToken = o.Properties().FirstOrDefault(p => p.Name == "relations");
                JArray values;
                if (rootToken != null)
                {
                    values = (JArray) rootToken.Value;
                }
                else
                {
                    values = new JArray();
                }
                var collection = JsonParsers.JArrayToInstance(values, fromToken);
                return collection;
            });
            return result;
        }

        public async Task<JsonLinkCollection> GetLinksForWorkItem(JsonWorkItem workItem) { return await GetLinksForWorkItem(workItem.Id, workItem.Rev, JsonLinkCollection.FromToken); }
        internal async Task<LinkCollectionImpl> GetLinksForWorkItem(WorkItemImpl workItem) { return await GetLinksForWorkItem(workItem.Id, workItem.Rev, LinkCollectionImpl.FromToken); }

        /// <summary>
        ///     Gets the relation types.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;IRelationType&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonRelationType>> GetRelationTypes()
        {
            const string request = "/wit/workitemrelationtypes";
            IReadOnlyList<JsonRelationType> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, JsonRelationType.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>JsonWorkItem.</returns>
        public JsonWorkItem GetWorkItem(Uri uri) { return ProcessGetRequest(uri, JsonWorkItem.FromToken).Result; }
        public T GetWorkItem<T>(Uri uri, Func<JObject, T> fromToken) where T:JsonWorkItem { return ProcessGetRequest(uri, fromToken).Result; }



        /// <summary>
        ///     Gets the work item type categories.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IList&lt;JsonCategory&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonWorkItemTypeCategory>> GetWorkItemTypeCategories(string project)
        {
            const string request = "/wit//workitemtypecategories";
            IReadOnlyList<JsonWorkItemTypeCategory> result = await ProcessProjectGetRequest(project, request, o => JsonParsers.ValuesToObjects(o, JsonWorkItemTypeCategory.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonWorkItemType&gt;&gt;.</returns>
        public async Task<IReadOnlyDictionary<string, JsonWorkItemType>> GetWorkItemTypes(string project)
        {
            const string request = "/wit/workitemtypes";
            IReadOnlyList<JsonWorkItemType> result = await ProcessProjectGetRequest(project, request, o => JsonParsers.ValuesToObjects(o, JsonWorkItemType.FromToken));
            return (IReadOnlyDictionary<string, JsonWorkItemType>) result.ToDictionary(entry => entry.Name);
        }

        /// <summary>
        ///     Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonWorkItem>> GetWorkItems(IEnumerable<int> ids)
        {
            IReadOnlyList<JsonWorkItem> result = await JsonWorkItemsLoader(ids, JsonWorkItem.FromToken);
            return result;
        }

        internal async Task<T> GetWorkItem<T>(int id, Func<JToken, T> func) where T : JsonWorkItem
        {
            IReadOnlyList<T> result = await JsonWorkItemsLoader(new[] {id}, func);
            return result[0];
        }

        internal async Task<IReadOnlyList<T>> GetWorkItemRevisions<T>(int id, Func<JToken, T> func)
        {
            string request = String.Format("/wit/workitems/{0}/revisions", id);
            IReadOnlyList<T> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, func));
            return result;
        }
        internal async Task<IReadOnlyList<JsonWorkItemRevision>> GetWorkItemRevisions(int id)
        {
             return await GetWorkItemRevisions(id, JsonWorkItemRevision.FromToken);
        }


        public async Task<IReadOnlyList<T>> WiqlQuery<T>(string wiql, bool fullyPopulate, Func<JToken, T> mapper) where T : JsonWorkItem
        {
            const string request = "/wit/wiql";
            const string format = " \"query\": \"{0}\" ";
            string body = "{" + String.Format(format, wiql) + "}";
            IReadOnlyList<T> result = await ProcessCollectionPostRequest(request, body, (o) => JsonParsers.WiqlQueryParse(o, mapper));

            var retVal = new List<T>();
            if (fullyPopulate)
            {
                List<int> ids = result.Select(workItem => workItem.Id).ToList();
                Task<IReadOnlyList<T>> populated = JsonWorkItemsLoader(ids, mapper);
                retVal.AddRange(populated.Result);
            }
            else
            {
                foreach (var item in result)
                    retVal.Add(item);
            }
            return retVal;
        }

        /// <summary>
        ///     Wiqls the query.
        /// </summary>
        /// <param name="wiql">The wiql.</param>
        /// <param name="fullyPopulate">if set to <c>true</c> [fully populate].</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonWorkItem>> WiqlQuery(string wiql, bool fullyPopulate) { return await WiqlQuery(wiql, fullyPopulate, JsonWorkItem.FromToken); }

        //public async Task<IReadOnlyList<JsonWorkItem>> WiqlQuery(string project, string wiql, bool fullyPopulate)
        //{
        //    const string request = "/wit/wiql";
        //    const string format = " \"query\": \"{0}\" ";
        //    string body = "{" + String.Format(format, wiql) + "}";
        //    IReadOnlyList<JsonWorkItem> result = await ProcessProjectPostRequest(project, request, body, JsonParsers.WiqlQueryParse);

        //    var retVal = new List<JsonWorkItem>();
        //    if (fullyPopulate)
        //    {
        //        List<int> ids = result.Select(workItem => workItem.Id).ToList();
        //        Task<IReadOnlyList<JsonWorkItem>> populated = JsonWorkItemsLoader(ids);
        //        retVal.AddRange(populated.Result);
        //    }
        //    else
        //    {
        //        retVal.AddRange(result);
        //    }
        //    return retVal;
        //}

        /// <summary>
        ///     Initializes static members of the <see cref="JsonWorkItemAPI" /> class.
        /// </summary>
        static JsonWorkItemAPI() { JsonWorkItem.APIFactory = () => new JsonWorkItemAPI(); }

        /// <summary>
        ///     Adds the children.
        /// </summary>
        /// <param name="retVal">The ret value.</param>
        /// <param name="result">The result.</param>
        private static void AddChildren(List<JsonArea> retVal, JsonArea result)
        {
            foreach (JsonArea child in result.Children)
            {
                retVal.Add(child);
                AddChildren(retVal, child);
            }
        }

        /// <summary>
        ///     Adds the children.
        /// </summary>
        /// <param name="retVal">The ret value.</param>
        /// <param name="result">The result.</param>
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
        ///     that would not be feasible (without casting) using the JsonWorkItem interface.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <param name="func"></param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonWorkItem&gt;&gt;.</returns>
        private async Task<IReadOnlyList<T>> JsonWorkItemsLoader<T>(IEnumerable<int> ids, Func<JToken, T> func) where T : JsonWorkItem
        {
            string request = "/wit/workitems?ids=" + ToCommaList(ids);

            IReadOnlyList<T> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, func));
            return result;
        }

    }
}