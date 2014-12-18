using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class FieldCollectionWrapper_UnitTests
  {
      static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.FieldCollection real, string callerName)
      {
        real = GetRealInstance();
    }

    internal static FieldCollection GetRealInstance()
    {
        FieldCollection real;
        var workItem = WorkItemWrapper_UnitTests.GetRealInstance();
        real = workItem.Fields;
        return real;
    }
  }
}
