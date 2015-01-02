using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TfsClientCredentialsImpl.
    /// </summary>
    internal class TfsClientCredentialsImpl : ITfsClientCredentials
    {
        /// <summary>
        ///     Gets or sets the allow interactive.
        /// </summary>
        /// <value>The allow interactive.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean ITfsClientCredentials.AllowInteractive { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the federated.
        /// </summary>
        /// <value>The federated.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IFederatedCredential ITfsClientCredentials.Federated { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Signs the out.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="serverDataProvider">The server data provider.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITfsClientCredentials.SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Tries the get token provider.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITfsClientCredentials.TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the windows.
        /// </summary>
        /// <value>The windows.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IWindowsCredential ITfsClientCredentials.Windows { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}