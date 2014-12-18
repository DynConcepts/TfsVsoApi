using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using DynCon.OSI.VSO.SharedInterfaces.ReSTHelpers;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    ///     Class HttpClientMock.
    /// </summary>
    internal class HttpClientMock : IHttpClient
    {
        /// <summary>
        ///     Cancels the pending requests.
        /// </summary>
        /// <exception cref="System.NotSupportedException"></exception>
        public void CancelPendingRequests() { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> DeleteAsync(string requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Deletes the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Disposes this instance.
        /// </summary>
        /// <exception cref="System.NotSupportedException"></exception>
        public void Dispose() { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(string requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(Uri requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the byte array asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.Byte[]&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<byte[]> GetByteArrayAsync(string requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the byte array asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.Byte[]&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<byte[]> GetByteArrayAsync(Uri requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the stream asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<Stream> GetStreamAsync(string requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the stream asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;Stream&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<Stream> GetStreamAsync(Uri requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the string asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<string> GetStringAsync(string requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets the string asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<string> GetStringAsync(Uri requestUri) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Posts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Puts the asynchronous.
        /// </summary>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="content">The content.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Sends the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="completionOption">The completion option.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;HttpResponseMessage&gt;.</returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) { throw new NotSupportedException("This functionallity will be implemented when there is a concrete requirement"); }

        /// <summary>
        ///     Gets or sets the base address.
        /// </summary>
        /// <value>The base address.</value>
        public Uri BaseAddress { get; set; }

        /// <summary>
        ///     Gets the default request headers.
        /// </summary>
        /// <value>The default request headers.</value>
        public HttpRequestHeaders DefaultRequestHeaders { get { throw new NotImplementedException(); } }

        /// <summary>
        ///     Gets or sets the maximum size of the response content buffer.
        /// </summary>
        /// <value>The maximum size of the response content buffer.</value>
        public long MaxResponseContentBufferSize { get; set; }

        /// <summary>
        ///     Gets or sets the timeout.
        /// </summary>
        /// <value>The timeout.</value>
        public TimeSpan Timeout { get; set; }
    }
}