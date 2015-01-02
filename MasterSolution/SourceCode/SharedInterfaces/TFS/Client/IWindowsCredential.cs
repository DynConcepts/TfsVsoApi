using System.Net;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IWindowsCredential
    /// </summary>
    public interface IWindowsCredential : IIssuedTokenCredential
    {
        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ICredentials Credentials { get; set; }
    }
}