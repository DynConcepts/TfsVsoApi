using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITfsClientCredentials
    /// </summary>
    public interface ITfsClientCredentials
    {
        /// <summary>
        /// Signs the out.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="serverDataProvider">The server data provider.</param>
        void SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider);
        /// <summary>
        /// Tries the get token provider.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>Boolean.</returns>
        Boolean TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider);
        /// <summary>
        /// Gets or sets the allow interactive.
        /// </summary>
        /// <value>The allow interactive.</value>
        Boolean AllowInteractive { get; set; }
        /// <summary>
        /// Gets or sets the federated.
        /// </summary>
        /// <value>The federated.</value>
        IFederatedCredential Federated { get; set; }
        /// <summary>
        /// Gets or sets the windows.
        /// </summary>
        /// <value>The windows.</value>
        IWindowsCredential Windows { get; set; }
    }
}