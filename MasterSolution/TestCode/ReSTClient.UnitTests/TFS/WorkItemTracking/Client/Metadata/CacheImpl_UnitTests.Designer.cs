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
  public partial class CacheImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.CacheImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.CacheImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.CacheImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.CacheImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.Metadata.CacheImpl>{ GetInstance() }; }

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
