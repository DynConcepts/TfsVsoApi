using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class QueryHierarchyImpl_UnitTests
    {
        partial void Find_PreCondition(ref IQueryHierarchy instance, ref Guid id) { id = s_MockJsonQueryId; }

        static partial void InstanceFactory(ref QueryHierarchyImpl instance, string callerName)
        {
            var jsonMockQuery = new JObject();
            jsonMockQuery.Add("Id", s_MockJsonQueryId.ToString());
            JsonQueryBase item = JsonQueryBase.FromToken(jsonMockQuery);
            var list = new List<JsonQueryBase>();
            list.Add(item);
            instance = new QueryHierarchyImpl(list);
        }

        private static Guid s_MockJsonQueryId = Guid.NewGuid();
    }
}