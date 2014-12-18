using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TfsConfigurationServerImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsConfigurationServerImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsConfigurationServerImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsConfigurationServerImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsConfigurationServerImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsConfigurationServerImpl>{ GetInstance() }; }

    partial void GetTeamProjectCollection_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConfigurationServer instance, ref System.Guid collectionId);
    partial void GetTeamProjectCollection_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConfigurationServer instance, System.Guid collectionId);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void GetTeamProjectCollection_UnitTest()
  {
    System.Guid collectionId = default(System.Guid);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConfigurationServer) GetInstance();
        },
        (instance) =>
        {
          collectionId = default(System.Guid); //No Constructor
          GetTeamProjectCollection_PreCondition(ref instance, ref collectionId);
        },
       (instance) =>
       {
             instance.GetTeamProjectCollection(collectionId);
       },
      (instance) =>
      {
              GetTeamProjectCollection_PostValidate(instance, collectionId);
      });
  }
  }
}
