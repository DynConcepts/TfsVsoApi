using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class ConnectivityFailureStatusChangedEventArgsWrapper : ConnectivityFailureStatusChangedEventArgsWrapper<IConnectivityFailureStatusChangedEventArgs, ConnectivityFailureStatusChangedEventArgs>, IConnectivityFailureStatusChangedEventArgs
    {
        protected ConnectivityFailureStatusChangedEventArgsWrapper(ConnectivityFailureStatusChangedEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IConnectivityFailureStatusChangedEventArgs, ConnectivityFailureStatusChangedEventArgs>(src => ((ConnectivityFailureStatusChangedEventArgsWrapper) src).r_Instance, src => new ConnectivityFailureStatusChangedEventArgsWrapper(src)); }
    }


    internal class ConnectivityFailureStatusChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IConnectivityFailureStatusChangedEventArgs where TInterface : class where TWrapper : class
    {
        Boolean IConnectivityFailureStatusChangedEventArgs.NewConnectivityFailureStatus
        {
            get
            {
                bool nativeCallResult = r_Instance.NewConnectivityFailureStatus;
                return nativeCallResult;
            }
        }

        protected ConnectivityFailureStatusChangedEventArgsWrapper(ConnectivityFailureStatusChangedEventArgs instance) { r_Instance = instance; }
        protected readonly ConnectivityFailureStatusChangedEventArgs r_Instance;
    }
}