using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class WindowsCredentialImpl : IssuedTokenCredentialImpl, IWindowsCredential
    {
        ICredentials IWindowsCredential.Credentials { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}