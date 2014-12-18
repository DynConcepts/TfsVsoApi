using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ReSTClient.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    class ProjectsAPI : VsoRestAPIBase
    {
        public async Task<IReadOnlyList<JsonProject>> GetProjects() { return await GetProjects(JsonProject.FromToken); }


        public async Task<IReadOnlyList<TProject>> GetProjects<TProject>(Func<JToken, TProject> fromToken)  where TProject : JsonProject
        {
            string request = "/projects/";
            IReadOnlyList<TProject> result = await ProcessCollectionGetRequest(request, o => JsonParsers.ValuesToObjects(o, fromToken));
            return result;
        }
    }
}
