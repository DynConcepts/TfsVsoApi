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
  public partial class FieldDefinitionCollectionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionImpl) DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionImpl.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.FieldDefinitionCollectionImpl>{ GetInstance() }; }

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
