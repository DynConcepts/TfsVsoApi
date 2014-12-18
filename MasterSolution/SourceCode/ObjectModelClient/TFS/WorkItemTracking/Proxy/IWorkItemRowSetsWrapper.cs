using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using IRowSet = Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class IWorkItemRowSetsWrapper : IWorkItemRowSetsWrapper<IIWorkItemRowSets, IWorkItemRowSets>, IIWorkItemRowSets
    {
        protected IWorkItemRowSetsWrapper(IWorkItemRowSets instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIWorkItemRowSets, IWorkItemRowSets>(src => ((IWorkItemRowSetsWrapper) src).r_Instance, src => new IWorkItemRowSetsWrapper(src)); }
    }


    internal abstract class IWorkItemRowSetsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIWorkItemRowSets where TInterface : class where TWrapper : class
    {
        IIRowSet IIWorkItemRowSets.this[IWorkItemRowSetNames name]
        {
            get
            {
                IRowSet nativeCallResult = r_Instance[WorkItemRowSetNamesWrapper.GetInstance(name)];
                IIRowSet wrappedCallResult = IRowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IIRowSet IIWorkItemRowSets.this[String name]
        {
            get
            {
                IRowSet nativeCallResult = r_Instance[name];
                IIRowSet wrappedCallResult = IRowSetWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IIWorkItemRowSets.TryGetRowSet(String name, out IIRowSet rowset)
        {
            IRowSet tmp_rowset;
            bool nativeCallResult = r_Instance.TryGetRowSet(name, out tmp_rowset);
            rowset = IRowSetWrapper.GetWrapper(tmp_rowset);
            return nativeCallResult;
        }

        protected IWorkItemRowSetsWrapper(IWorkItemRowSets instance) { r_Instance = instance; }
        protected readonly IWorkItemRowSets r_Instance;
    }
}