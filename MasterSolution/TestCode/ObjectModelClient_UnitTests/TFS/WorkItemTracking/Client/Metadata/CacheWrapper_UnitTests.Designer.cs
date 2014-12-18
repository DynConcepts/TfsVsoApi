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
  public partial class CacheWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.CacheWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.CacheWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata.Cache);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.CacheWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.CacheWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.Metadata.Cache real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.CacheWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.Metadata.CacheWrapper>{ GetInstance() }; }

    partial void GetSnapshot_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ICache instance);
    partial void GetSnapshot_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ICache instance);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetSnapshot_UnitTest()
  {
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata.ICache) GetInstance();
        },
        (instance) =>
        {
          GetSnapshot_PreCondition(ref instance);
        },
       (instance) =>
       {
             instance.GetSnapshot();
       },
      (instance) =>
      {
              GetSnapshot_PostValidate(instance);
      });
  }
  }
}
