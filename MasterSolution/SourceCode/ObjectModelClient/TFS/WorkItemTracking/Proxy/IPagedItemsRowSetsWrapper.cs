using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using IRowSet = Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class IPagedItemsRowSetsWrapper : IPagedItemsRowSetsWrapper<IIPagedItemsRowSets, IPagedItemsRowSets>, IIPagedItemsRowSets
    {
        protected IPagedItemsRowSetsWrapper(IPagedItemsRowSets instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIPagedItemsRowSets, IPagedItemsRowSets>(src => src==null ? null : ((IPagedItemsRowSetsWrapper) src).r_Instance, src => new IPagedItemsRowSetsWrapper(src)); }
    }


    internal abstract class IPagedItemsRowSetsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIPagedItemsRowSets where TInterface : class where TWrapper : class
    {
        IIRowSet IIPagedItemsRowSets.this[IPagedItemsRowSetNames name]
        {
            get
            {
                IRowSet nativeCallResult = r_Instance[PagedItemsRowSetNamesWrapper.GetInstance(name)];
                IIRowSet wrappedCallResult = IRowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected IPagedItemsRowSetsWrapper(IPagedItemsRowSets instance) { r_Instance = instance; }
        protected readonly IPagedItemsRowSets r_Instance;
    }
}