using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using IRowSet = Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class IMetadataRowSetsWrapper : IMetadataRowSetsWrapper<IIMetadataRowSets, IMetadataRowSets>, IIMetadataRowSets
    {
        protected IMetadataRowSetsWrapper(IMetadataRowSets instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIMetadataRowSets, IMetadataRowSets>(src => src==null ? null : ((IMetadataRowSetsWrapper) src).r_Instance, src => new IMetadataRowSetsWrapper(src)); }
    }


    internal abstract class IMetadataRowSetsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIMetadataRowSets where TInterface : class where TWrapper : class
    {
        Int32 IIMetadataRowSets.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        IIRowSet IIMetadataRowSets.this[IMetadataRowSetNames name]
        {
            get
            {
                IRowSet nativeCallResult = r_Instance[MetadataRowSetNamesWrapper.GetInstance(name)];
                IIRowSet wrappedCallResult = IRowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IIRowSet IIMetadataRowSets.this[Int32 index]
        {
            get
            {
                IRowSet nativeCallResult = r_Instance[index];
                IIRowSet wrappedCallResult = IRowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected IMetadataRowSetsWrapper(IMetadataRowSets instance) { r_Instance = instance; }
        protected readonly IMetadataRowSets r_Instance;
    }
}