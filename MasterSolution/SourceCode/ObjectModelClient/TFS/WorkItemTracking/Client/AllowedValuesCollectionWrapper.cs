using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class AllowedValuesCollectionWrapper : AllowedValuesCollectionWrapper<IAllowedValuesCollection, AllowedValuesCollection>, IAllowedValuesCollection
    {
        protected AllowedValuesCollectionWrapper(AllowedValuesCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAllowedValuesCollection, AllowedValuesCollection>(src => src == null ? null : ((AllowedValuesCollectionWrapper) src).r_Instance, src => new AllowedValuesCollectionWrapper(src)); }
    }


    internal class AllowedValuesCollectionWrapper<TWrapper, TInterface> : ValuesCollectionWrapper<TWrapper, TInterface>, IAllowedValuesCollection where TInterface : class where TWrapper : class
    {
        protected AllowedValuesCollectionWrapper(AllowedValuesCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly AllowedValuesCollection r_Instance;
    }
}