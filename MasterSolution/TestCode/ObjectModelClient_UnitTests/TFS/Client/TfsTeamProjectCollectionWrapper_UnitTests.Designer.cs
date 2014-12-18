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
  public partial class TfsTeamProjectCollectionWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsTeamProjectCollectionWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsTeamProjectCollectionWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.Client.TfsTeamProjectCollection);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsTeamProjectCollectionWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsTeamProjectCollectionWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.Client.TfsTeamProjectCollection real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsTeamProjectCollectionWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.Client.TfsTeamProjectCollectionWrapper>{ GetInstance() }; }

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
