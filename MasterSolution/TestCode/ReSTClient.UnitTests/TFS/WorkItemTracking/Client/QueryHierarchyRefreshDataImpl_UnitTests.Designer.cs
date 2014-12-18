using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class QueryHierarchyRefreshDataImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryHierarchyRefreshDataImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryHierarchyRefreshDataImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryHierarchyRefreshDataImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryHierarchyRefreshDataImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.QueryHierarchyRefreshDataImpl>{ GetInstance() }; }

   partial void IsLegacy_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsLegacy_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.IsLegacy;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Hierarchy_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Hierarchy_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Hierarchy;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void QueriesDataSet_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void QueriesDataSet_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.QueriesDataSet;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void LegacyQueries_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData instance, ref System.Collections.ArrayList setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LegacyQueries_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyRefreshData) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.LegacyQueries;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
