using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    public partial class ITfsRequestChannelFactoryWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ITfsRequestChannelFactory real, string callerName) { real = new TemporaryMock(); }
    }

    class TemporaryMock : ITfsRequestChannelFactory
    {
        public ITfsRequestChannel CreateChannel(ITfsRequestChannel innerChannel) { return null; }
    }
}