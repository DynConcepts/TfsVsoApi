using System;
using System.Collections;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class IResultCollectionWrapper.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class IResultCollectionWrapper<T> : IResultCollectionWrapper<IIResultCollection<T>, IResultCollection<T>, T>, IIResultCollection<T>, IEnumerable, IDisposable
    {
        /// <summary>
        /// Adds the specified wrapped.
        /// </summary>
        /// <param name="wrapped">The wrapped.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Add(IArtifactWorkItemIds wrapped) { throw new NotImplementedException(); }
        /// <summary>
        /// Initializes a new instance of the <see cref="IResultCollectionWrapper{T}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public IResultCollectionWrapper(IResultCollection<T> instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIResultCollection<T>, IResultCollection<T>>(src => src == null ? null : ((IResultCollectionWrapper<T>) src).r_Instance, src => new IResultCollectionWrapper<T>(src)); }
    }


    /// <summary>
    /// Class IResultCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    /// <typeparam name="T"></typeparam>
    internal abstract class IResultCollectionWrapper<TWrapper, TInterface, T> : MappedObjectBase<TWrapper, TInterface>, IIResultCollection<T> where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        void IDisposable.Dispose() { r_Instance.Dispose(); }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator<T> nativeCallResult = r_Instance.GetEnumerator();
            return nativeCallResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IResultCollectionWrapper{TWrapper, TInterface, T}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IResultCollectionWrapper(IResultCollection<T> instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly IResultCollection<T> r_Instance;
    }
}