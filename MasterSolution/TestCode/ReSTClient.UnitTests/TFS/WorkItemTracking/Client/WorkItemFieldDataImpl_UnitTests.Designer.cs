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
  public partial class WorkItemFieldDataImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldDataImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldDataImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldDataImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldDataImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldDataImpl>{ GetInstance() }; }

    partial void SetUpdateFieldValue_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData instance, ref System.Int32 id, ref System.Object value, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags flags);
    partial void SetUpdateFieldValue_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData instance, System.Int32 id, System.Object value, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags flags);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SetUpdateFieldValue_UnitTest()
  {
    System.Int32 id = default(System.Int32);
    System.Object value = default(System.Object);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags flags = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          value = new System.Object();
          flags = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldFlagsImpl_UnitTests.GetInstance();
          SetUpdateFieldValue_PreCondition(ref instance, ref id, ref value, ref flags);
        },
       (instance) =>
       {
             instance.SetUpdateFieldValue(id,value,flags);
       },
      (instance) =>
      {
              SetUpdateFieldValue_PostValidate(instance, id, value, flags);
      });
  }
    partial void GetFieldState_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData instance, ref System.Int32 id);
    partial void GetFieldState_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData instance, System.Int32 id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetFieldState_UnitTest()
  {
    System.Int32 id = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          GetFieldState_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.GetFieldState(id);
       },
      (instance) =>
      {
              GetFieldState_PostValidate(instance, id);
      });
  }
    partial void GetUpdateFieldValue_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData instance, ref System.Int32 id, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldUpdate fu);
    partial void GetUpdateFieldValue_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData instance, System.Int32 id, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldUpdate fu);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetUpdateFieldValue_UnitTest()
  {
    System.Int32 id = default(System.Int32);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldUpdate fu = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldUpdate);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          fu = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateImpl_UnitTests.GetInstance();
          GetUpdateFieldValue_PreCondition(ref instance, ref id, ref fu);
        },
       (instance) =>
       {
             instance.GetUpdateFieldValue(id, out fu);
       },
      (instance) =>
      {
              GetUpdateFieldValue_PostValidate(instance, id, fu);
      });
  }
  }
}


namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemFieldData_FieldFlagsImpl_UnitTests : DynTestClassBase 
  {
  internal static DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags GetInstance() { return default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags); }

  }
}


namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemFieldData_FieldInfoImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = default(DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoImpl);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoImpl>{ GetInstance() }; }

  }
}


namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemFieldData_FieldUpdateImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = default(DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateImpl);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateImpl>{ GetInstance() }; }

  }
}
