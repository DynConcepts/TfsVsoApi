using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface ITfsClientCredentials
    {
        void SignOut(Uri serverUrl, IIServerDataProvider serverDataProvider);
        Boolean TryGetTokenProvider(Uri serverUrl, out IIssuedTokenProvider provider);
        Boolean AllowInteractive { get; set; }
        IFederatedCredential Federated { get; set; }
        IWindowsCredential Windows { get; set; }
    }
}