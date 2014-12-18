using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class TfsConfigurationServerWrapper : TfsConfigurationServerWrapper<ITfsConfigurationServer, TfsConfigurationServer>, ITfsConfigurationServer
    {
        protected TfsConfigurationServerWrapper(TfsConfigurationServer instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsConfigurationServer, TfsConfigurationServer>(src => ((TfsConfigurationServerWrapper) src).r_Instance, src => new TfsConfigurationServerWrapper(src)); }
    }


    internal class TfsConfigurationServerWrapper<TWrapper, TInterface> : TfsConnectionWrapper<TWrapper, TInterface>, ITfsConfigurationServer where TInterface : class where TWrapper : class
    {

        ITfsTeamProjectCollection ITfsConfigurationServer.GetTeamProjectCollection(Guid collectionId)
        {
            TfsTeamProjectCollection nativeCallResult = r_Instance.GetTeamProjectCollection(collectionId);
            ITfsTeamProjectCollection wrappedCallResult = TfsTeamProjectCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        protected TfsConfigurationServerWrapper(TfsConfigurationServer instance) : base(instance) { r_Instance = instance; }
        protected new readonly TfsConfigurationServer r_Instance;
    }
}