using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata
{
    /// <summary>
    /// Class CacheWrapper.
    /// </summary>
    internal class CacheWrapper : CacheWrapper<ICache, Cache>, ICache
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CacheWrapper(Cache instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICache, Cache>(src => src == null ? null : ((CacheWrapper) src).r_Instance, src => new CacheWrapper(src)); }
    }


    /// <summary>
    /// Class CacheWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CacheWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICache where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the snapshot.
        /// </summary>
        /// <returns>ISnapshot.</returns>
        ISnapshot ICache.GetSnapshot()
        {
            Snapshot nativeCallResult = r_Instance.GetSnapshot();
            ISnapshot wrappedCallResult = SnapshotWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CacheWrapper(Cache instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly Cache r_Instance;
    }
}