using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IIssuedTokenProvider
  {
    IIssuedToken GetToken( TimeSpan timeout);
    IIssuedToken GetToken( IIssuedToken failedToken, TimeSpan timeout);
    IIssuedToken GetToken( IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh);
    IAsyncResult BeginGetToken( TimeSpan timeout, AsyncCallback callback, Object state);
    IAsyncResult BeginGetToken( IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state);
    IAsyncResult BeginGetToken( IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state);
    IIssuedToken EndGetToken( IAsyncResult result);
    IIssuedToken CurrentToken  { get;   }
    Boolean GetTokenIsInteractive  { get;   }
    Uri SignInUrl  { get;   }
  }
}
