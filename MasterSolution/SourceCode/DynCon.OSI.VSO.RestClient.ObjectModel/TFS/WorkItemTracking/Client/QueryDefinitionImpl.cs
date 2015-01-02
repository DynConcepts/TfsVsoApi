using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class QueryDefinitionImpl.
    /// </summary>
    internal class QueryDefinitionImpl : QueryItemImpl, IQueryDefinition
    {
        /// <summary>
        ///     Gets or sets the query text.
        /// </summary>
        /// <value>The query text.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IQueryDefinition.QueryText { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type of the query.
        /// </summary>
        /// <value>The type of the query.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IQueryType IQueryDefinition.QueryType { get { throw new ToBeImplementedException(); } }
    }
}