using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TfsTeamProjectCollectionWrapper : TfsTeamProjectCollectionWrapper<ITfsTeamProjectCollection, TfsTeamProjectCollection>, ITfsTeamProjectCollection
    {
        protected TfsTeamProjectCollectionWrapper(TfsTeamProjectCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsTeamProjectCollection, TfsTeamProjectCollection>(src => src == null ? null : ((TfsTeamProjectCollectionWrapper) src).r_Instance, src => new TfsTeamProjectCollectionWrapper(src)); }
    }


    internal class TfsTeamProjectCollectionWrapper<TWrapper, TInterface> : TfsConnectionWrapper<TWrapper, TInterface>, ITfsTeamProjectCollection where TInterface : class where TWrapper : class
    {
        ITfsConfigurationServer ITfsTeamProjectCollection.ConfigurationServer
        {
            get
            {
                TfsConfigurationServer nativeCallResult = r_Instance.ConfigurationServer;
                ITfsConfigurationServer wrappedCallResult = TfsConfigurationServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ITfsTeamProjectCollection.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
        }

        ITeamFoundationServer ITfsTeamProjectCollection.TeamFoundationServer
        {
            get
            {
                TeamFoundationServer nativeCallResult = r_Instance.TeamFoundationServer;
                ITeamFoundationServer wrappedCallResult = TeamFoundationServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected TfsTeamProjectCollectionWrapper(TfsTeamProjectCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly TfsTeamProjectCollection r_Instance;
    }
}