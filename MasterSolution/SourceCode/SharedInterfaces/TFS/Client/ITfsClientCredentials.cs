namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ITfsClientCredentials
  {
    System.Boolean TryGetTokenProvider( System.Uri serverUrl,out DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedTokenProvider provider);
    void SignOut( System.Uri serverUrl, DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client.IIServerDataProvider serverDataProvider);
    System.Boolean AllowInteractive  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IFederatedCredential Federated  { get; set;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IWindowsCredential Windows  { get; set;   }
  }
}
