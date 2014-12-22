using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemAsyncEventArgsWrapper : WorkItemAsyncEventArgsWrapper<IWorkItemAsyncEventArgs, WorkItemAsyncEventArgs>, IWorkItemAsyncEventArgs
    {
        protected WorkItemAsyncEventArgsWrapper(WorkItemAsyncEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWorkItemAsyncEventArgs, WorkItemAsyncEventArgs>(src => src == null ? null : ((WorkItemAsyncEventArgsWrapper) src).r_Instance, src => new WorkItemAsyncEventArgsWrapper(src)); }
    }


    internal class WorkItemAsyncEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IWorkItemAsyncEventArgs where TInterface : class where TWrapper : class
    {
        ICancelableAsyncResult IWorkItemAsyncEventArgs.CancelableAsyncResult
        {
            get
            {
                CancelableAsyncResult nativeCallResult = r_Instance.CancelableAsyncResult;
                ICancelableAsyncResult wrappedCallResult = CancelableAsyncResultWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ICancelableActionState IWorkItemAsyncEventArgs.NewState
        {
            get
            {
                CancelableActionState nativeCallResult = r_Instance.NewState;
                ICancelableActionState wrappedCallResult = CancelableActionStateWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ICancelableActionState IWorkItemAsyncEventArgs.OldState
        {
            get
            {
                CancelableActionState nativeCallResult = r_Instance.OldState;
                ICancelableActionState wrappedCallResult = CancelableActionStateWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected WorkItemAsyncEventArgsWrapper(WorkItemAsyncEventArgs instance) { r_Instance = instance; }
        protected readonly WorkItemAsyncEventArgs r_Instance;
    }
}