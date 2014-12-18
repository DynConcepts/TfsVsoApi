using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class QueryHierarchyImpl_UnitTests
  {
      static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryHierarchyImpl instance, string callerName)
    {
        var jsonMockQuery = new JObject();
        jsonMockQuery.Add("Id", s_MockJsonQueryId.ToString());
        var item = JsonQueryBase.FromToken(jsonMockQuery);
        var list = new List<JsonQueryBase>();
        list.Add(item);
        instance = new QueryHierarchyImpl(list);
    }

    private static Guid s_MockJsonQueryId = Guid.NewGuid();

    partial void Find_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance, ref System.Guid id) { id = s_MockJsonQueryId; }

  }
}
