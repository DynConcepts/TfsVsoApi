using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.Services.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class TfsClientCredentialStorageImpl.
    /// </summary>
    internal class TfsClientCredentialStorageImpl : ITfsClientCredentialStorage
    {
        /// <summary>
        ///     Gets the token property.
        /// </summary>
        /// <param name="serverUrls">The server urls.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>String[].</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String[] ITfsClientCredentialStorage.GetTokenProperty(Uri[] serverUrls, String propertyName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the token property.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ITfsClientCredentialStorage.GetTokenProperty(Uri serverUrl, String propertyName) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITfsClientCredentialStorage.RemoveToken(Uri serverUrl) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the token value.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="token">The token.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean ITfsClientCredentialStorage.RemoveTokenValue(Uri serverUrl, IIssuedToken token) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the token values by user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITfsClientCredentialStorage.RemoveTokenValuesByUser(Guid userId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Retrieves the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="credentialType">Type of the credential.</param>
        /// <returns>IIssuedToken.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIssuedToken ITfsClientCredentialStorage.RetrieveToken(Uri serverUrl, VssCredentialsType credentialType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Stores the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="token">The token.</param>
        /// <param name="matchUserInformation">The match user information.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ITfsClientCredentialStorage.StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation) { throw new ToBeImplementedException(); }
    }
}