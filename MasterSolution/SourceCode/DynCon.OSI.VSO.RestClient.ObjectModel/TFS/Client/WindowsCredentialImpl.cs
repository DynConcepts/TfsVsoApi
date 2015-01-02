using System.Net;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class WindowsCredentialImpl.
    /// </summary>
    internal class WindowsCredentialImpl : IssuedTokenCredentialImpl, IWindowsCredential
    {
        /// <summary>
        ///     Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        ICredentials IWindowsCredential.Credentials { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}