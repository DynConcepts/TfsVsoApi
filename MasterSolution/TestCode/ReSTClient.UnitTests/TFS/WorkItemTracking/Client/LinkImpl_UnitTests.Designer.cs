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
  public partial class LinkImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.LinkImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.LinkImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    JToken json = new JObject();
    JsonSource(ref json);
    var instance = (DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.LinkImpl) DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.LinkImpl.FromToken(json);
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  static partial void JsonSource(ref JToken json);
  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.LinkImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.LinkImpl>{ GetInstance() }; }

   partial void BaseType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILink instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IBaseLinkType setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void BaseType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILink) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.BaseType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
   partial void ArtifactLinkType_SetCondition(ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILink instance, ref DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRegisteredLinkType setValue);
/// <summary>Generated Test Template</summary>
  [TestMethod]
  public void ArtifactLinkType_UnitTest()
  {
      ExecuteProperty(
        () =>
        // Create Test Instance
        {
           var instance = (DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ILink) GetInstance();
           return instance;
        },
        null, null,null,  // No Set Accessor
        // Invoke Getter
        (instance) =>
        {
            return instance.ArtifactLinkType;
        },
        // Validate Get Operation
       (instance, setValue, getValue) =>
       {
       });
  }
  }
}
