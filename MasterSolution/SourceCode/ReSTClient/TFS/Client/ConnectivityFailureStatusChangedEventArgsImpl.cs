using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client
{
    internal class ConnectivityFailureStatusChangedEventArgsImpl : IConnectivityFailureStatusChangedEventArgs
    {
        Boolean IConnectivityFailureStatusChangedEventArgs.NewConnectivityFailureStatus { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}