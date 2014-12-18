using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class QueryHierarchyWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.QueryHierarchy);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.QueryHierarchy real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyWrapper>{ GetInstance() }; }

    partial void GetRefreshData_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance);
    partial void GetRefreshData_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetRefreshData_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy) GetInstance();
        },
        (instance) =>
        {
          GetRefreshData_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetRefreshData();
       },
      (instance) =>
      {
              GetRefreshData_PostValidate(instance);
      });
  }
    partial void Find_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance, ref System.Guid id);
    partial void Find_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance, System.Guid id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Find_UnitTest()
  {
    System.Guid id = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Guid); //No Constructor
          Find_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.Find(id);
       },
      (instance) =>
      {
              Find_PostValidate(instance, id);
      });
  }
    partial void Save_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance);
    partial void Save_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Save_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy) GetInstance();
        },
        (instance) =>
        {
          Save_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Save();
       },
      (instance) =>
      {
              Save_PostValidate(instance);
      });
  }
    partial void Reset_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance);
    partial void Reset_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Reset_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy) GetInstance();
        },
        (instance) =>
        {
          Reset_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Reset();
       },
      (instance) =>
      {
              Reset_PostValidate(instance);
      });
  }
   partial void SupportsFolders_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SupportsFolders_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SupportsFolders;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void SupportsPermissions_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy instance, ref System.Boolean setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SupportsPermissions_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchy) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.SupportsPermissions;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
