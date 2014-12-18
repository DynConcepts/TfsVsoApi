using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemStoreDiagnosticsImpl : IWorkItemStoreDiagnostics
    {
        Int32 IWorkItemStoreDiagnostics.RoundTripCount { get { throw new ToBeImplementedException(); } }
        Int64 IWorkItemStoreDiagnostics.RoundTripTime { get { throw new ToBeImplementedException(); } }
    }
}