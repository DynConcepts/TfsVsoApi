using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class IResultCollectionWrapper<T> : IResultCollectionWrapper<IIResultCollection<T>, IResultCollection<T>, T>, IIResultCollection<T>, IEnumerable, IDisposable
    {
        public void Add(IArtifactWorkItemIds wrapped) { throw new NotImplementedException(); }
        public IResultCollectionWrapper(IResultCollection<T> instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIResultCollection<T>, IResultCollection<T>>(src => src==null ? null : ((IResultCollectionWrapper<T>) src).r_Instance, src => new IResultCollectionWrapper<T>(src)); }
    }


    internal abstract class IResultCollectionWrapper<TWrapper, TInterface, T> : MappedObjectBase<TWrapper, TInterface>, IIResultCollection<T> where TInterface : class where TWrapper : class
    {

        void IDisposable.Dispose() { r_Instance.Dispose(); }

        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator<T> nativeCallResult = r_Instance.GetEnumerator();
            return nativeCallResult;
        }

        protected IResultCollectionWrapper(IResultCollection<T> instance) { r_Instance = instance; }
        protected readonly IResultCollection<T> r_Instance;
    }
}