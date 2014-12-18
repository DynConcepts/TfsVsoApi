using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class TfsClientCredentialsImpl : ITfsClientCredentials
    {
        Boolean ITfsClientCredentials.AllowInteractive { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IFederatedCredential ITfsClientCredentials.Federated { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void ITfsClientCredentials.SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider) { throw new ToBeImplementedException(); }
        Boolean ITfsClientCredentials.TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider) { throw new ToBeImplementedException(); }
        IWindowsCredential ITfsClientCredentials.Windows { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}