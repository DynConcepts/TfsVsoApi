using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemOperationErrorWrapper : WorkItemOperationErrorWrapper<IWorkItemOperationError, WorkItemOperationError>, IWorkItemOperationError
    {
        protected WorkItemOperationErrorWrapper(WorkItemOperationError instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemOperationError, WorkItemOperationError>(src => src==null ? null : ((WorkItemOperationErrorWrapper) src).r_Instance, src => new WorkItemOperationErrorWrapper(src)); }
    }


    internal class WorkItemOperationErrorWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemOperationError where TInterface : class where TWrapper : class
    {
        Exception IWorkItemOperationError.Exception
        {
            get
            {
                Exception nativeCallResult = r_Instance.Exception;
                return nativeCallResult;
            }
        }

        Int32 IWorkItemOperationError.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        protected WorkItemOperationErrorWrapper(WorkItemOperationError instance) { r_Instance = instance; }
        protected readonly WorkItemOperationError r_Instance;
    }
}