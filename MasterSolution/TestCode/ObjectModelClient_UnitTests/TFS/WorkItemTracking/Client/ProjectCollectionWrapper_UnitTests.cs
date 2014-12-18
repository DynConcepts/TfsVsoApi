using System;
using System.Collections.ObjectModel;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class ProjectCollectionWrapper_UnitTests
  {
      static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.ProjectCollection real, string callerName)
      {
        real = GetRealInstance();
    }

    internal static ProjectCollection GetRealInstance()
    {
        ProjectCollection real;
        var workItemStore = WorkItemStoreWrapper_UnitTests.GetRealInstance();
        real = workItemStore.Projects;
        return real;
    }
  }
}
