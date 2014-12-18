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
  public partial class WorkItemLinkTypeEndCollectionImpl_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeEndCollectionImpl instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeEndCollectionImpl GetInstance([CallerMemberName]string callerName = "") 
  { 
    var instance = new DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeEndCollectionImpl();
    InstanceFactory(ref instance, callerName);
    return  instance;
  }

  internal static IEnumerable<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeEndCollectionImpl> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemLinkTypeEndCollectionImpl>{ GetInstance() }; }

  }
}
