using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class FederatedCredentialWrapper.
    /// </summary>
    internal class FederatedCredentialWrapper : FederatedCredentialWrapper<IFederatedCredential, FederatedCredential>, IFederatedCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FederatedCredentialWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FederatedCredentialWrapper(FederatedCredential instance) : base(instance) {}

        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IFederatedCredential, FederatedCredential>(src => src == null ? null : ((FederatedCredentialWrapper)src).FederatedCredentiaInstance, src => new FederatedCredentialWrapper(src)); }

    }


    /// <summary>
    /// 
    /// Class FederatedCredentialWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class FederatedCredentialWrapper<TWrapper, TInterface> : IssuedTokenCredentialWrapper<TWrapper, TInterface>, IFederatedCredential where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FederatedCredentialWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected FederatedCredentialWrapper(FederatedCredential instance) : base(instance) { r_Instance = instance; }

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly FederatedCredential r_Instance;


        /// <summary>
        /// Gets the federated credentia instance.
        /// </summary>
        /// <value>The federated credentia instance.</value>
        protected FederatedCredential FederatedCredentiaInstance { get { return r_Instance; } }

        /// <summary>
        /// Gets the issued token credential instance.
        /// </summary>
        /// <value>The issued token credential instance.</value>
        protected override IssuedTokenCredential IssuedTokenCredentialInstance { get { return r_Instance; } }

    }
}