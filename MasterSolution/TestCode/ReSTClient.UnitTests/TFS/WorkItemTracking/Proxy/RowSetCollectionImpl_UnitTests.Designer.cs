using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class RowSetCollectionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.RowSetCollectionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.RowSetCollectionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.RowSetCollectionImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.RowSetCollectionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy.RowSetCollectionImpl>{ GetInstance() }; }

    partial void TryGetRowSet_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection instance, ref System.String name, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet rowset);
    partial void TryGetRowSet_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection instance, System.String name, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet rowset);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TryGetRowSet_UnitTest()
  {
    System.String name = default(System.String);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet rowset = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSet);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy.IRowSetCollection) GetInstance();
        },
        (instance) =>
        {
          name = default(System.String); //No Constructor
          rowset = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Proxy.RowSetImpl_UnitTests.GetInstance();
          TryGetRowSet_PreCondition(ref instance, ref name, ref rowset);
        },
       (instance) =>
       {
             instance.TryGetRowSet(name, out rowset);
       },
      (instance) =>
      {
              TryGetRowSet_PostValidate(instance, name, rowset);
      });
  }
  }
}
