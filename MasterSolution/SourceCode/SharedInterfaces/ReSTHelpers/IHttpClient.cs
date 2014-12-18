using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace DynCon.OSI.VSO.SharedInterfaces.ReSTHelpers
{
    /// <summary>
    /// Provide an Interface abstraction of the standard HttpClient class to faciliate unit testing
    /// </summary>
    /// 
    public interface IHttpClient
    {
        /// <summary>
        /// Gets the string asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        Task<string> GetStringAsync(string requestUri);
        /// <summary>
        /// Gets the string asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        Task<string> GetStringAsync(Uri requestUri);
        /// <summary>
        /// Gets the byte array asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.Byte[]&gt;.</returns>
        Task<byte[]> GetByteArrayAsync(string requestUri);
        /// <summary>
        /// Gets the byte array asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.Byte[]&gt;.</returns>
        Task<byte[]> GetByteArrayAsync(Uri requestUri);
        /// <summary>
        /// Gets the stream asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        Task<Stream> GetStreamAsync(string requestUri);
        /// <summary>
        /// Gets the stream asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        Task<Stream> GetStreamAsync(Uri requestUri);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(string requestUri);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(Uri requestUri);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        /// <summary>
        /// Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
        /// <summary>
        /// Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);
        /// <summary>
        /// Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
        /// <summary>
        /// Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        /// <summary>
        /// Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content);
        /// <summary>
        /// Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content);
        /// <summary>
        /// Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
        /// <summary>
        /// Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> DeleteAsync(string requestUri);
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri);
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken);
        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);
        /// <summary>
        /// Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
        /// <summary>
        /// Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        /// <summary>
        /// Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption);
        /// <summary>
        /// Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        /// <summary>
        /// Cancels the pending requests.
        /// </summary>
        void CancelPendingRequests();
        /// <summary>
        /// Gets the default request headers.
        /// </summary>
        /// <value>The default request headers.</value>
        HttpRequestHeaders DefaultRequestHeaders { get; }
        /// <summary>
        /// Gets or sets the base address.
        /// </summary>
        /// <value>The base address.</value>
        Uri BaseAddress { get; set; }
        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        /// <value>The timeout.</value>
        TimeSpan Timeout { get; set; }
        /// <summary>
        /// Gets or sets the maximum size of the response content buffer.
        /// </summary>
        /// <value>The maximum size of the response content buffer.</value>
        long MaxResponseContentBufferSize { get; set; }
        /// <summary>
        /// Disposes this instance.
        /// </summary>
        void Dispose();
    }
}