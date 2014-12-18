using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
  public interface IConnectivityFailureStatusChangedEventArgs
  {
    Boolean NewConnectivityFailureStatus  { get;   }
  }
}
