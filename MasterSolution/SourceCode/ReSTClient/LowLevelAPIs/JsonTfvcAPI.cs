using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.TFVC;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonTfvcAPI.
    /// </summary>
    internal class JsonTfvcAPI : VsoRestAPIBase
    {
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
        /// Gets the changeset changes.
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
        /// Gets the changeset work items.
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
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetChangesetsBatch()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ChangesetsBatch);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
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
        ///     Gets the label items.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetLabelItems()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.LabelItems);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the project info_0.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProjectInfo>> GetProjectInfo_0()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ProjectInfo0);
            IReadOnlyList<JsonProjectInfo> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProjectInfo.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the project info_1.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonProjectInfo>> GetProjectInfo_1()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ProjectInfo1);
            IReadOnlyList<JsonProjectInfo> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonProjectInfo.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelveset changes_0.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetShelvesetChanges_0()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ShelvesetChanges0);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelveset changes_1.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetShelvesetChanges_1()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ShelvesetChanges1);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelveset work items_0.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetShelvesetWorkItems_0()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ShelvesetWorkItems0);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelveset work items_1.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetShelvesetWorkItems_1()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.ShelvesetWorkItems1);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelvesets_0.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonShelveSet>> GetShelvesets_0()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.Shelvesets0);
            IReadOnlyList<JsonShelveSet> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonShelveSet.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the shelvesets_1.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonShelveSet>> GetShelvesets_1()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(TfvcRestCalls.Shelvesets1);
            IReadOnlyList<JsonShelveSet> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonShelveSet.FromToken));
            return result;
        }
    }
}