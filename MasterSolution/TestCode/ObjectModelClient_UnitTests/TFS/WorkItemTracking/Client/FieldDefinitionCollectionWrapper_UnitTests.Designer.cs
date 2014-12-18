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
  public partial class FieldDefinitionCollectionWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.FieldDefinitionCollection);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.FieldDefinitionCollection real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionWrapper>{ GetInstance() }; }

    partial void GetById_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection instance, ref System.Int32 id);
    partial void GetById_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection instance, System.Int32 id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetById_UnitTest()
  {
    System.Int32 id = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          GetById_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.GetById(id);
       },
      (instance) =>
      {
              GetById_PostValidate(instance, id);
      });
  }
    partial void TryGetById_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection instance, ref System.Int32 id);
    partial void TryGetById_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection instance, System.Int32 id);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TryGetById_UnitTest()
  {
    System.Int32 id = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection) GetInstance();
        },
        (instance) =>
        {
          id = default(System.Int32); //No Constructor
          TryGetById_PreCondition(ref instance, ref id);
        },
       (instance) =>
       {
             instance.TryGetById(id);
       },
      (instance) =>
      {
              TryGetById_PostValidate(instance, id);
      });
  }
    partial void TryGetByName_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection instance, ref System.String name);
    partial void TryGetByName_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection instance, System.String name);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TryGetByName_UnitTest()
  {
    System.String name = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IFieldDefinitionCollection) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          TryGetByName_PreCondition(ref instance, ref name);
        },
       (instance) =>
       {
             instance.TryGetByName(name);
       },
      (instance) =>
      {
              TryGetByName_PostValidate(instance, name);
      });
  }
  }
}
