using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class StoredQueryCollectionWrapper : StoredQueryCollectionWrapper<IStoredQueryCollection, StoredQueryCollection>, IStoredQueryCollection
    {
        protected StoredQueryCollectionWrapper(StoredQueryCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IStoredQueryCollection, StoredQueryCollection>(src => src==null ? null : ((StoredQueryCollectionWrapper) src).r_Instance, src => new StoredQueryCollectionWrapper(src)); }
    }


    internal class StoredQueryCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IStoredQueryCollection where TInterface : class where TWrapper : class
    {

        Int32 IStoredQueryCollection.Add(IStoredQuery storedQuery)
        {
            int nativeCallResult = r_Instance.Add(StoredQueryWrapper.GetInstance(storedQuery));
            return nativeCallResult;
        }


        Int32 IStoredQueryCollection.IndexOf(IStoredQuery storedQuery)
        {
            int nativeCallResult = r_Instance.IndexOf(StoredQueryWrapper.GetInstance(storedQuery));
            return nativeCallResult;
        }



        IStoredQuery IStoredQueryCollection.this[Guid guid]
        {
            get
            {
                StoredQuery nativeCallResult = r_Instance[guid];
                IStoredQuery wrappedCallResult = StoredQueryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IStoredQuery IStoredQueryCollection.this[Int32 index]
        {
            get
            {
                StoredQuery nativeCallResult = r_Instance[index];
                IStoredQuery wrappedCallResult = StoredQueryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IStoredQueryCollection.Refresh() { r_Instance.Refresh(); }
        void IStoredQueryCollection.Remove(IStoredQuery storedQuery) { r_Instance.Remove(StoredQueryWrapper.GetInstance(storedQuery)); }
        protected StoredQueryCollectionWrapper(StoredQueryCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly StoredQueryCollection r_Instance;
    }
}