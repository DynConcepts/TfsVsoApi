using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class TfsConfigurationServerWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConfigurationServerWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConfigurationServerWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.TfsConfigurationServer);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConfigurationServerWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConfigurationServerWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.TfsConfigurationServer real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConfigurationServerWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsConfigurationServerWrapper>{ GetInstance() }; }

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
