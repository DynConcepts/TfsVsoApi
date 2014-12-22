using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IWorkItemStoreDiagnostics
    {
        Int32 RoundTripCount { get; }
        Int64 RoundTripTime { get; }
    }
}