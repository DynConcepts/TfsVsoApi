using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IIssuedToken
    /// </summary>
    public interface IIssuedToken
    {
        /// <summary>
        /// Gets the is authenticated.
        /// </summary>
        /// <value>The is authenticated.</value>
        Boolean IsAuthenticated { get; }
    }
}