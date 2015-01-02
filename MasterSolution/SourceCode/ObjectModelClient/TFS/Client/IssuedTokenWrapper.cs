using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class IssuedTokenWrapper.
    /// </summary>
    internal class IssuedTokenWrapper : IssuedTokenWrapper<IIssuedToken, IssuedToken>, IIssuedToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedTokenWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IssuedTokenWrapper(IssuedToken instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIssuedToken, IssuedToken>(src => src == null ? null : ((IssuedTokenWrapper) src).r_Instance, src => new IssuedTokenWrapper(src)); }
    }


    /// <summary>
    /// Class IssuedTokenWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class IssuedTokenWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIssuedToken where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the is authenticated.
        /// </summary>
        /// <value>The is authenticated.</value>
        Boolean IIssuedToken.IsAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAuthenticated;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedTokenWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IssuedTokenWrapper(IssuedToken instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly IssuedToken r_Instance;
    }
}