using System.Net;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface ICredentialsChangedEventArgs
    /// </summary>
    public interface ICredentialsChangedEventArgs
    {
        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials Credentials { get; }
    }
}