using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Common
{
    /// <summary>Generated Test Template</summary>
    public partial class IVersionTagWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref IVersionTag real,  string callerName) { real = new TemporaryMock(); }

        class TemporaryMock : IVersionTag 
        {
            public int VersionTag { get { return int.MinValue; } }
        }
    }
}