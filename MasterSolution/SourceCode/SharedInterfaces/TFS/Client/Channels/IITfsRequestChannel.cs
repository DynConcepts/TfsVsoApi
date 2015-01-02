using System;
using System.Globalization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    /// <summary>
    /// Interface IITfsRequestChannel
    /// </summary>
    public interface IITfsRequestChannel
    {
        /// <summary>
        /// Aborts this instance.
        /// </summary>
        void Abort();
        /// <summary>
        /// Begins the request.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult BeginRequest(ITfsMessage message, AsyncCallback callback, Object state);
        /// <summary>
        /// Begins the request.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult BeginRequest(ITfsMessage message, TimeSpan timeout, AsyncCallback callback, Object state);
        /// <summary>
        /// Ends the request.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>ITfsMessage.</returns>
        ITfsMessage EndRequest(IAsyncResult result);
        /// <summary>
        /// Requests the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>ITfsMessage.</returns>
        ITfsMessage Request(ITfsMessage message);
        /// <summary>
        /// Requests the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>ITfsMessage.</returns>
        ITfsMessage Request(ITfsMessage message, TimeSpan timeout);
        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ITfsClientCredentials Credentials { get; }
        /// <summary>
        /// Gets the culture.
        /// </summary>
        /// <value>The culture.</value>
        CultureInfo Culture { get; }
        /// <summary>
        /// Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        Guid SessionId { get; }
        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>The settings.</value>
        ITfsRequestSettings Settings { get; }
        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>The state.</value>
        ITfsHttpClientState State { get; }
        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; }
    }
}