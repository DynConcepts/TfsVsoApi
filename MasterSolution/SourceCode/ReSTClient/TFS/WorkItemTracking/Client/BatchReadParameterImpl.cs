using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class BatchReadParameterImpl : IBatchReadParameter
    {
        Int32 IBatchReadParameter.Id { get { throw new ToBeImplementedException(); } }
        Int32 IBatchReadParameter.ProjectHint { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IBatchReadParameter.Revision { get { throw new ToBeImplementedException(); } }
    }
}