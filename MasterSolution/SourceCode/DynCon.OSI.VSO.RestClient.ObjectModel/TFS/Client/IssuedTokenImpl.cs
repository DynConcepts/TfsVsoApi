using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class IssuedTokenImpl.
    /// </summary>
    internal class IssuedTokenImpl : IIssuedToken
    {
        /// <summary>
        ///     Gets the is authenticated.
        /// </summary>
        /// <value>The is authenticated.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIssuedToken.IsAuthenticated { get { throw new ToBeImplementedException(); } }
    }
}