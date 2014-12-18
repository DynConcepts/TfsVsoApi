using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.Services.Common;
using IssuedToken = Microsoft.TeamFoundation.Client.IssuedToken;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TfsClientCredentialStorageWrapper : TfsClientCredentialStorageWrapper<ITfsClientCredentialStorage, TfsClientCredentialStorage>, ITfsClientCredentialStorage
    {
        protected TfsClientCredentialStorageWrapper(TfsClientCredentialStorage instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsClientCredentialStorage, TfsClientCredentialStorage>(src => src==null ? null : ((TfsClientCredentialStorageWrapper) src).r_Instance, src => new TfsClientCredentialStorageWrapper(src)); }
    }


    internal class TfsClientCredentialStorageWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsClientCredentialStorage where TInterface : class where TWrapper : class
    {

        String[] ITfsClientCredentialStorage.GetTokenProperty(Uri[] serverUrls, String propertyName)
        {
            string[] nativeCallResult = r_Instance.GetTokenProperty(serverUrls, propertyName);
            return nativeCallResult;
        }

        String ITfsClientCredentialStorage.GetTokenProperty(Uri serverUrl, String propertyName)
        {
            string nativeCallResult = r_Instance.GetTokenProperty(serverUrl, propertyName);
            return nativeCallResult;
        }



        void ITfsClientCredentialStorage.RemoveToken(Uri serverUrl) { r_Instance.RemoveToken(serverUrl); }

        Boolean ITfsClientCredentialStorage.RemoveTokenValue(Uri serverUrl, IIssuedToken token)
        {
            bool nativeCallResult = r_Instance.RemoveTokenValue(serverUrl, IssuedTokenWrapper.GetInstance(token));
            return nativeCallResult;
        }


        void ITfsClientCredentialStorage.RemoveTokenValuesByUser(Guid userId) { r_Instance.RemoveTokenValuesByUser(userId); }

        IIssuedToken ITfsClientCredentialStorage.RetrieveToken(Uri serverUrl, VssCredentialsType credentialType)
        {
            IssuedToken nativeCallResult = r_Instance.RetrieveToken(serverUrl, credentialType);
            IIssuedToken wrappedCallResult = IssuedTokenWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        void ITfsClientCredentialStorage.StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation) { r_Instance.StoreToken(serverUrl, IssuedTokenWrapper.GetInstance(token), matchUserInformation); }
        protected TfsClientCredentialStorageWrapper(TfsClientCredentialStorage instance) { r_Instance = instance; }
        protected readonly TfsClientCredentialStorage r_Instance;


    }
}