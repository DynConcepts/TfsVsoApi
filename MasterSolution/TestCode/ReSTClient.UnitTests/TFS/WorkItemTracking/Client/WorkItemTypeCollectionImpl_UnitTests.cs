using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class WorkItemTypeCollectionImpl_UnitTests
  {
      static partial void InstanceFactory(ref DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client.WorkItemTypeCollectionImpl instance, string callerName)
    {
        IReadOnlyList<IWorkItemType> items = new List<IWorkItemType>();
        instance = new WorkItemTypeCollectionImpl(items);
    }
  }
}
