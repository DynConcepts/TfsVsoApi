using System;
using Microsoft.VisualStudio.Services.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsClientCredentialStorage
  {
    IIssuedToken RetrieveToken( Uri serverUrl, VssCredentialsType credentialType);
    String[] GetTokenProperty( Uri[] serverUrls, String propertyName);
    void StoreToken( Uri serverUrl, IIssuedToken token, Boolean matchUserInformation);
    void RemoveToken( Uri serverUrl);
    Boolean RemoveTokenValue( Uri serverUrl, IIssuedToken token);
    void RemoveTokenValuesByUser( Guid userId);
    String GetTokenProperty( Uri serverUrl, String propertyName);
  }
}
