using System;
using System.Diagnostics;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    /// <summary>
    /// Interface ITfsRequestSettings
    /// </summary>
    public interface ITfsRequestSettings
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ITfsRequestSettings.</returns>
        ITfsRequestSettings Clone();
        /// <summary>
        /// Gets or sets the agent identifier.
        /// </summary>
        /// <value>The agent identifier.</value>
        String AgentId { get; set; }
        /// <summary>
        /// Gets or sets the bypass proxy on local.
        /// </summary>
        /// <value>The bypass proxy on local.</value>
        Boolean BypassProxyOnLocal { get; set; }
        /// <summary>
        /// Gets or sets the compress request body.
        /// </summary>
        /// <value>The compress request body.</value>
        Boolean CompressRequestBody { get; set; }
        /// <summary>
        /// Gets or sets the compression enabled.
        /// </summary>
        /// <value>The compression enabled.</value>
        Boolean CompressionEnabled { get; set; }
        /// <summary>
        /// Gets the connection limit.
        /// </summary>
        /// <value>The connection limit.</value>
        Int32 ConnectionLimit { get; }
        /// <summary>
        /// Gets or sets the send timeout.
        /// </summary>
        /// <value>The send timeout.</value>
        TimeSpan SendTimeout { get; set; }
        /// <summary>
        /// Gets the SOAP trace enabled.
        /// </summary>
        /// <value>The SOAP trace enabled.</value>
        Boolean SoapTraceEnabled { get; }
        /// <summary>
        /// Gets the tracing.
        /// </summary>
        /// <value>The tracing.</value>
        TraceSwitch Tracing { get; }
        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        String UserAgent { get; }
    }
}