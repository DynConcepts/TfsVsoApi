using System.Net;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    public interface IWindowsCredential : IIssuedTokenCredential
    {
        ICredentials Credentials { get; set; }
    }
}