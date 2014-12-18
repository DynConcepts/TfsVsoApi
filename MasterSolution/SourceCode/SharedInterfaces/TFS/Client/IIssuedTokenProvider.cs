namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IIssuedTokenProvider
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken GetToken( System.TimeSpan timeout);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken GetToken( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken failedToken, System.TimeSpan timeout);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken GetToken( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken failedToken, System.TimeSpan timeout, System.Boolean canRefresh);
    System.IAsyncResult BeginGetToken( System.TimeSpan timeout, System.AsyncCallback callback, System.Object state);
    System.IAsyncResult BeginGetToken( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken failedToken, System.TimeSpan timeout, System.AsyncCallback callback, System.Object state);
    System.IAsyncResult BeginGetToken( DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken failedToken, System.TimeSpan timeout, System.Boolean canRefresh, System.AsyncCallback callback, System.Object state);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken EndGetToken( System.IAsyncResult result);
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IIssuedToken CurrentToken  { get;   }
    System.Boolean GetTokenIsInteractive  { get;   }
    System.Uri SignInUrl  { get;   }
  }
}
