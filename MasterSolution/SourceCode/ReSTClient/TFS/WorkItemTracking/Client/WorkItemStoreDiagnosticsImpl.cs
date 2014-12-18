using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemStoreDiagnosticsImpl : IWorkItemStoreDiagnostics
    {
        Int32 IWorkItemStoreDiagnostics.RoundTripCount { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int64 IWorkItemStoreDiagnostics.RoundTripTime { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}