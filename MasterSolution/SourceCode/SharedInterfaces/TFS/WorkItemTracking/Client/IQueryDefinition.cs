using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IQueryDefinition
    /// </summary>
    public interface IQueryDefinition : IQueryItem
    {
        /// <summary>
        /// Gets or sets the query text.
        /// </summary>
        /// <value>The query text.</value>
        String QueryText { get; set; }
        /// <summary>
        /// Gets the type of the query.
        /// </summary>
        /// <value>The type of the query.</value>
        IQueryType QueryType { get; }
    }
}