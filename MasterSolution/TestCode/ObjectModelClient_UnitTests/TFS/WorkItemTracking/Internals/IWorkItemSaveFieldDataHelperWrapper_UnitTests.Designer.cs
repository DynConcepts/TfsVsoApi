using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Internals
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IWorkItemSaveFieldDataHelperWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelper);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelper real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Internals.IWorkItemSaveFieldDataHelperWrapper>{ GetInstance() }; }

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
