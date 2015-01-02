using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client
{
    /// <summary>
    ///     Class IssuedTokenProviderImpl.
    /// </summary>
    internal class IssuedTokenProviderImpl : IIssuedTokenProvider
    {
        /// <summary>
        ///     Begins the get token.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAsyncResult IIssuedTokenProvider.BeginGetToken(TimeSpan timeout, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the get token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Begins the get token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="canRefresh">The can refresh.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the current token.
        /// </summary>
        /// <value>The current token.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIssuedToken IIssuedTokenProvider.CurrentToken { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Ends the get token.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>IIssuedToken.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIssuedToken IIssuedTokenProvider.EndGetToken(IAsyncResult result) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the token.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <returns>IIssuedToken.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIssuedToken IIssuedTokenProvider.GetToken(TimeSpan timeout) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>IIssuedToken.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="canRefresh">The can refresh.</param>
        /// <returns>IIssuedToken.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the get token is interactive.
        /// </summary>
        /// <value>The get token is interactive.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IIssuedTokenProvider.GetTokenIsInteractive { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the sign in URL.
        /// </summary>
        /// <value>The sign in URL.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Uri IIssuedTokenProvider.SignInUrl { get { throw new ToBeImplementedException(); } }
    }
}