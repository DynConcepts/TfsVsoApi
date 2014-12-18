using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class IssuedTokenCredentialImpl : IIssuedTokenCredential
    {
        ITfsClientCredentialStorage IIssuedTokenCredential.TokenStorage { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}