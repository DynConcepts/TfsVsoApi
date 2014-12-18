using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TfsConnectionWrapper : TfsConnectionWrapper<ITfsConnection, TfsConnection>, ITfsConnection, IServiceProvider, IDisposable
    {
        protected TfsConnectionWrapper(TfsConnection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsConnection, TfsConnection>(src => ((TfsConnectionWrapper) src).r_Instance, src => new TfsConnectionWrapper(src)); }
    }


    internal abstract class TfsConnectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsConnection where TInterface : class where TWrapper : class
    {

        void ITfsConnection.Authenticate() { r_Instance.Authenticate(); }

        ITeamFoundationIdentity ITfsConnection.AuthorizedIdentity
        {
            get
            {
                TeamFoundationIdentity nativeCallResult = r_Instance.AuthorizedIdentity;
                ITeamFoundationIdentity wrappedCallResult = TeamFoundationIdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Guid ITfsConnection.CachedInstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.CachedInstanceId;
                return nativeCallResult;
            }
        }

        ICatalogNode ITfsConnection.CatalogNode
        {
            get
            {
                CatalogNode nativeCallResult = r_Instance.CatalogNode;
                ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IITfsRequestChannelFactory ITfsConnection.ChannelFactory
        {
            get
            {
                ITfsRequestChannelFactory nativeCallResult = r_Instance.ChannelFactory;
                IITfsRequestChannelFactory wrappedCallResult = ITfsRequestChannelFactoryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ITfsConnection.ClientCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        String ITfsConnection.ClientCacheDirectoryForUser
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForUser;
                return nativeCallResult;
            }
        }

        ITfsClientCredentials ITfsConnection.ClientCredentials
        {
            get
            {
                TfsClientCredentials nativeCallResult = r_Instance.ClientCredentials;
                ITfsClientCredentials wrappedCallResult = TfsClientCredentialsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                TfsClientCredentials nativeValue = TfsClientCredentialsWrapper.GetInstance(value);

                r_Instance.ClientCredentials = nativeValue;
            }
        }

        String ITfsConnection.ClientVolatileCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientVolatileCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }


        void ITfsConnection.Connect(IConnectOptions connectOptions) { r_Instance.Connect(ConnectOptionsWrapper.GetInstance(connectOptions)); }

        Boolean ITfsConnection.ConnectivityFailureOnLastWebServiceCall
        {
            get
            {
                bool nativeCallResult = r_Instance.ConnectivityFailureOnLastWebServiceCall;
                return nativeCallResult;
            }
        }

        ICredentials ITfsConnection.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
            set { r_Instance.Credentials = value; }
        }

        CultureInfo ITfsConnection.Culture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.Culture;
                return nativeCallResult;
            }
            set { r_Instance.Culture = value; }
        }


        void ITfsConnection.Disconnect() { r_Instance.Disconnect(); }
        void IDisposable.Dispose() { r_Instance.Dispose(); }

        Boolean ITfsConnection.Disposed
        {
            get
            {
                bool nativeCallResult = r_Instance.Disposed;
                return nativeCallResult;
            }
        }

        void ITfsConnection.EnsureAuthenticated() { r_Instance.EnsureAuthenticated(); }




        void ITfsConnection.FlushServices() { r_Instance.FlushServices(); }

        void ITfsConnection.GetAuthenticatedIdentity(out ITeamFoundationIdentity identity)
        {
            TeamFoundationIdentity tmp_identity;
            r_Instance.GetAuthenticatedIdentity(out tmp_identity);
            identity = TeamFoundationIdentityWrapper.GetWrapper(tmp_identity);
        }


        T ITfsConnection.GetClient<T>()
        {
            var nativeCallResult = r_Instance.GetClient<T>();
            return nativeCallResult;
        }

        T ITfsConnection.GetService<T>() { return (T) FindService(typeof (T)); }

        private object FindService(Type type)
        {
            Func<TfsConnection, Object> creator;
            if (sr_ServiceMap.TryGetValue(type, out creator))
                return creator(r_Instance);
            return null;
        }

        private static readonly Dictionary<Type, Func<TfsConnection,Object>> sr_ServiceMap = new Dictionary<Type, Func<TfsConnection, object>>()
        {
            {typeof (IWorkItemStore), (tfs) => WorkItemStoreWrapper.GetWrapper(tfs.GetService<WorkItemStore>())}
        };


        Object IServiceProvider.GetService(Type serviceType)
        {
            return FindService(serviceType);
        }

        Boolean ITfsConnection.HasAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAuthenticated;
                return nativeCallResult;
            }
        }

        IIdentityDescriptor ITfsConnection.IdentityToImpersonate
        {
            get
            {
                IdentityDescriptor nativeCallResult = r_Instance.IdentityToImpersonate;
                IIdentityDescriptor wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }



        Guid ITfsConnection.InstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.InstanceId;
                return nativeCallResult;
            }
        }

        Boolean ITfsConnection.IsHostedServer
        {
            get
            {
                bool nativeCallResult = r_Instance.IsHostedServer;
                return nativeCallResult;
            }
        }

        String ITfsConnection.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        ITFProxyServer ITfsConnection.ProxyServer
        {
            get
            {
                TFProxyServer nativeCallResult = r_Instance.ProxyServer;
                ITFProxyServer wrappedCallResult = TFProxyServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IServerCapabilities ITfsConnection.ServerCapabilities
        {
            get
            {
                ServerCapabilities nativeCallResult = r_Instance.ServerCapabilities;
                IServerCapabilities wrappedCallResult = ServerCapabilitiesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IIServerDataProvider ITfsConnection.ServerDataProvider
        {
            get
            {
                IServerDataProvider nativeCallResult = r_Instance.ServerDataProvider;
                IIServerDataProvider wrappedCallResult = IServerDataProviderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Guid ITfsConnection.SessionId
        {
            get
            {
                Guid nativeCallResult = r_Instance.SessionId;
                return nativeCallResult;
            }
        }

        TimeZone ITfsConnection.TimeZone
        {
            get
            {
                TimeZone nativeCallResult = r_Instance.TimeZone;
                return nativeCallResult;
            }
            set { r_Instance.TimeZone = value; }
        }

        CultureInfo ITfsConnection.UICulture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.UICulture;
                return nativeCallResult;
            }
            set { r_Instance.UICulture = value; }
        }

        Uri ITfsConnection.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        protected TfsConnectionWrapper(TfsConnection instance) { r_Instance = instance; }
        protected readonly TfsConnection r_Instance;
    }
}