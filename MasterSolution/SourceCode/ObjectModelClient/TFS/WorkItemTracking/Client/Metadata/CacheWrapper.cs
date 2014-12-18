using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata;
using Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata
{
    internal class CacheWrapper : CacheWrapper<ICache, Cache>, ICache
    {
        protected CacheWrapper(Cache instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICache, Cache>(src => ((CacheWrapper) src).r_Instance, src => new CacheWrapper(src)); }
    }


    internal class CacheWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICache where TInterface : class where TWrapper : class
    {

        ISnapshot ICache.GetSnapshot()
        {
            Snapshot nativeCallResult = r_Instance.GetSnapshot();
            ISnapshot wrappedCallResult = SnapshotWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        protected CacheWrapper(Cache instance) { r_Instance = instance; }
        protected readonly Cache r_Instance;
    }
}