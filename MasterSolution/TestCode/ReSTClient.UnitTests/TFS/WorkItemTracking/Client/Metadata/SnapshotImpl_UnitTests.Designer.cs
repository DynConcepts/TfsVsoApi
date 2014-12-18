using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.Metadata
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class SnapshotImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.SnapshotImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.SnapshotImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.SnapshotImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.SnapshotImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.SnapshotImpl>{ GetInstance() }; }

    partial void LoadFieldIdsByWorkItemType_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ISnapshot instance, ref System.Int32 typeId);
    partial void LoadFieldIdsByWorkItemType_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ISnapshot instance, System.Int32 typeId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void LoadFieldIdsByWorkItemType_UnitTest()
  {
    System.Int32 typeId = default(System.Int32);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ISnapshot) GetInstance();
        },
        (instance) =>
        {
          typeId = default(System.Int32); //No Constructor
          LoadFieldIdsByWorkItemType_PreCondition(ref instance, ref typeId);
        },
       (instance) =>
       {
             instance.LoadFieldIdsByWorkItemType(typeId);
       },
      (instance) =>
      {
              LoadFieldIdsByWorkItemType_PostValidate(instance, typeId);
      });
  }
  }
}
