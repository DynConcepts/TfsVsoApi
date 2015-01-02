using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class TfsTeamProjectCollectionWrapper.
    /// </summary>
    internal class TfsTeamProjectCollectionWrapper : TfsTeamProjectCollectionWrapper<ITfsTeamProjectCollection, TfsTeamProjectCollection>, ITfsTeamProjectCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsTeamProjectCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsTeamProjectCollectionWrapper(TfsTeamProjectCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsTeamProjectCollection, TfsTeamProjectCollection>(src => src == null ? null : ((TfsTeamProjectCollectionWrapper) src).r_Instance, src => new TfsTeamProjectCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class TfsTeamProjectCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TfsTeamProjectCollectionWrapper<TWrapper, TInterface> : TfsConnectionWrapper<TWrapper, TInterface>, ITfsTeamProjectCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the configuration server.
        /// </summary>
        /// <value>The configuration server.</value>
        ITfsConfigurationServer ITfsTeamProjectCollection.ConfigurationServer
        {
            get
            {
                TfsConfigurationServer nativeCallResult = r_Instance.ConfigurationServer;
                ITfsConfigurationServer wrappedCallResult = TfsConfigurationServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String ITfsTeamProjectCollection.DisplayName
        {
            get
            {
                string nativeCallResult = r_Instance.DisplayName;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the team foundation server.
        /// </summary>
        /// <value>The team foundation server.</value>
        ITeamFoundationServer ITfsTeamProjectCollection.TeamFoundationServer
        {
            get
            {
                TeamFoundationServer nativeCallResult = r_Instance.TeamFoundationServer;
                ITeamFoundationServer wrappedCallResult = TeamFoundationServerWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfsTeamProjectCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsTeamProjectCollectionWrapper(TfsTeamProjectCollection instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly TfsTeamProjectCollection r_Instance;
    }
}