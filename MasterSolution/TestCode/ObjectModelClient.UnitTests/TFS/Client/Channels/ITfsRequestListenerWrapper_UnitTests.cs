using System;
using System.Net;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    public partial class ITfsRequestListenerWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ITfsRequestListener real, string callerName) { real = new TemporaryMock(); }

        class TemporaryMock : ITfsRequestListener
        {
            public void AfterReceiveReply(long requestId, string methodName, HttpWebResponse response) {  }

            public void BeforeSendRequest(long requestId, string methodName, HttpWebRequest request) {  }

            public long BeginRequest() { return long.MinValue; }

            public void EndRequest(long requestId, Exception exception) {  }
        }

    }
}