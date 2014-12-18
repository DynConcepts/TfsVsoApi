using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.Objects;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    internal class VsoRestAPIBase : RestAPIBase
    {
        /// <summary>
        /// Appends the target API version.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>System.String.</returns>
        private static string AppendTargetAPIVersion(string request)
        {
            if (request.Contains("?"))
                request += "&api-version=1.0";
            else
                request += "?api-version=1.0";
            return request;
        }


        /// <summary>
        /// Makes the collection scope request string.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>System.String.</returns>
        private static string MakeCollectionScopeRequestString(string query)
        {

            string request = !query.StartsWith("/") ? query : VSOClientManager.VsoCollection + "/_apis" + query;
            request = AppendTargetAPIVersion(request);
            return request;
        }

        /// <summary>
        /// Makes the project scope request string.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="query">The query.</param>
        /// <returns>System.String.</returns>
        private static string MakeProjectScopeRequestString(string project, string query)
        {
            string request = VSOClientManager.VsoCollection + "/" + project + "/_apis" + query;
            request = AppendTargetAPIVersion(request);
            return request;
        }

        protected Task<IReadOnlyList<JsonWorkItem>> ProcessCollectionGetRequest(string query, Func<JObject, IReadOnlyList<JsonWorkItem>> func)
        {
            return ProcessGetRequest(MakeCollectionScopeRequestString(query), func);
        }
    }
}