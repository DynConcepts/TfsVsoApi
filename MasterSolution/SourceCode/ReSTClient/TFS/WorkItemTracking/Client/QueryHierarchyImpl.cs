using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class QueryHierarchyImpl : QueryFolderImpl, IQueryHierarchy
    {
        public QueryHierarchyImpl(IEnumerable<JsonQueryBase> queryTree)
        {
            Process(queryTree);
        }

        private void Process(IEnumerable<JsonQueryBase> queryTree)
        {
            foreach (var query in queryTree)
            {
                if (query is JsonQueryFolder)
                    Process(query as JsonQueryFolder);
                else
                {
                    Process(query as JsonQueryDefinition);
                }
            }
        }

        private void Process(JsonQueryFolder query)
        {
            r_Queries.Add(query.Id, new QueryFolderImpl());
            Process(query.Children);
        }

        private void Process(JsonQueryDefinition query) { r_Queries.Add(query.Id, new QueryDefinitionImpl()); }
        private readonly Dictionary<Guid, IQueryItem> r_Queries = new Dictionary<Guid, IQueryItem>();

        IQueryItem IQueryHierarchy.Find(Guid id) { return r_Queries[id]; }
        IQueryHierarchyRefreshData IQueryHierarchy.GetRefreshData() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IQueryHierarchy.Refresh(IQueryHierarchyRefreshData refreshData) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IQueryHierarchy.Refresh() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IQueryHierarchy.Reset() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IQueryHierarchy.Save() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IQueryHierarchy.SupportsFolders { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean IQueryHierarchy.SupportsPermissions { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}