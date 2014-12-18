using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class BatchReadParameterCollectionWrapper : BatchReadParameterCollectionWrapper<IBatchReadParameterCollection, BatchReadParameterCollection>, IBatchReadParameterCollection
    {
        protected BatchReadParameterCollectionWrapper(BatchReadParameterCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IBatchReadParameterCollection, BatchReadParameterCollection>(src => src==null ? null : ((BatchReadParameterCollectionWrapper) src).r_Instance, src => new BatchReadParameterCollectionWrapper(src)); }
    }


    internal class BatchReadParameterCollectionWrapper<TWrapper, TInterface> : VariableSizeListWrapper<TWrapper, TInterface>, IBatchReadParameterCollection where TInterface : class where TWrapper : class
    {

        Int32 IBatchReadParameterCollection.Add(IBatchReadParameter item)
        {
            int nativeCallResult = r_Instance.Add(BatchReadParameterWrapper.GetInstance(item));
            return nativeCallResult;
        }


        Boolean IBatchReadParameterCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }




        Boolean IBatchReadParameterCollection.Contains(IBatchReadParameter item)
        {
            bool nativeCallResult = r_Instance.Contains(BatchReadParameterWrapper.GetInstance(item));
            return nativeCallResult;
        }

        Int32 IBatchReadParameterCollection.IndexOf(IBatchReadParameter item)
        {
            int nativeCallResult = r_Instance.IndexOf(BatchReadParameterWrapper.GetInstance(item));
            return nativeCallResult;
        }



        IBatchReadParameter IBatchReadParameterCollection.this[Int32 index]
        {
            get
            {
                BatchReadParameter nativeCallResult = r_Instance[index];
                IBatchReadParameter wrappedCallResult = BatchReadParameterWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void IBatchReadParameterCollection.Remove(IBatchReadParameter item) { r_Instance.Remove(BatchReadParameterWrapper.GetInstance(item)); }
        protected BatchReadParameterCollectionWrapper(BatchReadParameterCollection instance) : base(instance) { r_Instance = instance; }
        protected new readonly BatchReadParameterCollection r_Instance;
    }
}