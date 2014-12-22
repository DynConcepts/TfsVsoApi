using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemEventArgsWrapper : WorkItemEventArgsWrapper<IWorkItemEventArgs, WorkItemEventArgs>, IWorkItemEventArgs
    {
        protected WorkItemEventArgsWrapper(WorkItemEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemEventArgs, WorkItemEventArgs>(src => src == null ? null : ((WorkItemEventArgsWrapper) src).r_Instance, src => new WorkItemEventArgsWrapper(src)); }
    }


    internal class WorkItemEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemEventArgs where TInterface : class where TWrapper : class
    {
        IField IWorkItemEventArgs.Field
        {
            get
            {
                Field nativeCallResult = r_Instance.Field;
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Object IWorkItemEventArgs.Object
        {
            get
            {
                object nativeCallResult = r_Instance.Object;
                return nativeCallResult;
            }
        }

        protected WorkItemEventArgsWrapper(WorkItemEventArgs instance) { r_Instance = instance; }
        protected readonly WorkItemEventArgs r_Instance;
    }
}