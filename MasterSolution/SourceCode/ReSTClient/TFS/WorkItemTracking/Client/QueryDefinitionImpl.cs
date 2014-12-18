using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryDefinitionImpl : QueryItemImpl, IQueryDefinition
    {
        String IQueryDefinition.QueryText { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IQueryType IQueryDefinition.QueryType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}