using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Common
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class VariableSizeListImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common.VariableSizeListImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common.VariableSizeListImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common.VariableSizeListImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common.VariableSizeListImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Common.VariableSizeListImpl>{ GetInstance() }; }

    partial void RemoveAt_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList instance, ref System.Int32 index);
    partial void RemoveAt_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList instance, System.Int32 index);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RemoveAt_UnitTest()
  {
    System.Int32 index = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList) GetInstance();
        },
        (instance) =>
        {
          index = default(System.Int32); //No Constructor
          RemoveAt_PreCondition(ref instance, ref index);
        },
       (instance) =>
       {
             instance.RemoveAt(index);
       },
      (instance) =>
      {
              RemoveAt_PostValidate(instance, index);
      });
  }
    partial void Clear_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList instance);
    partial void Clear_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Clear_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IVariableSizeList) GetInstance();
        },
        (instance) =>
        {
          Clear_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.Clear();
       },
      (instance) =>
      {
              Clear_PostValidate(instance);
      });
  }
  }
}
