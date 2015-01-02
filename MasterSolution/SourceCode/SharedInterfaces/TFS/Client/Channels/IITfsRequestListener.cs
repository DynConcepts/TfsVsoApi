using System;
using System.Net;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    /// <summary>
    /// Interface IITfsRequestListener
    /// </summary>
    public interface IITfsRequestListener
    {
        /// <summary>
        /// Afters the receive reply.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="response">The response.</param>
        void AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response);
        /// <summary>
        /// Befores the send request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="request">The request.</param>
        void BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request);
        /// <summary>
        /// Begins the request.
        /// </summary>
        /// <returns>Int64.</returns>
        Int64 BeginRequest();
        /// <summary>
        /// Ends the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="exception">The exception.</param>
        void EndRequest(Int64 requestId, Exception exception);
    }
}