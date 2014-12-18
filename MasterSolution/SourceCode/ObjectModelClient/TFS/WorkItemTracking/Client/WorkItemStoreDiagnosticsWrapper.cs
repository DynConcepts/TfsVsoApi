using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemStoreDiagnosticsWrapper : WorkItemStoreDiagnosticsWrapper<IWorkItemStoreDiagnostics, WorkItemStoreDiagnostics>, IWorkItemStoreDiagnostics
    {
        protected WorkItemStoreDiagnosticsWrapper(WorkItemStoreDiagnostics instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemStoreDiagnostics, WorkItemStoreDiagnostics>(src => ((WorkItemStoreDiagnosticsWrapper) src).r_Instance, src => new WorkItemStoreDiagnosticsWrapper(src)); }
    }


    internal class WorkItemStoreDiagnosticsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemStoreDiagnostics where TInterface : class where TWrapper : class
    {
        Int32 IWorkItemStoreDiagnostics.RoundTripCount
        {
            get
            {
                int nativeCallResult = r_Instance.RoundTripCount;
                return nativeCallResult;
            }
        }

        Int64 IWorkItemStoreDiagnostics.RoundTripTime
        {
            get
            {
                long nativeCallResult = r_Instance.RoundTripTime;
                return nativeCallResult;
            }
        }

        protected WorkItemStoreDiagnosticsWrapper(WorkItemStoreDiagnostics instance) { r_Instance = instance; }
        protected readonly WorkItemStoreDiagnostics r_Instance;
    }
}