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
  public partial class WorkItemFieldDataWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldDataWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldDataWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemFieldData);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldDataWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldDataWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemFieldData real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldDataWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldDataWrapper>{ GetInstance() }; }

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
          flags = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldFlagsWrapper_UnitTests.GetInstance();
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
          fu = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper_UnitTests.GetInstance();
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


namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemFieldData_FieldFlagsWrapper_UnitTests : DynTestClassBase 
  {
  internal static DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags GetInstance() { return default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemFieldData_FieldFlags); }

  }
}


namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemFieldData_FieldInfoWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemFieldData.FieldInfo);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemFieldData.FieldInfo real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldInfoWrapper>{ GetInstance() }; }

  }
}


namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class WorkItemFieldData_FieldUpdateWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemFieldData.FieldUpdate);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemFieldData.FieldUpdate real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.WorkItemFieldData_FieldUpdateWrapper>{ GetInstance() }; }

  }
}
