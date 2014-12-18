using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class BatchReadParameterImpl : IBatchReadParameter
    {
        Int32 IBatchReadParameter.Id { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IBatchReadParameter.ProjectHint { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IBatchReadParameter.Revision { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}