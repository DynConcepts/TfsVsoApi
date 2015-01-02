using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.APIs;
using DynCon.OSI.VSO.ReSTClient.RestCalls;

namespace DynCon.OSI.VSO.ReSTClient.LowLevelAPIs
{
    class JsonAgileAPI : VsoRestAPIBase
    {
        public async Task<IReadOnlyList<JsonGeneralPurposeObject>> GetBacklogs()
        {
            var exchange = StructuredHttpExchange.Get(AgileRestCalls.Backlogs);
            IReadOnlyList<JsonGeneralPurposeObject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonGeneralPurposeObject.FromToken));
            return result;
        }
    }
}
