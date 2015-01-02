using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class IssuedTokenProviderWrapper.
    /// </summary>
    internal class IssuedTokenProviderWrapper : IssuedTokenProviderWrapper<IIssuedTokenProvider, IssuedTokenProvider>, IIssuedTokenProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedTokenProviderWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IssuedTokenProviderWrapper(IssuedTokenProvider instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIssuedTokenProvider, IssuedTokenProvider>(src => src == null ? null : ((IssuedTokenProviderWrapper) src).r_Instance, src => new IssuedTokenProviderWrapper(src)); }
    }


    /// <summary>
    /// Class IssuedTokenProviderWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class IssuedTokenProviderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIssuedTokenProvider where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Begins the get token.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult IIssuedTokenProvider.BeginGetToken(TimeSpan timeout, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginGetToken(timeout, callback, state);
            return nativeCallResult;
        }


        /// <summary>
        /// Begins the get token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginGetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout, callback, state);
            return nativeCallResult;
        }


        /// <summary>
        /// Begins the get token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="canRefresh">The can refresh.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginGetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout, canRefresh, callback, state);
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the current token.
        /// </summary>
        /// <value>The current token.</value>
        IIssuedToken IIssuedTokenProvider.CurrentToken
        {
            get
            {
                IssuedToken nativeCallResult = r_Instance.CurrentToken;
                IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Ends the get token.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken IIssuedTokenProvider.EndGetToken(IAsyncResult result)
        {
            IssuedToken nativeCallResult = r_Instance.EndGetToken(result);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="timeout">The timeout.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken IIssuedTokenProvider.GetToken(TimeSpan timeout)
        {
            IssuedToken nativeCallResult = r_Instance.GetToken(timeout);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout)
        {
            IssuedToken nativeCallResult = r_Instance.GetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="failedToken">The failed token.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="canRefresh">The can refresh.</param>
        /// <returns>IIssuedToken.</returns>
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh)
        {
            IssuedToken nativeCallResult = r_Instance.GetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout, canRefresh);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the get token is interactive.
        /// </summary>
        /// <value>The get token is interactive.</value>
        Boolean IIssuedTokenProvider.GetTokenIsInteractive
        {
            get
            {
                bool nativeCallResult = r_Instance.GetTokenIsInteractive;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the sign in URL.
        /// </summary>
        /// <value>The sign in URL.</value>
        Uri IIssuedTokenProvider.SignInUrl
        {
            get
            {
                Uri nativeCallResult = r_Instance.SignInUrl;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedTokenProviderWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IssuedTokenProviderWrapper(IssuedTokenProvider instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly IssuedTokenProvider r_Instance;
    }
}