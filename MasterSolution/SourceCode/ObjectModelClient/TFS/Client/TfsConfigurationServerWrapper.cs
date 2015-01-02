using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TfsConfigurationServerWrapper.
    /// </summary>
    internal class TfsConfigurationServerWrapper : TfsConfigurationServerWrapper<ITfsConfigurationServer, TfsConfigurationServer>, ITfsConfigurationServer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsConfigurationServerWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsConfigurationServerWrapper(TfsConfigurationServer instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsConfigurationServer, TfsConfigurationServer>(src => src == null ? null : ((TfsConfigurationServerWrapper) src).r_Instance, src => new TfsConfigurationServerWrapper(src)); }
    }


    /// <summary>
    /// Class TfsConfigurationServerWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TfsConfigurationServerWrapper<TWrapper, TInterface> : TfsConnectionWrapper<TWrapper, TInterface>, ITfsConfigurationServer where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the team project collection.
        /// </summary>
        /// <param name="collectionId">The collection identifier.</param>
        /// <returns>ITfsTeamProjectCollection.</returns>
        ITfsTeamProjectCollection ITfsConfigurationServer.GetTeamProjectCollection(Guid collectionId)
        {
            TfsTeamProjectCollection nativeCallResult = r_Instance.GetTeamProjectCollection(collectionId);
            ITfsTeamProjectCollection wrappedCallResult = TfsTeamProjectCollectionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsConfigurationServerWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsConfigurationServerWrapper(TfsConfigurationServer instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly TfsConfigurationServer r_Instance;
    }
}