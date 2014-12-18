namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IIssuedTokenCredential
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsClientCredentialStorage TokenStorage  { get; set;   }
  }
}
