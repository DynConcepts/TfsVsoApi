using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class ConnectivityFailureStatusChangedEventArgsWrapper.
    /// </summary>
    internal class ConnectivityFailureStatusChangedEventArgsWrapper : ConnectivityFailureStatusChangedEventArgsWrapper<IConnectivityFailureStatusChangedEventArgs, ConnectivityFailureStatusChangedEventArgs>, IConnectivityFailureStatusChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityFailureStatusChangedEventArgsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="ConnectivityFailureStatusChangedEventArgs"/> instance containing the event data.</param>
        protected ConnectivityFailureStatusChangedEventArgsWrapper(ConnectivityFailureStatusChangedEventArgs instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IConnectivityFailureStatusChangedEventArgs, ConnectivityFailureStatusChangedEventArgs>(src => src == null ? null : ((ConnectivityFailureStatusChangedEventArgsWrapper) src).r_Instance, src => new ConnectivityFailureStatusChangedEventArgsWrapper(src)); }
    }


    /// <summary>
    /// Class ConnectivityFailureStatusChangedEventArgsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class ConnectivityFailureStatusChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IConnectivityFailureStatusChangedEventArgs where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the new connectivity failure status.
        /// </summary>
        /// <value>The new connectivity failure status.</value>
        Boolean IConnectivityFailureStatusChangedEventArgs.NewConnectivityFailureStatus
        {
            get
            {
                bool nativeCallResult = r_Instance.NewConnectivityFailureStatus;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityFailureStatusChangedEventArgsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="ConnectivityFailureStatusChangedEventArgs"/> instance containing the event data.</param>
        protected ConnectivityFailureStatusChangedEventArgsWrapper(ConnectivityFailureStatusChangedEventArgs instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ConnectivityFailureStatusChangedEventArgs r_Instance;
    }
}