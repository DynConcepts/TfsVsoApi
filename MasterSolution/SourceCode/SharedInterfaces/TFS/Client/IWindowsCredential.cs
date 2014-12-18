namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IWindowsCredential : DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenCredential
  {
    System.Net.ICredentials Credentials  { get; set;   }
  }
}
