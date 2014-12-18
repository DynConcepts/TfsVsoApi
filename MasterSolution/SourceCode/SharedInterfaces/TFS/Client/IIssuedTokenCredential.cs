namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IIssuedTokenCredential
  {
    ITfsClientCredentialStorage TokenStorage  { get; set;   }
  }
}
