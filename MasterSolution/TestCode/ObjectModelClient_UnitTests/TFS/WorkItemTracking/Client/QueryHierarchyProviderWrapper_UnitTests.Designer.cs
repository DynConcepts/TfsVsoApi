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
  public partial class QueryHierarchyProviderWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyProviderWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyProviderWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.QueryHierarchyProvider);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyProviderWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyProviderWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.QueryHierarchyProvider real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyProviderWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.QueryHierarchyProviderWrapper>{ GetInstance() }; }

    partial void GetQueryHierarchy_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
    partial void GetQueryHierarchy_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetQueryHierarchy_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider) GetInstance();
        },
        (instance) =>
        {
          project = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.ProjectWrapper_UnitTests.GetInstance();
          GetQueryHierarchy_PreCondition(ref instance, ref project);
        },
       (instance) =>
       {
             instance.GetQueryHierarchy(project);
       },
      (instance) =>
      {
              GetQueryHierarchy_PostValidate(instance, project);
      });
  }
    partial void IsQueryHierarchyReady_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
    partial void IsQueryHierarchyReady_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsQueryHierarchyReady_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject project = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider) GetInstance();
        },
        (instance) =>
        {
          project = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.ProjectWrapper_UnitTests.GetInstance();
          IsQueryHierarchyReady_PreCondition(ref instance, ref project);
        },
       (instance) =>
       {
             instance.IsQueryHierarchyReady(project);
       },
      (instance) =>
      {
              IsQueryHierarchyReady_PostValidate(instance, project);
      });
  }
    partial void GetQueryDefinition_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, ref System.Guid id);
    partial void GetQueryDefinition_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, System.Guid id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetQueryDefinition_UnitTest()
  {
    System.Guid id = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Guid); //No Constructor
          GetQueryDefinition_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.GetQueryDefinition(id);
       },
      (instance) =>
      {
              GetQueryDefinition_PostValidate(instance, id);
      });
  }
    partial void GetAccessControlListMetadata_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, ref System.String objectClassId);
    partial void GetAccessControlListMetadata_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance, System.String objectClassId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetAccessControlListMetadata_UnitTest()
  {
    System.String objectClassId = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider) GetInstance();
        },
        (instance) =>
        {
          objectClassId = default(System.String); //No Constructor
          GetAccessControlListMetadata_PreCondition(ref instance, ref objectClassId);
        },
       (instance) =>
       {
             instance.GetAccessControlListMetadata(objectClassId);
       },
      (instance) =>
      {
              GetAccessControlListMetadata_PostValidate(instance, objectClassId);
      });
  }
    partial void InvalidateAllHierarchies_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance);
    partial void InvalidateAllHierarchies_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void InvalidateAllHierarchies_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IQueryHierarchyProvider) GetInstance();
        },
        (instance) =>
        {
          InvalidateAllHierarchies_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.InvalidateAllHierarchies();
       },
      (instance) =>
      {
              InvalidateAllHierarchies_PostValidate(instance);
      });
  }
  }
}
