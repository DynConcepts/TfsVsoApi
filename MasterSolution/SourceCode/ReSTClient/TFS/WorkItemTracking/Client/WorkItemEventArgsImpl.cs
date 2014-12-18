using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemEventArgsImpl : IWorkItemEventArgs
    {
        IField IWorkItemEventArgs.Field { get { throw new ToBeImplementedException(); } }
        Object IWorkItemEventArgs.Object { get { throw new ToBeImplementedException(); } }
    }
}