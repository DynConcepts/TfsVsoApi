using System;
using Microsoft.VisualStudio.Services.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface ITfsClientCredentialStorage
    {
        String[] GetTokenProperty(Uri[] serverUrls, String propertyName);
        String GetTokenProperty(Uri serverUrl, String propertyName);
        void RemoveToken(Uri serverUrl);
        Boolean RemoveTokenValue(Uri serverUrl, IIssuedToken token);
        void RemoveTokenValuesByUser(Guid userId);
        IIssuedToken RetrieveToken(Uri serverUrl, VssCredentialsType credentialType);
        void StoreToken(Uri serverUrl, IIssuedToken token, Boolean matchUserInformation);
    }
}