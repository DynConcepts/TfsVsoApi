using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
/// <summary>Generated Test Template</summary>
  public partial class FieldWrapper_UnitTests
  {
      static partial void RealInstanceFactory(ref Microsoft.TeamFoundation.WorkItemTracking.Client.Field real, string callerName)
      {
        real = GetRealInstance();
    }

    internal static Field GetRealInstance()
    {
        Field real;
        var collection = FieldCollectionWrapper_UnitTests.GetRealInstance();
        real = collection["Title"];
        return real;
    }
  }
}
