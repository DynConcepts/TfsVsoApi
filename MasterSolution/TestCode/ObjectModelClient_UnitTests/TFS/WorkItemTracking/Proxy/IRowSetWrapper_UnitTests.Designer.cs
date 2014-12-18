using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class IRowSetWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.IRowSetWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.IRowSetWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.IRowSetWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.IRowSetWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.IRowSetWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.IRowSetWrapper>{ GetInstance() }; }

    partial void ContainsColumn_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet instance, ref System.String name);
    partial void ContainsColumn_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet instance, System.String name);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ContainsColumn_UnitTest()
  {
    System.String name = default(System.String);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          ContainsColumn_PreCondition(ref instance, ref name);
        },
       (instance) =>
       {
             instance.ContainsColumn(name);
       },
      (instance) =>
      {
              ContainsColumn_PostValidate(instance, name);
      });
  }
    partial void SwapRows_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet instance, ref System.Int32 row1, ref System.Int32 row2);
    partial void SwapRows_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet instance, System.Int32 row1, System.Int32 row2);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void SwapRows_UnitTest()
  {
    System.Int32 row1 = default(System.Int32);
    System.Int32 row2 = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet) GetInstance();
        },
        (instance) =>
        {
          row1 = default(System.Int32); //No Constructor
          row2 = default(System.Int32); //No Constructor
          SwapRows_PreCondition(ref instance, ref row1, ref row2);
        },
       (instance) =>
       {
             instance.SwapRows(row1,row2);
       },
      (instance) =>
      {
              SwapRows_PostValidate(instance, row1, row2);
      });
  }
   partial void RowCount_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void RowCount_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.RowCount;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ColumnCount_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet instance, ref System.Int32 setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ColumnCount_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IIRowSet) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ColumnCount;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
