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
  public partial class ITfsTeamProjectCollectionObjectImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsTeamProjectCollectionObjectImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsTeamProjectCollectionObjectImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsTeamProjectCollectionObjectImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsTeamProjectCollectionObjectImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.ITfsTeamProjectCollectionObjectImpl>{ GetInstance() }; }

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
          projectCollection = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client.TfsTeamProjectCollectionImpl_UnitTests.GetInstance();
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
