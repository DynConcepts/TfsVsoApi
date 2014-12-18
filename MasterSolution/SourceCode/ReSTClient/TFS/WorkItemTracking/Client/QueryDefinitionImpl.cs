using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryDefinitionImpl : QueryItemImpl, IQueryDefinition
    {
        String IQueryDefinition.QueryText { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IQueryType IQueryDefinition.QueryType { get { throw new ToBeImplementedException(); } }
    }
}