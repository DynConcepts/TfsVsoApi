using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemOperationError
    {
        Exception Exception { get; }
        Int32 Id { get; }
    }
}