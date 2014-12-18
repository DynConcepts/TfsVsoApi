using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IWorkItemOpenFieldDataHelperImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemOpenFieldDataHelperImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemOpenFieldDataHelperImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemOpenFieldDataHelperImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemOpenFieldDataHelperImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemOpenFieldDataHelperImpl>{ GetInstance() }; }

    partial void SetLatestData_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, ref System.Collections.Generic.Dictionary<System.Int32,System.Object> latestData);
    partial void SetLatestData_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, System.Collections.Generic.Dictionary<System.Int32,System.Object> latestData);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetLatestData_UnitTest()
  {
    System.Collections.Generic.Dictionary<System.Int32,System.Object> latestData = default(System.Collections.Generic.Dictionary<System.Int32,System.Object>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          latestData = default(System.Collections.Generic.Dictionary<System.Int32,System.Object>); //No Type
          SetLatestData_PreCondition(ref instance, ref latestData);
        },
       (instance) =>
       {
             instance.SetLatestData(latestData);
       },
      (instance) =>
      {
              SetLatestData_PostValidate(instance, latestData);
      });
  }
    partial void SetRevisionData_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, ref System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Object>> revisionData);
    partial void SetRevisionData_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Object>> revisionData);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetRevisionData_UnitTest()
  {
    System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Object>> revisionData = default(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Object>>);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          revisionData = default(System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.Int32,System.Object>>); //No Type
          SetRevisionData_PreCondition(ref instance, ref revisionData);
        },
       (instance) =>
       {
             instance.SetRevisionData(revisionData);
       },
      (instance) =>
      {
              SetRevisionData_PostValidate(instance, revisionData);
      });
  }
    partial void GetFieldId_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, ref System.String fieldName);
    partial void GetFieldId_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, System.String fieldName);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetFieldId_UnitTest()
  {
    System.String fieldName = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          fieldName = default(System.String); //No Constructor
          GetFieldId_PreCondition(ref instance, ref fieldName);
        },
       (instance) =>
       {
             instance.GetFieldId(fieldName);
       },
      (instance) =>
      {
              GetFieldId_PostValidate(instance, fieldName);
      });
  }
    partial void HasField_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, ref System.Int32 fieldId);
    partial void HasField_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper instance, System.Int32 fieldId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void HasField_UnitTest()
  {
    System.Int32 fieldId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemOpenFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          fieldId = default(System.Int32); //No Constructor
          HasField_PreCondition(ref instance, ref fieldId);
        },
       (instance) =>
       {
             instance.HasField(fieldId);
       },
      (instance) =>
      {
              HasField_PostValidate(instance, fieldId);
      });
  }
  }
}
