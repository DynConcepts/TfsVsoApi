using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    /// <summary>
    ///     Class JsonCodeLensAPI.
    /// </summary>
    internal class JsonCodeLensAPI : VsoRestAPIBase
    {
        /// <summary>
        ///     Gets the details.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetDetails()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(codelensRestCalls.filedetails);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }

        /// <summary>
        ///     Gets the summaries.
        /// </summary>
        /// <returns>Task&lt;IReadOnlyList&lt;JsonGeneralPurposeObject&gt;&gt;.</returns>
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetSummaries()
        {
            StructuredHttpExchange exchange = StructuredHttpExchange.Get(codelensRestCalls.filesummaries);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }
    }
}