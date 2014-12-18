using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class BatchSaveErrorWrapper : BatchSaveErrorWrapper<IBatchSaveError, BatchSaveError>, IBatchSaveError
    {
        protected BatchSaveErrorWrapper(BatchSaveError instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IBatchSaveError, BatchSaveError>(src => ((BatchSaveErrorWrapper) src).r_Instance, src => new BatchSaveErrorWrapper(src)); }
    }


    internal class BatchSaveErrorWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IBatchSaveError where TInterface : class where TWrapper : class
    {
        Exception IBatchSaveError.Exception
        {
            get
            {
                Exception nativeCallResult = r_Instance.Exception;
                return nativeCallResult;
            }
        }

        IWorkItem IBatchSaveError.WorkItem
        {
            get
            {
                WorkItem nativeCallResult = r_Instance.WorkItem;
                IWorkItem wrappedCallResult = WorkItemWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected BatchSaveErrorWrapper(BatchSaveError instance) { r_Instance = instance; }
        protected readonly BatchSaveError r_Instance;
    }
}