using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class AllowedValuesCollectionWrapper.
    /// </summary>
    internal class AllowedValuesCollectionWrapper : AllowedValuesCollectionWrapper<IAllowedValuesCollection, AllowedValuesCollection>, IAllowedValuesCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedValuesCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AllowedValuesCollectionWrapper(AllowedValuesCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAllowedValuesCollection, AllowedValuesCollection>(src => src == null ? null : ((AllowedValuesCollectionWrapper) src).r_Instance, src => new AllowedValuesCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class AllowedValuesCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AllowedValuesCollectionWrapper<TWrapper, TInterface> : ValuesCollectionWrapper<TWrapper, TInterface>, IAllowedValuesCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedValuesCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AllowedValuesCollectionWrapper(AllowedValuesCollection instance) : base(instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly AllowedValuesCollection r_Instance;
    }
}