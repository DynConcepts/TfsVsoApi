using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TfsClientCredentialsImpl : ITfsClientCredentials
    {
        Boolean ITfsClientCredentials.AllowInteractive { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IFederatedCredential ITfsClientCredentials.Federated { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITfsClientCredentials.SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean ITfsClientCredentials.TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IWindowsCredential ITfsClientCredentials.Windows { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}