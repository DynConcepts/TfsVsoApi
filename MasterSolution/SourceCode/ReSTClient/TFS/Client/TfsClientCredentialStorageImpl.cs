using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.Services.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TfsClientCredentialStorageImpl : ITfsClientCredentialStorage
    {
        String[] ITfsClientCredentialStorage.GetTokenProperty(Uri[] serverUrls, String propertyName) { throw new ToBeImplementedException(); }
        String ITfsClientCredentialStorage.GetTokenProperty(Uri serverUrl, String propertyName) { throw new ToBeImplementedException(); }
        void ITfsClientCredentialStorage.RemoveToken(Uri serverUrl) { throw new ToBeImplementedException(); }
        Boolean ITfsClientCredentialStorage.RemoveTokenValue(Uri serverUrl, IIssuedToken token) { throw new ToBeImplementedException(); }
        void ITfsClientCredentialStorage.RemoveTokenValuesByUser(Guid userId) { throw new ToBeImplementedException(); }
        IIssuedToken ITfsClientCredentialStorage.RetrieveToken(Uri serverUrl, VssCredentialsType credentialType) { throw new ToBeImplementedException(); }
        void ITfsClientCredentialStorage.StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation) { throw new ToBeImplementedException(); }
    }
}