using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.RestCalls;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonTfvcAPI.
    /// </summary>
    internal class JsonTfvcAPI : VsoRestAPIBase
    {
        /// <summary>
        ///     Gets all project information.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonProjectInfo&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProjectInfo>> GetAllProjectInfo()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.AllProjectInfo);
            IReadOnlyList<JsonProjectInfo> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProjectInfo.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the branches.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetBranches()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.Branches);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the changeset changes.
        /// </summary>
        /// <param name="changeSetId">The change set identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonChangeSetChanges>> GetChangesetChanges(int changeSetId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ChangesetChanges);
            exchange.SetRoute("{id}", changeSetId);
            IReadOnlyList<JsonChangeSetChanges> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonChangeSetChanges.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the changeset work items.
        /// </summary>
        /// <param name="changeSetId">The change set identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetChangesetWorkItems(int changeSetId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ChangesetWorkItems);
            exchange.SetRoute("{id}", changeSetId);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the changesets.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonChangeSet>> GetChangesets()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.Changesets);
            IReadOnlyList<JsonChangeSet> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonChangeSet.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the changesets batch.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonChangeSet&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonChangeSet>> GetChangesetsBatch(List<int> ids)
        {
            var json = new JObject();
            var array = new JArray();
            foreach (int id in ids)
            {
                array.Add(id);
            }
            json.Add("changesetIds", array);
            json.Add("commentLength", 255);
            string body = json.ToString();
            StructuredHttpExchange exchange = StructuredHttpExchange.Post(TfvcRestCalls.ChangesetsBatch, body);
            IReadOnlyList<JsonChangeSet> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonChangeSet.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the item batch.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetItemBatch()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ItemBatch);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the items.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonVersionControlItem>> GetItems()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.Items);
            IReadOnlyList<JsonVersionControlItem> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonVersionControlItem.FromToken));
            return result;
        }

        /// <summary>
        /// Gets the label items.
        /// </summary>
        /// <param name="labelId">The label identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonTfvcLabelItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonTfvcLabelItem>> GetLabelItems(int labelId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.LabelItems);
            exchange.SetRoute("{labelId}", labelId);
            IReadOnlyList<JsonTfvcLabelItem> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonTfvcLabelItem.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the labels.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonTfvcLabel&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonTfvcLabel>> GetLabels()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.Labels);
            IReadOnlyList<JsonTfvcLabel> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonTfvcLabel.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the project specific information.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonProjectInfo&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProjectInfo>> GetProjectSpecificInfo(string project)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ProjectSpecificInfo);
            exchange.SetRoute("{projectId}", project);
            IReadOnlyList<JsonProjectInfo> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProjectInfo.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelveset changes_0.
        /// </summary>
        /// <param name="shelvesetId"></param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonShelveSetChange>> GetShelvesetChanges(string shelvesetId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ShelvesetChanges);
            exchange.SetRoute("{shelvesetId}", shelvesetId);
            IReadOnlyList<JsonShelveSetChange> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonShelveSetChange.FromToken));
            return result;
        }


        /// <summary>
        ///     Gets the shelveset work items.
        /// </summary>
        /// <param name="shelvesetId">The shelveset identifier.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonWorkItem&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonWorkItem>> GetShelvesetWorkItems(string shelvesetId)
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ShelvesetWorkItems);
            exchange.SetRoute("{shelvesetId}", shelvesetId);
            IReadOnlyList<JsonWorkItem> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonWorkItem.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelvesets_0.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonShelveSet>> GetShelvesets()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.AllShelvesets);
            IReadOnlyList<JsonShelveSet> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonShelveSet.FromToken));
            return result;
        }
    }
}