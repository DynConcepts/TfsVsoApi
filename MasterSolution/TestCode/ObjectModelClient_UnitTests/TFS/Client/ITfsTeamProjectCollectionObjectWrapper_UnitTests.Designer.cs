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
  public partial class ITfsTeamProjectCollectionObjectWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsTeamProjectCollectionObjectWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsTeamProjectCollectionObjectWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.ITfsTeamProjectCollectionObject);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsTeamProjectCollectionObjectWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsTeamProjectCollectionObjectWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.ITfsTeamProjectCollectionObject real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsTeamProjectCollectionObjectWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.ITfsTeamProjectCollectionObjectWrapper>{ GetInstance() }; }

    partial void Initialize_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsTeamProjectCollectionObject instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection projectCollection);
    partial void Initialize_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsTeamProjectCollectionObject instance, DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection projectCollection);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Initialize_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection projectCollection = default(DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.IITfsTeamProjectCollectionObject) GetInstance();
        },
        (instance) =>
        {
          projectCollection = DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.TfsTeamProjectCollectionWrapper_UnitTests.GetInstance();
          Initialize_PreCondition(ref instance, ref projectCollection);
        },
       (instance) =>
       {
             instance.Initialize(projectCollection);
       },
      (instance) =>
      {
              Initialize_PostValidate(instance, projectCollection);
      });
  }
  }
}
