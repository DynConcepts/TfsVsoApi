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
  public partial class RowSetCollectionWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Proxy.RowSetCollection);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Proxy.RowSetCollection real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.RowSetCollectionWrapper>{ GetInstance() }; }

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
          rowset = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy.RowSetWrapper_UnitTests.GetInstance();
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
