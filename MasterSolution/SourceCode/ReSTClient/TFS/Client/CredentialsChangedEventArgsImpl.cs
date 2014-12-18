using System.Net;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class CredentialsChangedEventArgsImpl : ICredentialsChangedEventArgs
    {
        ICredentials ICredentialsChangedEventArgs.Credentials { get { throw new ToBeImplementedException(); } }
    }
}