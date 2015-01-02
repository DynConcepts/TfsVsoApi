using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class IssuedTokenCredentialWrapper.
    /// </summary>
    internal class IssuedTokenCredentialWrapper : IssuedTokenCredentialWrapper<IIssuedTokenCredential, IssuedTokenCredential>, IIssuedTokenCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedTokenCredentialWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IssuedTokenCredentialWrapper(IssuedTokenCredential instance) : base(instance) { r_Instance = instance; }

        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIssuedTokenCredential, IssuedTokenCredential>(src => src == null ? null : ((IssuedTokenCredentialWrapper)src).IssuedTokenCredentialInstance, src => new IssuedTokenCredentialWrapper(src)); }

        /// <summary>
        /// The r_ instance
        /// </summary>
        private readonly IssuedTokenCredential r_Instance;

        protected override IssuedTokenCredential IssuedTokenCredentialInstance { get { return r_Instance; } }
    }


    /// <summary>
    /// Class IssuedTokenCredentialWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class IssuedTokenCredentialWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIssuedTokenCredential where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the token storage.
        /// </summary>
        /// <value>The token storage.</value>
        ITfsClientCredentialStorage IIssuedTokenCredential.TokenStorage
        {
            get
            {
                TfsClientCredentialStorage nativeCallResult = IssuedTokenCredentialInstance.TokenStorage;
                ITfsClientCredentialStorage wrappedCallResult = TfsClientCredentialStorageWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                TfsClientCredentialStorage nativeValue = TfsClientCredentialStorageWrapper.GetInstance(value);

                IssuedTokenCredentialInstance.TokenStorage = nativeValue;
            }
        }

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected abstract IssuedTokenCredential IssuedTokenCredentialInstance { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedTokenCredentialWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IssuedTokenCredentialWrapper(IssuedTokenCredential instance) { }
     
    }
}