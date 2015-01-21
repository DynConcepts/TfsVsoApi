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
  public partial class ValuesCollectionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.ValuesCollectionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.ValuesCollectionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.ValuesCollectionImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.ValuesCollectionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.ValuesCollectionImpl>{ GetInstance() }; }

    partial void Contains_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection instance, ref System.String value);
    partial void Contains_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection instance, System.String value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Contains_UnitTest()
  {
    System.String value = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection) GetInstance();
        },
        (instance) =>
        {
          value = default(System.String); //No Constructor
          Contains_PreCondition(ref instance, ref value);
        },
       (instance) =>
       {
             instance.Contains(value);
       },
      (instance) =>
      {
              Contains_PostValidate(instance, value);
      });
  }
    partial void IndexOf_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection instance, ref System.String value);
    partial void IndexOf_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection instance, System.String value);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void IndexOf_UnitTest()
  {
    System.String value = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection) GetInstance();
        },
        (instance) =>
        {
          value = default(System.String); //No Constructor
          IndexOf_PreCondition(ref instance, ref value);
        },
       (instance) =>
       {
             instance.IndexOf(value);
       },
      (instance) =>
      {
              IndexOf_PostValidate(instance, value);
      });
  }
   partial void Item_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Item_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IValuesCollection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.Item;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
