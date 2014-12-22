using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class WorkItemOperationErrorImpl : IWorkItemOperationError
    {
        Exception IWorkItemOperationError.Exception { get { throw new ToBeImplementedException(); } }
        Int32 IWorkItemOperationError.Id { get { throw new ToBeImplementedException(); } }
    }
}