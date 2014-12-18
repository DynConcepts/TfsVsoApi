using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class AccessControlEntryExtendedDataWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.AccessControlEntryExtendedDataWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.AccessControlEntryExtendedDataWrapper GetInstance() 
  { 
    var real = default(Microsoft.TeamFoundation.WorkItemTracking.Proxy.AccessControlEntryExtendedData);
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.AccessControlEntryExtendedDataWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.AccessControlEntryExtendedDataWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Proxy.AccessControlEntryExtendedData real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.AccessControlEntryExtendedDataWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy.AccessControlEntryExtendedDataWrapper>{ GetInstance() }; }

  }
}
