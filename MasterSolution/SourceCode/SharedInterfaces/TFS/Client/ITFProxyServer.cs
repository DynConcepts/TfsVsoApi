using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITFProxyServer
    /// </summary>
    public interface ITFProxyServer
    {
        /// <summary>
        /// Notifies the unavailable.
        /// </summary>
        void NotifyUnavailable();
        /// <summary>
        /// Gets the is available.
        /// </summary>
        /// <value>The is available.</value>
        Boolean IsAvailable { get; }
        /// <summary>
        /// Gets or sets the is enabled.
        /// </summary>
        /// <value>The is enabled.</value>
        Boolean IsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the last configure time.
        /// </summary>
        /// <value>The last configure time.</value>
        DateTime LastConfigureTime { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        String Url { get; set; }
        /// <summary>
        /// Gets or sets the was automatic configured.
        /// </summary>
        /// <value>The was automatic configured.</value>
        Boolean WasAutoConfigured { get; set; }
    }
}