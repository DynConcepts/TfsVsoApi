using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Objects;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    internal class VSOApi : VsoRestAPIBase, IVSOApi
    {
        public async Task<IReadOnlyList<IAvailableRestCalls>> GetAvailableRestCalls()
        {
            const string request = "";
            IReadOnlyList<IAvailableRestCalls> result = await ProcessCollectionOptionRequest(request, o => JsonParsers.ValuesToObjects(o, JsonAvailableRestCall.FromToken));
            return result;
        }
    }
}