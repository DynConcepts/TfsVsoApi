using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    ///     Class RestAPIBase.
    /// </summary>
    public class RestAPIBase
    {
        //protected async Task<T> ProcessGetRequest<T>(string query, Func<Stream, T> xform)
        //{
        //    string requestString = MakeCollectionScopeRequestString(query);
        //    HttpRequestMessage request = _requestHelper.CreateGetRequest(requestString);
        //    return await _clientManager.ProcessRequestStream(request, xform);
        //}

        /// <summary>
        ///     Processes the get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestString">The request string.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected async Task<T> ProcessGetRequest<T>(string requestString, Func<JObject, T> xform)
        {
            HttpRequestMessage request = r_RequestHelper.CreateGetRequest(requestString);
            return await r_ClientManager.ProcessRequestJObject(request, xform);
        }

        /// <summary>
        /// Processes the get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri">The URI.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected async Task<T> ProcessGetRequest<T>(Uri uri, Func<JObject, T> xform)
        {
            HttpRequestMessage request = r_RequestHelper.CreateGetRequest(uri);
            return await r_ClientManager.ProcessRequestJObject(request, xform);
        }

        /// <summary>
        ///     Processes the option request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestString">The request string.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected async Task<T> ProcessOptionRequest<T>(string requestString, Func<JObject, T> xform)
        {
            HttpRequestMessage request = r_RequestHelper.CreateOptionRequest(requestString);
            return await r_ClientManager.ProcessRequestJObject(request, xform);
        }


        /// <summary>
        ///     Processes the patch request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestString">The request string.</param>
        /// <param name="content">The content.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected async Task<T> ProcessPatchRequest<T>(string requestString, string content, Func<JObject, T> xform)
        {
            HttpRequestMessage request = r_RequestHelper.CreatePatchRequest(requestString, content);
            return await r_ClientManager.ProcessRequestJObject(request, xform);
        }

        /// <summary>
        ///     Processes the post request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestString">The request string.</param>
        /// <param name="content">The content.</param>
        /// <param name="xform">The xform.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        protected async Task<T> ProcessPostRequest<T>(string requestString, string content, Func<JObject, T> xform)
        {
            HttpRequestMessage request = r_RequestHelper.CreatePostRequest(requestString, content);
            return await r_ClientManager.ProcessRequestJObject(request, xform);
        }


        /// <summary>
        ///     To the comma list.
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>System.String.</returns>
        protected static string ToCommaList(IEnumerable<int> ids)
        {
            string result = String.Empty;
            foreach (int id in ids)
            {
                if (!String.IsNullOrEmpty(result))
                    result += ",";
                result += id;
            }
            return result;
        }

        /// <summary>
        ///     To the json string.
        /// </summary>
        /// <param name="elements">The elements.</param>
        /// <returns>System.String.</returns>
        protected static string ToJsonString(JArray elements)
        {
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            using (JsonWriter jsonWriter = new JsonTextWriter(sw))
            {
                elements.WriteTo(jsonWriter);
            }
            string body = sb.ToString();
            return body;
        }

        /// <summary>
        ///     The _client manager
        /// </summary>
        private readonly RestClientManager r_ClientManager = new RestClientManager();

        /// <summary>
        ///     The _request helper
        /// </summary>
        private readonly RequestHelpers r_RequestHelper = new RequestHelpers();
    }
}