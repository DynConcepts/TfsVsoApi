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
  public partial class WorkItemTypeImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeImpl) DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeImpl.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeImpl>{ GetInstance() }; }

    partial void Export_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, ref System.Boolean includeGlobalListsFlag);
    partial void Export_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, System.Boolean includeGlobalListsFlag);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Export_UnitTest()
  {
    System.Boolean includeGlobalListsFlag = default(System.Boolean);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
        },
        (instance) =>
        {
          includeGlobalListsFlag = default(System.Boolean); //No Constructor
          Export_PreCondition(ref instance, ref includeGlobalListsFlag);
        },
       (instance) =>
       {
             instance.Export(includeGlobalListsFlag);
       },
      (instance) =>
      {
              Export_PostValidate(instance, includeGlobalListsFlag);
      });
  }
    partial void GetNextState_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, ref System.String currentState, ref System.String action);
    partial void GetNextState_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, System.String currentState, System.String action);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetNextState_UnitTest()
  {
    System.String currentState = default(System.String);
    System.String action = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
        },
        (instance) =>
        {
          currentState = default(System.String); //No Constructor
          action = default(System.String); //No Constructor
          GetNextState_PreCondition(ref instance, ref currentState, ref action);
        },
       (instance) =>
       {
             instance.GetNextState(currentState,action);
       },
      (instance) =>
      {
              GetNextState_PostValidate(instance, currentState, action);
      });
  }
    partial void NewWorkItem_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance);
    partial void NewWorkItem_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void NewWorkItem_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
        },
        (instance) =>
        {
          NewWorkItem_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.NewWorkItem();
       },
      (instance) =>
      {
              NewWorkItem_PostValidate(instance);
      });
  }
   partial void Project_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Project_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Project;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void DisplayForm_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void DisplayForm_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.DisplayForm;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void FieldDefinitions_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void FieldDefinitions_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.FieldDefinitions;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void Store_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Store_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemType) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Store;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
