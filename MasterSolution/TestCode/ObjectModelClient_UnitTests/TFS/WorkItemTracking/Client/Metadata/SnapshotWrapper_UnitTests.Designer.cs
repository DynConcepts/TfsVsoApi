using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client.Metadata
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class SnapshotWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.SnapshotWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.SnapshotWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata.Snapshot);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.SnapshotWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.SnapshotWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata.Snapshot real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.SnapshotWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.SnapshotWrapper>{ GetInstance() }; }

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
