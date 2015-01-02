using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TfsClientCredentialsWrapper.
    /// </summary>
    internal class TfsClientCredentialsWrapper : TfsClientCredentialsWrapper<ITfsClientCredentials, TfsClientCredentials>, ITfsClientCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsClientCredentialsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsClientCredentialsWrapper(TfsClientCredentials instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsClientCredentials, TfsClientCredentials>(src => src == null ? null : ((TfsClientCredentialsWrapper) src).r_Instance, src => new TfsClientCredentialsWrapper(src)); }
    }


    /// <summary>
    /// Class TfsClientCredentialsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TfsClientCredentialsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsClientCredentials where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the allow interactive.
        /// </summary>
        /// <value>The allow interactive.</value>
        Boolean ITfsClientCredentials.AllowInteractive
        {
            get
            {
                bool nativeCallResult = r_Instance.AllowInteractive;
                return nativeCallResult;
            }
            set { r_Instance.AllowInteractive = value; }
        }

        /// <summary>
        /// Gets or sets the federated.
        /// </summary>
        /// <value>The federated.</value>
        IFederatedCredential ITfsClientCredentials.Federated
        {
            get
            {
                FederatedCredential nativeCallResult = r_Instance.Federated;
                IFederatedCredential wrappedCallResult = FederatedCredentialWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                FederatedCredential nativeValue = FederatedCredentialWrapper.GetInstance(value);

                r_Instance.Federated = nativeValue;
            }
        }

        /// <summary>
        /// Signs the out.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="serverDataProvider">The server data provider.</param>
        void ITfsClientCredentials.SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider) { r_Instance.SignOut(serverUrl, IServerDataProviderWrapper.GetInstance(serverDataProvider)); }

        /// <summary>
        /// Tries the get token provider.
        /// </summary>
        /// <param name="serverUrl">The server URL.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>Boolean.</returns>
        Boolean ITfsClientCredentials.TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider)
        {
            IssuedTokenProvider tmp_provider;
            bool nativeCallResult = r_Instance.TryGetTokenProvider(serverUrl, out tmp_provider);
            provider = IssuedTokenProviderWrapper.GetWrapper(tmp_provider);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets or sets the windows.
        /// </summary>
        /// <value>The windows.</value>
        IWindowsCredential ITfsClientCredentials.Windows
        {
            get
            {
                WindowsCredential nativeCallResult = r_Instance.Windows;
                IWindowsCredential wrappedCallResult = WindowsCredentialWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                WindowsCredential nativeValue = WindowsCredentialWrapper.GetInstance(value);

                r_Instance.Windows = nativeValue;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsClientCredentialsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsClientCredentialsWrapper(TfsClientCredentials instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TfsClientCredentials r_Instance;
    }
}