using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.Services.Common;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TfsClientCredentialStorageImpl : ITfsClientCredentialStorage
    {
        String[] ITfsClientCredentialStorage.GetTokenProperty(Uri[] serverUrls, String propertyName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String ITfsClientCredentialStorage.GetTokenProperty(Uri serverUrl, String propertyName) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITfsClientCredentialStorage.RemoveToken(Uri serverUrl) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITfsClientCredentialStorage.RemoveTokenValue(Uri serverUrl, IIssuedToken token) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITfsClientCredentialStorage.RemoveTokenValuesByUser(Guid userId) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIssuedToken ITfsClientCredentialStorage.RetrieveToken(Uri serverUrl, VssCredentialsType credentialType) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ITfsClientCredentialStorage.StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}