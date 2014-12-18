using System.Net.Http;
using System.Net.Http.Headers;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    /// Class RequestHelpers.
    /// </summary>
    class RequestHelpers
    {

        /// <summary>
        /// Creates the patch request.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="jsonContent">Content of the json.</param>
        /// <returns>HttpRequestMessage.</returns>
        public HttpRequestMessage CreatePatchRequest(string requestUri, string jsonContent)
        {
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json-patch+json");
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content };
            return request;
        }

        /// <summary>
        /// Creates the post request.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="jsonContent">Content of the json.</param>
        /// <returns>HttpRequestMessage.</returns>
        public HttpRequestMessage CreatePostRequest(string requestUri, string jsonContent)
        {
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var request = new HttpRequestMessage(new HttpMethod("POST"), requestUri) { Content = content };
            return request;
        }

        /// <summary>
        /// Creates the get request.
        /// </summary>
        /// <param name="requestString">The request string.</param>
        /// <returns>HttpRequestMessage.</returns>
        public HttpRequestMessage CreateGetRequest(string requestString)
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), requestString);
            return request;
        }
    }
}
