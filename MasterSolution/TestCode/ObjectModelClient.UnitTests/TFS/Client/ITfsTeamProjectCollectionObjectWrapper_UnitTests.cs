using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ITfsTeamProjectCollectionObjectWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ITfsTeamProjectCollectionObject real, string callerName) { real = new TemporaryMock(); }
    }

    class TemporaryMock : ITfsTeamProjectCollectionObject
    {
        public void Initialize(TfsTeamProjectCollection projectCollection) {  }
    }
}