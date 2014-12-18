using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class BatchReadParameterWrapper : BatchReadParameterWrapper<IBatchReadParameter, BatchReadParameter>, IBatchReadParameter
    {
        protected BatchReadParameterWrapper(BatchReadParameter instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IBatchReadParameter, BatchReadParameter>(src => src==null ? null : ((BatchReadParameterWrapper) src).r_Instance, src => new BatchReadParameterWrapper(src)); }
    }


    internal class BatchReadParameterWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IBatchReadParameter where TInterface : class where TWrapper : class
    {
        Int32 IBatchReadParameter.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
        }

        Int32 IBatchReadParameter.ProjectHint
        {
            get
            {
                int nativeCallResult = r_Instance.ProjectHint;
                return nativeCallResult;
            }
            set { r_Instance.ProjectHint = value; }
        }

        Int32 IBatchReadParameter.Revision
        {
            get
            {
                int nativeCallResult = r_Instance.Revision;
                return nativeCallResult;
            }
        }

        protected BatchReadParameterWrapper(BatchReadParameter instance) { r_Instance = instance; }
        protected readonly BatchReadParameter r_Instance;
    }
}