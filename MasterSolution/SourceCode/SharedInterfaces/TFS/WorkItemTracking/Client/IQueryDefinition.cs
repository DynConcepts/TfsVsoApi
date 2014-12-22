using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IQueryDefinition : IQueryItem
    {
        String QueryText { get; set; }
        IQueryType QueryType { get; }
    }
}