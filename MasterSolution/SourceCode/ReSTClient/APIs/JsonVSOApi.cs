using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.Objects;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    public class JsonVSOApi : VsoRestAPIBase
    {
        public async Task<IReadOnlyList<JsonAvailableRestCall>> GetAvailableRestCalls()
        {
            var exchange = StructuredHttpExchange.Options("");
            IReadOnlyList<JsonAvailableRestCall> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, JsonAvailableRestCall.FromToken));
            return result;
        }
    }
}