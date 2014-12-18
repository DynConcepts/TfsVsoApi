using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class IssuedTokenProviderImpl : IIssuedTokenProvider
    {
        IAsyncResult IIssuedTokenProvider.BeginGetToken(TimeSpan timeout, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.CurrentToken { get { throw new ToBeImplementedException(); } }
        IIssuedToken IIssuedTokenProvider.EndGetToken(IAsyncResult result) { throw new ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.GetToken(TimeSpan timeout) { throw new ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout) { throw new ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh) { throw new ToBeImplementedException(); }
        Boolean IIssuedTokenProvider.GetTokenIsInteractive { get { throw new ToBeImplementedException(); } }
        Uri IIssuedTokenProvider.SignInUrl { get { throw new ToBeImplementedException(); } }
    }
}