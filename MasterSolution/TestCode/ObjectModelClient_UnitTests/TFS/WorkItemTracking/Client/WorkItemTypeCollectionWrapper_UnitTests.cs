using System;
using System.Collections.Generic;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class WorkItemTypeCollectionWrapper_UnitTests
  {
      static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemTypeCollection real, string callerName)
    {
        real = GetRealInstance();
    }

    internal static WorkItemTypeCollection GetRealInstance()
    {
        var workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
        Project teamProject = workItemStore.Projects["RestPlaypen"];
        var real = teamProject.WorkItemTypes;
        return real;
    }
    private static readonly List<String> sr_DisabledTests = new List<string>()
      {
          "Import_UnitTest",
       };
    /// <summary>
    /// Gets the disabled tests.
    /// </summary>
    /// <value>The disabled tests.</value>
    protected override List<String> DisabledTests { get { return sr_DisabledTests; } }


  }
}
