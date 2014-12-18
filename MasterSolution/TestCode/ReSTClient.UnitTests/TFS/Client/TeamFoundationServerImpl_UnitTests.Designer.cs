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
  public partial class TeamFoundationServerImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.Client.TeamFoundationServerImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.Client.TeamFoundationServerImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.Client.TeamFoundationServerImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.Client.TeamFoundationServerImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.Client.TeamFoundationServerImpl>{ GetInstance() }; }

   partial void AuthenticatedUserName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AuthenticatedUserName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AuthenticatedUserName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AuthenticatedUserDisplayName_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer instance, ref System.String setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AuthenticatedUserDisplayName_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AuthenticatedUserDisplayName;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void AuthenticatedUserIdentity_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Server.IIdentity setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void AuthenticatedUserIdentity_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.AuthenticatedUserIdentity;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void TfsTeamProjectCollection_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITfsTeamProjectCollection setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void TfsTeamProjectCollection_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.Client.ITeamFoundationServer) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.TfsTeamProjectCollection;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
