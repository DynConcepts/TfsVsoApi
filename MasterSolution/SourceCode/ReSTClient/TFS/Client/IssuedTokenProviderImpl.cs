using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class IssuedTokenProviderImpl : IIssuedTokenProvider
    {
        IAsyncResult IIssuedTokenProvider.BeginGetToken(TimeSpan timeout, AsyncCallback callback, Object state) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, AsyncCallback callback, Object state) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAsyncResult IIssuedTokenProvider.BeginGetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh, AsyncCallback callback, Object state) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.CurrentToken { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IIssuedToken IIssuedTokenProvider.EndGetToken(IAsyncResult result) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.GetToken(TimeSpan timeout) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIssuedToken IIssuedTokenProvider.GetToken(IIssuedToken failedToken, TimeSpan timeout, Boolean canRefresh) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIssuedTokenProvider.GetTokenIsInteractive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri IIssuedTokenProvider.SignInUrl { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}