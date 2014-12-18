using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynCon.OSI.JasonBackedObjects.Communications;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.APIs
{
    internal class VsoRestAPIBase : RestAPIBase
    {
        /// <summary>
        ///     Appends the target API version.
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
        ///     Makes the collection scope request string.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>System.String.</returns>
        private static string MakeCollectionScopeRequestString(string query)
        {
            string request = query.StartsWith("http") ? query : VSOClientManager.VsoCollection + "/_apis" + query;
            request = AppendTargetAPIVersion(request);
            return request;
        }

        /// <summary>
        ///     Makes the project scope request string.
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

        /// <summary>
        ///     Processes the collection get request.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessCollectionGetRequest<T>(string query, Func<JObject, IReadOnlyList<T>> func) { return ProcessGetRequest(MakeCollectionScopeRequestString(query), func); }

        /// <summary>
        /// Processes the collection get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> ProcessCollectionGetRequest<T>(string query, Func<JObject, T> xform) { return ProcessGetRequest(MakeCollectionScopeRequestString(query), xform); }

        /// <summary>
        /// Processes the collection option request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessCollectionOptionRequest<T>(string query, Func<JObject, IReadOnlyList<T>> func) { return ProcessOptionRequest(MakeCollectionScopeRequestString(query), func); }

        /// <summary>
        ///     Processes the collection post request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <param name="body">The body.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessCollectionPostRequest<T>(string query, string body, Func<JObject, IReadOnlyList<T>> func) { return ProcessPostRequest(MakeCollectionScopeRequestString(query), body, func); }

        /// <summary>
        ///     Processes the collection post request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query">The query.</param>
        /// <param name="body">The body.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> ProcessCollectionPostRequest<T>(string query, string body, Func<JObject, T> func) { return ProcessPostRequest(MakeCollectionScopeRequestString(query), body, func); }

        /// <summary>
        ///     Processes the project get request.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="query">The query.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessProjectGetRequest<T>(string project, string query, Func<JObject, IReadOnlyList<T>> func) { return ProcessGetRequest(MakeProjectScopeRequestString(project, query), func); }

        /// <summary>
        ///     Processes the get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project">The project.</param>
        /// <param name="query">The query.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> ProcessProjectGetRequest<T>(string project, string query, Func<JObject, T> xform) { return ProcessGetRequest(MakeProjectScopeRequestString(project, query), xform); }

        /// <summary>
        ///     Processes the project patch request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="project">The project.</param>
        /// <param name="query">The query.</param>
        /// <param name="body"></param>
        /// <param name="func"></param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected Task<T> ProcessProjectPatchRequest<T>(string project, string query, string body, Func<JObject, T> func) { return ProcessPatchRequest(MakeProjectScopeRequestString(project, query), body, func); }

        /// <summary>
        ///     Processes the project post request.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="query">The query.</param>
        /// <param name="body">The body.</param>
        /// <param name="func">The function.</param>
        /// <returns>Task&lt;IReadOnlyList&lt;T&gt;&gt;.</returns>
        protected Task<IReadOnlyList<T>> ProcessProjectPostRequest<T>(string project, string query, string body, Func<JObject, IReadOnlyList<T>> func) { return ProcessPostRequest(MakeProjectScopeRequestString(project, query), body, func); }
    }
}