using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class IssuedTokenCredentialImpl : IIssuedTokenCredential
    {
        ITfsClientCredentialStorage IIssuedTokenCredential.TokenStorage { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}