using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class BatchSaveErrorImpl : IBatchSaveError
    {
        private readonly Exception r_Exception;
        private readonly IWorkItem r_Workitem;

        internal BatchSaveErrorImpl(Exception exception, IWorkItem workitem)
        {
            r_Exception = exception;
            r_Workitem = workitem;
        }

        Exception IBatchSaveError.Exception { get { return r_Exception; } }
        IWorkItem IBatchSaveError.WorkItem { get { return r_Workitem; } }
    }
}