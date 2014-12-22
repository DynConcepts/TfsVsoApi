using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class IssuedTokenProviderWrapper : IssuedTokenProviderWrapper<IIssuedTokenProvider, IssuedTokenProvider>, IIssuedTokenProvider
    {
        protected IssuedTokenProviderWrapper(IssuedTokenProvider instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIssuedTokenProvider, IssuedTokenProvider>(src => src == null ? null : ((IssuedTokenProviderWrapper) src).r_Instance, src => new IssuedTokenProviderWrapper(src)); }
    }


    internal abstract class IssuedTokenProviderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIssuedTokenProvider where TInterface : class where TWrapper : class
    {
        IAsyncResult IIssuedTokenProvider.BeginGetToken(TimeSpan timeout, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginGetToken(timeout, callback, state);
            return nativeCallResult;
        }


        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginGetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout, callback, state);
            return nativeCallResult;
        }


        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginGetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout, canRefresh, callback, state);
            return nativeCallResult;
        }


        IIssuedToken IIssuedTokenProvider.CurrentToken
        {
            get
            {
                IssuedToken nativeCallResult = r_Instance.CurrentToken;
                IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IIssuedToken IIssuedTokenProvider.EndGetToken(IAsyncResult result)
        {
            IssuedToken nativeCallResult = r_Instance.EndGetToken(result);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IIssuedToken IIssuedTokenProvider.GetToken(TimeSpan timeout)
        {
            IssuedToken nativeCallResult = r_Instance.GetToken(timeout);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout)
        {
            IssuedToken nativeCallResult = r_Instance.GetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh)
        {
            IssuedToken nativeCallResult = r_Instance.GetToken(IssuedTokenWrapper.GetInstance(failedToken), timeout, canRefresh);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Boolean IIssuedTokenProvider.GetTokenIsInteractive
        {
            get
            {
                bool nativeCallResult = r_Instance.GetTokenIsInteractive;
                return nativeCallResult;
            }
        }

        Uri IIssuedTokenProvider.SignInUrl
        {
            get
            {
                Uri nativeCallResult = r_Instance.SignInUrl;
                return nativeCallResult;
            }
        }

        protected IssuedTokenProviderWrapper(IssuedTokenProvider instance) { r_Instance = instance; }
        protected readonly IssuedTokenProvider r_Instance;
    }
}