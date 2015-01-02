using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class IssuedTokenCredentialImpl.
    /// </summary>
    internal class IssuedTokenCredentialImpl : IIssuedTokenCredential
    {
        /// <summary>
        ///     Gets or sets the token storage.
        /// </summary>
        /// <value>The token storage.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        ITfsClientCredentialStorage IIssuedTokenCredential.TokenStorage { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}