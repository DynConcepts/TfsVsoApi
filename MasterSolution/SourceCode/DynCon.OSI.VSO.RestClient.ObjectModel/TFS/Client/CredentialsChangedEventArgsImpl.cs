using System.Net;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class CredentialsChangedEventArgsImpl.
    /// </summary>
    internal class CredentialsChangedEventArgsImpl : ICredentialsChangedEventArgs
    {
        /// <summary>
        ///     Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ICredentials ICredentialsChangedEventArgs.Credentials { get { throw new ToBeImplementedException(); } }
    }
}