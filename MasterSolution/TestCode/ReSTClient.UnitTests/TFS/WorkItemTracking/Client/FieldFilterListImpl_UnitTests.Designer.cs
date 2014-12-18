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
  public partial class FieldFilterListImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldFilterListImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldFilterListImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldFilterListImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldFilterListImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldFilterListImpl>{ GetInstance() }; }

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
          filter = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.FieldFilterImpl_UnitTests.GetInstance();
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
          value = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.FieldFilterImpl_UnitTests.GetInstance();
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
