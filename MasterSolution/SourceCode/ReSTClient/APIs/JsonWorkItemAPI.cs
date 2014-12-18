using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
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
        /// <param name="fieldValues">The field values.</param>
        /// <returns>JsonWorkItem.</returns>
        public JsonWorkItem BuildWorkItem(string projectNanme, string workItemTypeName, IReadOnlyList<KeyValuePair<string, object>> fieldValues) { return BuildWorkItem(projectNanme, workItemTypeName, fieldValues, JsonWorkItem.FromToken); }

        public TWorkItem BuildWorkItem<TWorkItem>(string projectNanme, string workItemTypeName, IReadOnlyList<KeyValuePair<string, object>> fieldValues, Func<JToken, TWorkItem> fromToken) where TWorkItem : JsonWorkItem
        {
            Task<IReadOnlyDictionary<string, JsonWorkItemType>> workItemTypes = JsonWorkItem.APIFactory().GetWorkItemTypes(projectNanme);
            JsonWorkItemType workItemType = workItemTypes.Result[workItemTypeName];
            JsonFieldDefinitionCollection definitions = workItemType.FieldDefinitions;
            var json = new JObject();
            json.Add(new JProperty("id", "-1"));
            json.Add(new JProperty("rev", "-1"));
            json.Add(new JProperty("url", "http://example.com"));
            var jFieldContainer = new JObject();
            var jFieldsProperty = new JProperty("fields", jFieldContainer);
            foreach (JsonFieldDefinition fieldDefinition in definitions)
            {
                object content = null;
                switch (fieldDefinition.ReferenceName)
                {
                    case "System.TeamProject":
                        content = projectNanme;
                        break;
                    case "System.WorkItemType":
                        content = workItemTypeName;
                        break;
                    case "System.Id":
                        content = -1;
                        break;
                    case "System.Rev":
                        content = -1;
                        break;
                }
                var jProperty = new JProperty(fieldDefinition.ReferenceName, content);
                jFieldContainer.Add(jProperty);
            }
            json.Add(jFieldsProperty);
            TWorkItem retVal = fromToken(json);
            foreach (KeyValuePair<string, object> field in fieldValues)
                retVal.SetFieldValue(field.Key, field.Value);
            return retVal;
        }

        /// <summary>
        /// Creates the work item.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="workItemType">Type of the work item.</param>
        /// <param name="workItem">The work item.</param>
        /// <param name="inPlaceUpdate">if set to <c>true</c> [in place update].</param>
        /// <returns>Task&lt;JsonWorkItem&gt;.</returns>
        public async Task<JsonWorkItem> CreateWorkItem(string project, string workItemType, JsonWorkItem workItem, bool inPlaceUpdate)
        {
            string request = String.Format("/wit/workitems/${0}", workItemType.Replace(" ", "%20"));

            JArray elements = JsonWorkItem.FieldsToJArray(workItem);
            string body = ToJsonString(elements);
            JsonWorkItem result = await ProcessProjectPatchRequest(project, request, body, jObject =>
            {
                if (inPlaceUpdate)
                {
                    workItem.CaptureJson(jObject);
                    return workItem;
                }
                else
                {
                    JsonWorkItem newWorkItem = JsonWorkItem.FromToken(jObject);
                    return newWorkItem;
                }
            });
            return result;
        }

        /// <summary>
        ///     Gets the areas.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="depth">The depth.</param>
        /// <returns>Task&lt;IList&lt;IArea&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonArea>> GetAreas(string project, int depth) { return await GetAreas(project, depth, JsonArea.FromToken); }

        public async Task<IReadOnlyList<TArea>> GetAreas<TArea>(string project, int depth, Func<JObject, TArea> fromToken) where TArea : JsonArea
        {
            string request = "/wit/classificationNodes/areas?$depth=" + depth;
            TArea result = await ProcessProjectGetRequest(project, request, o => JsonParsers.JObjectToInstance(o, fromToken));
            var retVal = new List<TArea> {result};
            AddChildAreas(retVal, result);
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
        public async Task<IReadOnlyList<IIteration>> GetIterations(string project, int depth) { return await GetIterations(project, depth, JsonIteration.FromToken); }

        public async Task<IReadOnlyList<TIteration>> GetIterations<TIteration>(string project, int depth, Func<JObject, TIteration> fromToken) where TIteration : JsonIteration
        {
            string request = "/wit/classificationNodes/iterations?$depth=" + depth;
            TIteration result = await ProcessProjectGetRequest(project, request, o => JsonParsers.JObjectToInstance(o, fromToken));
            var retVal = new List<TIteration> {result};
            AddChildIterations(retVal, result);
            return retVal;
        }

        /// <summary>
        ///     Gets the links for work item.
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
            TLinkCollection result = await ProcessCollectionGetRequest(request, o =>
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
                TLinkCollection collection = JsonParsers.JArrayToInstance(values, fromToken);
                return collection;
            });
            return result;
        }

        public async Task<JsonLinkCollection> GetLinksForWorkItem(JsonWorkItem workItem) { return await GetLinksForWorkItem(workItem.Id, workItem.Rev, JsonLinkCollection.FromToken); }

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

        public T GetWorkItem<T>(Uri uri, Func<JObject, T> fromToken) where T : JsonWorkItem { return ProcessGetRequest(uri, fromToken).Result; }


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
        public async Task<IReadOnlyDictionary<string, JsonWorkItemType>> GetWorkItemTypes(string project) { return await GetWorkItemTypes(project, JsonWorkItemType.FromToken); }

        /// <summary>
        ///     Gets the work item types.
        /// </summary>
        /// <typeparam name="TWorkItemType">The type of the t work item type.</typeparam>
        /// <param name="project">The project.</param>
        /// <param name="fromToken">From token.</param>
        /// <returns>Task&lt;IReadOnlyDictionary&lt;System.String, TWorkItemType&gt;&gt;.</returns>
        public async Task<IReadOnlyDictionary<string, TWorkItemType>> GetWorkItemTypes<TWorkItemType>(string project, Func<JToken, TWorkItemType> fromToken) where TWorkItemType : JsonWorkItemType
        {
            const string request = "/wit/workitemtypes";
            IReadOnlyList<TWorkItemType> result = await ProcessProjectGetRequest(project, request, o => JsonParsers.ValuesToObjects(o, fromToken));
            return (IReadOnlyDictionary<string, TWorkItemType>) result.ToDictionary(entry => entry.Name);
        }

        /// <summary>
        ///     Gets the work items.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonWorkItem>> GetWorkItems(IEnumerable<int> ids) { return await GetWorkItems(ids, JsonWorkItem.FromToken); }


        public async Task<IReadOnlyList<T>> WiqlQuery<T>(string wiql, bool fullyPopulate, Func<JToken, T> fromToken) where T : JsonWorkItem
        {
            const string request = "/wit/wiql";
            const string format = " \"query\": \"{0}\" ";
            string body = "{" + String.Format(format, wiql) + "}";
            JsonParsers.QueryResult<T> result = await ProcessCollectionPostRequest(request, body, o => JsonParsers.WiqlQueryParse(o, fromToken));

            var retVal = new List<T>();
            if (fullyPopulate)
            {
                List<int> ids = result.Items.Select(workItem => workItem.Id).ToList();
                Task<IReadOnlyList<T>> populated = JsonWorkItemsLoader(ids, result.TimeStamp, fromToken);
                retVal.AddRange(populated.Result);
            }
            else
            {
                foreach (T item in result.Items)
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

   
        /// <summary>
        ///     Initializes static members of the <see cref="JsonWorkItemAPI" /> class.
        /// </summary>
        static JsonWorkItemAPI() { JsonWorkItem.APIFactory = () => new JsonWorkItemAPI(); }

        /// <summary>
        ///     Adds the children.
        /// </summary>
        /// <param name="retVal">The ret value.</param>
        /// <param name="result">The result.</param>
        private static void AddChildAreas<TArea>(List<TArea> retVal, TArea result) where TArea : JsonArea
        {
            foreach (TArea child in result.Children)
            {
                retVal.Add(child);
                AddChildAreas(retVal, child);
            }
        }

        /// <summary>
        ///     Adds the children.
        /// </summary>
        /// <param name="retVal">The ret value.</param>
        /// <param name="result">The result.</param>
        private static void AddChildIterations<TIteration>(List<TIteration> retVal, TIteration result) where TIteration : JsonIteration
        {
            foreach (TIteration child in result.Children)
            {
                retVal.Add(child);
                AddChildIterations(retVal, child);
            }
        }

        internal async Task<LinkCollectionImpl> GetLinksForWorkItem(WorkItemImpl workItem) { return await GetLinksForWorkItem(workItem.Id, workItem.Rev, LinkCollectionImpl.FromToken); }

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

        internal async Task<IReadOnlyList<JsonWorkItemRevision>> GetWorkItemRevisions(int id) { return await GetWorkItemRevisions(id, JsonWorkItemRevision.FromToken); }

        internal async Task<IReadOnlyList<T>> GetWorkItems<T>(IEnumerable<int> ids, Func<JToken, T> func) where T : JsonWorkItem
        {
            IReadOnlyList<T> result = await JsonWorkItemsLoader(ids, func);
            return result;
        }

        private async Task<IReadOnlyList<T>> JsonWorkItemsLoader<T>(IEnumerable<int> ids, DateTime timeStamp, Func<JToken, T> func) where T : JsonWorkItem
        {
            string request = String.Format("/wit/workitems?ids={0}&fields=System.Title&asOf={1}",ToCommaList(ids),timeStamp.ToString("o"));

            IReadOnlyList<T> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, func));
            return result;
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

        public async Task<JsonWorkItem> UpdateWorkItem(string project, JsonWorkItem workItem)
        {
            string request = String.Format("/wit/workitems/{0}/", workItem.Id);

            JArray elements = JsonWorkItem.FieldsToJArray(workItem);
            string body = ToJsonString(elements);
            JsonWorkItem result = await ProcessProjectPatchRequest(project, request, body, jObject =>
            {
                JsonWorkItem newWorkItem = JsonWorkItem.FromToken(jObject);
                return newWorkItem;
            });
            return result;
        }

        public async Task<IReadOnlyList<JsonQueryBase>> GetQueries(string project)
        {
            const string request = "/wit/queries/?$depth=1";
            IReadOnlyList<JsonQueryBase> results = await ProcessProjectGetRequest(project, request, o => JsonParsers.ValuesToObjects(o, JsonQueryBase.FromToken));
            var all = new List<JsonQueryBase>();
            foreach (var item in results)
            {
                var asFolder = item as JsonQueryFolder;
                if (asFolder != null)
                {
                    foreach (var child in asFolder.Children)
                    {
                        if (child.IsFolder)
                             await GetChildQueries(project, child as JsonQueryFolder);
                    }
                }
            }
            return results;
        }

        public async Task<IReadOnlyList<JsonQueryBase>> GetChildQueries(string project, JsonQueryFolder parent)
        {
            string request = String.Format("/wit/queries/{0}?$depth=1", parent.Path);
            var result =(JsonQueryFolder) await ProcessProjectGetRequest(project, request, JsonQueryBase.FromToken);
            foreach (var child in result.Children)
            {
                parent.AddChild(child);
                if (child.IsFolder /* && item.HasChildren*/)
                {
                    await GetChildQueries(project, child as JsonQueryFolder);
                }
            }
            return parent.Children;
        }
    }
}