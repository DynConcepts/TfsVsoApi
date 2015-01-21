using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    public class ProjectsAPI : VsoRestAPIBase
    {
        public async Task<IReadOnlyList<JsonProject>> GetProjects() { return await GetProjects(JsonProject.FromToken); }


        public async Task<IReadOnlyList<TProject>> GetProjects<TProject>(Func<JToken, TProject> fromToken)  where TProject : JsonProject
        {
            var exchange = StructuredHttpExchange.Get("/projects/");
            IReadOnlyList<TProject> result = await ProcessCollectionRequest(exchange, o => JsonParsers.ValuesToObjects(o, fromToken));
            return result;
        }
    }
}
