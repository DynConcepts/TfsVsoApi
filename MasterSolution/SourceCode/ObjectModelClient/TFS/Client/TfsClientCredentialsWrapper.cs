using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TfsClientCredentialsWrapper : TfsClientCredentialsWrapper<ITfsClientCredentials, TfsClientCredentials>, ITfsClientCredentials
    {
        protected TfsClientCredentialsWrapper(TfsClientCredentials instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsClientCredentials, TfsClientCredentials>(src => src == null ? null : ((TfsClientCredentialsWrapper) src).r_Instance, src => new TfsClientCredentialsWrapper(src)); }
    }


    internal class TfsClientCredentialsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsClientCredentials where TInterface : class where TWrapper : class
    {
        Boolean ITfsClientCredentials.AllowInteractive
        {
            get
            {
                bool nativeCallResult = r_Instance.AllowInteractive;
                return nativeCallResult;
            }
            set { r_Instance.AllowInteractive = value; }
        }

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

        void ITfsClientCredentials.SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider) { r_Instance.SignOut(serverUrl, IServerDataProviderWrapper.GetInstance(serverDataProvider)); }

        Boolean ITfsClientCredentials.TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider)
        {
            IssuedTokenProvider tmp_provider;
            bool nativeCallResult = r_Instance.TryGetTokenProvider(serverUrl, out tmp_provider);
            provider = IssuedTokenProviderWrapper.GetWrapper(tmp_provider);
            return nativeCallResult;
        }

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

        protected TfsClientCredentialsWrapper(TfsClientCredentials instance) { r_Instance = instance; }
        protected readonly TfsClientCredentials r_Instance;
    }
}