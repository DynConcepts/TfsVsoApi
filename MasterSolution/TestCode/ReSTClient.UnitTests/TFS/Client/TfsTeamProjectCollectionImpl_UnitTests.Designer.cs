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
  public partial class TfsTeamProjectCollectionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsTeamProjectCollectionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsTeamProjectCollectionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = default(DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsTeamProjectCollectionImpl);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsTeamProjectCollectionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.TfsTeamProjectCollectionImpl>{ GetInstance() }; }

   partial void ConfigurationServer_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsConfigurationServer setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ConfigurationServer_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ConfigurationServer;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TeamFoundationServer_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TeamFoundationServer_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.TeamFoundationServer;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
