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
  public partial class IWorkItemSaveFieldDataHelperImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperImpl>{ GetInstance() }; }

    partial void IsLongTextField_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, ref System.Int32 fieldId);
    partial void IsLongTextField_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, System.Int32 fieldId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IsLongTextField_UnitTest()
  {
    System.Int32 fieldId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          fieldId = default(System.Int32); //No Constructor
          IsLongTextField_PreCondition(ref instance, ref fieldId);
        },
       (instance) =>
       {
             instance.IsLongTextField(fieldId);
       },
      (instance) =>
      {
              IsLongTextField_PostValidate(instance, fieldId);
      });
  }
    partial void GetFieldReferenceName_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, ref System.Int32 fieldId);
    partial void GetFieldReferenceName_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, System.Int32 fieldId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetFieldReferenceName_UnitTest()
  {
    System.Int32 fieldId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          fieldId = default(System.Int32); //No Constructor
          GetFieldReferenceName_PreCondition(ref instance, ref fieldId);
        },
       (instance) =>
       {
             instance.GetFieldReferenceName(fieldId);
       },
      (instance) =>
      {
              GetFieldReferenceName_PostValidate(instance, fieldId);
      });
  }
    partial void GetFieldName_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, ref System.Int32 fieldId);
    partial void GetFieldName_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, System.Int32 fieldId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetFieldName_UnitTest()
  {
    System.Int32 fieldId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          fieldId = default(System.Int32); //No Constructor
          GetFieldName_PreCondition(ref instance, ref fieldId);
        },
       (instance) =>
       {
             instance.GetFieldName(fieldId);
       },
      (instance) =>
      {
              GetFieldName_PostValidate(instance, fieldId);
      });
  }
    partial void GetFieldSystemType_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, ref System.Int32 fieldId);
    partial void GetFieldSystemType_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, System.Int32 fieldId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetFieldSystemType_UnitTest()
  {
    System.Int32 fieldId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper) GetInstance();
        },
        (instance) =>
        {
          fieldId = default(System.Int32); //No Constructor
          GetFieldSystemType_PreCondition(ref instance, ref fieldId);
        },
       (instance) =>
       {
             instance.GetFieldSystemType(fieldId);
       },
      (instance) =>
      {
              GetFieldSystemType_PostValidate(instance, fieldId);
      });
  }
   partial void FieldUpdates_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper instance, ref System.Collections.Generic.Dictionary<System.Int32,System.Object> setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FieldUpdates_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals.IIWorkItemSaveFieldDataHelper) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.FieldUpdates;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
