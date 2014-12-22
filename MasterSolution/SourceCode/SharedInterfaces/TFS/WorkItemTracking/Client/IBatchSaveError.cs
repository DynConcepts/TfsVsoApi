using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IBatchSaveError
    {
        Exception Exception { get; }
        IWorkItem WorkItem { get; }
    }
}