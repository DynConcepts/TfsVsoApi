using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IIssuedTokenProvider
    /// </summary>
    public interface IIssuedTokenProvider
    {
        /// <summary>
        /// Begins the get token.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult BeginGetToken(TimeSpan timeout, AsyncCallback callback, Object state);
        /// <summary>
        /// Begins the get token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state);
        /// <summary>
        /// Begins the get token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="canRefresh">The can refresh.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state);
        /// <summary>
        /// Ends the get token.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken EndGetToken(IAsyncResult result);
        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken GetToken(TimeSpan timeout);
        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken GetToken(IIssuedToken failedToken, TimeSpan timeout);
        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="canRefresh">The can refresh.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken GetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh);
        /// <summary>
        /// Gets the current token.
        /// </summary>
        /// <value>The current token.</value>
        IIssuedToken CurrentToken { get; }
        /// <summary>
        /// Gets the get token is interactive.
        /// </summary>
        /// <value>The get token is interactive.</value>
        Boolean GetTokenIsInteractive { get; }
        /// <summary>
        /// Gets the sign in URL.
        /// </summary>
        /// <value>The sign in URL.</value>
        Uri SignInUrl { get; }
    }
}