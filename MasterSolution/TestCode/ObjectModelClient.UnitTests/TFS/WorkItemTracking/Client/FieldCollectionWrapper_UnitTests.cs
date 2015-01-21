using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class FieldCollectionWrapper_UnitTests
    {
        internal static FieldCollection GetRealInstance()
        {
            FieldCollection real;
            WorkItem workItem = WorkItemWrapper_UnitTests.GetRealInstance();
            real = workItem.Fields;
            return real;
        }

        static partial void RealInstanceFactory(ref FieldCollection real, string callerName) { real = GetRealInstance(); }
    }
}