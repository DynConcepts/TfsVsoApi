using System;
using Microsoft.VisualStudio.Services.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ITfsClientCredentialStorage
    /// </summary>
    public interface ITfsClientCredentialStorage
    {
        /// <summary>
        /// Gets the token property.
        /// </summary>
        /// <param name="serverUrls">The server urls.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>String[].</returns>
        String[] GetTokenProperty(Uri[] serverUrls, String propertyName);
        /// <summary>
        /// Gets the token property.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <returns>String.</returns>
        String GetTokenProperty(Uri serverUrl, String propertyName);
        /// <summary>
        /// Removes the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        void RemoveToken(Uri serverUrl);
        /// <summary>
        /// Removes the token value.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="token">The token.</param>
        /// <returns>Boolean.</returns>
        Boolean RemoveTokenValue(Uri serverUrl, IIssuedToken token);
        /// <summary>
        /// Removes the token values by user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        void RemoveTokenValuesByUser(Guid userId);
        /// <summary>
        /// Retrieves the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="credentialType">Type of the credential.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken RetrieveToken(Uri serverUrl, VssCredentialsType credentialType);
        /// <summary>
        /// Stores the token.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="token">The token.</param>
        /// <param name="matchUserInformation">The match user information.</param>
        void StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation);
    }
}