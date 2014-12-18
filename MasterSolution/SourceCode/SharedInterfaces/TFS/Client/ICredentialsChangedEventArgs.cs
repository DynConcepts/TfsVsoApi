using System.Net;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface ICredentialsChangedEventArgs
  {
    ICredentials Credentials  { get;   }
  }
}
