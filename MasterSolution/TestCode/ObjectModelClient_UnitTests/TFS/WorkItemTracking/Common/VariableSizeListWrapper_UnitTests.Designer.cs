using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class VariableSizeListWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.VariableSizeListWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.VariableSizeListWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Common.VariableSizeList);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.VariableSizeListWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.VariableSizeListWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Common.VariableSizeList real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.VariableSizeListWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.VariableSizeListWrapper>{ GetInstance() }; }

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
