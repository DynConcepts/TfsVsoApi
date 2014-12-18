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
  public partial class FieldFilterListWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldFilterListWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldFilterListWrapper GetInstance() 
  { 
    var real = new Microsoft.TeamFoundation.WorkItemTracking.Client.FieldFilterList();
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldFilterListWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldFilterListWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.FieldFilterList real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldFilterListWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldFilterListWrapper>{ GetInstance() }; }

    partial void IndexOfFieldId_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList instance, ref System.Int32 id);
    partial void IndexOfFieldId_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList instance, System.Int32 id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IndexOfFieldId_UnitTest()
  {
    System.Int32 id = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          IndexOfFieldId_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.IndexOfFieldId(id);
       },
      (instance) =>
      {
              IndexOfFieldId_PostValidate(instance, id);
      });
  }
    partial void Add_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter filter);
    partial void Add_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter filter);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Add_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter filter = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList) GetInstance();
        },
        (instance) =>
        {
          filter = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.FieldFilterWrapper_UnitTests.GetInstance();
          Add_PreCondition(ref instance, ref filter);
        },
       (instance) =>
       {
             instance.Add(filter);
       },
      (instance) =>
      {
              Add_PostValidate(instance, filter);
      });
  }
    partial void Remove_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter value);
    partial void Remove_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Remove_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter value = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilter);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldFilterList) GetInstance();
        },
        (instance) =>
        {
          value = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.FieldFilterWrapper_UnitTests.GetInstance();
          Remove_PreCondition(ref instance, ref value);
        },
       (instance) =>
       {
             instance.Remove(value);
       },
      (instance) =>
      {
              Remove_PostValidate(instance, value);
      });
  }
  }
}
