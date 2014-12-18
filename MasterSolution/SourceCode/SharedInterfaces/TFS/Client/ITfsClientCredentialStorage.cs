namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsClientCredentialStorage
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken RetrieveToken( System.Uri serverUrl, Microsoft.VisualStudio.Services.Common.VssCredentialsType credentialType);
    System.String[] GetTokenProperty( System.Uri[] serverUrls, System.String propertyName);
    void StoreToken( System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token, System.Boolean matchUserInformation);
    void RemoveToken( System.Uri serverUrl);
    System.Boolean RemoveTokenValue( System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken token);
    void RemoveTokenValuesByUser( System.Guid userId);
    System.String GetTokenProperty( System.Uri serverUrl, System.String propertyName);
  }
}
