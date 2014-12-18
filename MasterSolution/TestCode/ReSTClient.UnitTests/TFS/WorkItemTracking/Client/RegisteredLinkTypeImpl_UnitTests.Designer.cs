using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class RegisteredLinkTypeImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RegisteredLinkTypeImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RegisteredLinkTypeImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RegisteredLinkTypeImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RegisteredLinkTypeImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.RegisteredLinkTypeImpl>{ GetInstance() }; }

    partial void Equals_PreCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType type);
    partial void Equals_PostValidate(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType instance, DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType type);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void Equals_UnitTest()
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType type = default(DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType);
      ExecuteMethod(
        () =>
        {
           return (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType) GetInstance();
        },
        (instance) =>
        {
          type = DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client.RegisteredLinkTypeImpl_UnitTests.GetInstance();
          Equals_PreCondition(ref instance, ref type);
        },
       (instance) =>
       {
             instance.Equals(type);
       },
      (instance) =>
      {
              Equals_PostValidate(instance, type);
      });
  }
  }
}
