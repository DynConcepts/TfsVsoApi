using System;
using System.Globalization;
using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Server;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Server;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TeamFoundationServerWrapper : TeamFoundationServerWrapper<ITeamFoundationServer, TeamFoundationServer>, ITeamFoundationServer, IServiceProvider, IDisposable
    {
        protected TeamFoundationServerWrapper(TeamFoundationServer instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITeamFoundationServer, TeamFoundationServer>(src => src == null ? null : ((TeamFoundationServerWrapper) src).r_Instance, src => new TeamFoundationServerWrapper(src)); }
    }


    internal class TeamFoundationServerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITeamFoundationServer where TInterface : class where TWrapper : class
    {
        void ITeamFoundationServer.Authenticate() { r_Instance.Authenticate(); }


        String ITeamFoundationServer.AuthenticatedUserDisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.AuthenticatedUserDisplayName;
                return nativeCallResult;
            }
        }

        IIdentity ITeamFoundationServer.AuthenticatedUserIdentity
        {
            get
            {
                Identity nativeCallResult = r_Instance.AuthenticatedUserIdentity;
                IIdentity wrappedCallResult = IdentityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ITeamFoundationServer.AuthenticatedUserName
        {
            get
            {
                string nativeCallResult = r_Instance.AuthenticatedUserName;
                return nativeCallResult;
            }
        }

        String ITeamFoundationServer.ClientCacheDirectoryForInstance
        {
            get
            {
                string nativeCallResult = r_Instance.ClientCacheDirectoryForInstance;
                return nativeCallResult;
            }
        }

        ICredentials ITeamFoundationServer.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
        }

        CultureInfo ITeamFoundationServer.Culture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.Culture;
                return nativeCallResult;
            }
            set { r_Instance.Culture = value; }
        }

        void IDisposable.Dispose() { r_Instance.Dispose(); }
        void ITeamFoundationServer.EnsureAuthenticated() { r_Instance.EnsureAuthenticated(); }

        T ITeamFoundationServer.GetService<T>()
        {
            var nativeCallResult = r_Instance.GetService<T>();
            return nativeCallResult;
        }


        Object IServiceProvider.GetService(Type serviceType)
        {
            object nativeCallResult = r_Instance.GetService(serviceType);
            return nativeCallResult;
        }

        Boolean ITeamFoundationServer.HasAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.HasAuthenticated;
                return nativeCallResult;
            }
        }

        Guid ITeamFoundationServer.InstanceId
        {
            get
            {
                Guid nativeCallResult = r_Instance.InstanceId;
                return nativeCallResult;
            }
        }

        String ITeamFoundationServer.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        ITFProxyServer ITeamFoundationServer.ProxyServer
        {
            get
            {
                TFProxyServer nativeCallResult = r_Instance.ProxyServer;
                ITFProxyServer wrappedCallResult = TFProxyServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Guid ITeamFoundationServer.SessionId
        {
            get
            {
                Guid nativeCallResult = r_Instance.SessionId;
                return nativeCallResult;
            }
        }

        ITfsTeamProjectCollection ITeamFoundationServer.TfsTeamProjectCollection
        {
            get
            {
                TfsTeamProjectCollection nativeCallResult = r_Instance.TfsTeamProjectCollection;
                ITfsTeamProjectCollection wrappedCallResult = TfsTeamProjectCollectionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        TimeZone ITeamFoundationServer.TimeZone
        {
            get
            {
                TimeZone nativeCallResult = r_Instance.TimeZone;
                return nativeCallResult;
            }
            set { r_Instance.TimeZone = value; }
        }

        Uri ITeamFoundationServer.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        protected TeamFoundationServerWrapper(TeamFoundationServer instance) { r_Instance = instance; }
        protected readonly TeamFoundationServer r_Instance;
    }
}