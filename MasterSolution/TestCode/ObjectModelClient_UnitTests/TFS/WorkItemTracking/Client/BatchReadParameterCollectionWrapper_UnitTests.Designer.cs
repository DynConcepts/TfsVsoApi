using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  [TestClass]
  public partial class BatchReadParameterCollectionWrapper_UnitTests : DynTestClassBase 
  {
  static partial void InstanceFactory(ref DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.BatchReadParameterCollectionWrapper instance, [CallerMemberName]string callerName = "");
  internal static DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.BatchReadParameterCollectionWrapper GetInstance() 
  { 
    var real = new Microsoft.TeamFoundation.WorkItemTracking.Client.BatchReadParameterCollection();
    RealInstanceFactory(ref real);
    var instance = (DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.BatchReadParameterCollectionWrapper) DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.BatchReadParameterCollectionWrapper.GetWrapper(real);
    InstanceFactory(ref instance);
    if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
    return instance;
  }

  static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.BatchReadParameterCollection real, [CallerMemberName]string callerName = "");
  internal static IEnumerable<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.BatchReadParameterCollectionWrapper> GetIEnumerableInstance() { 
return new List<DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client.BatchReadParameterCollectionWrapper>{ GetInstance() }; }

  }
}
