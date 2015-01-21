using System;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    public partial class ITfsRequestChannelWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ITfsRequestChannel real, string callerName) { real = new TemporaryMock(); }

        private class TemporaryMock : ITfsRequestChannel
        {
            public void Abort() {  }

            public IAsyncResult BeginRequest(TfsMessage message, AsyncCallback callback, object state) { return null; }

            public IAsyncResult BeginRequest(TfsMessage message, TimeSpan timeout, AsyncCallback callback, object state) { return null; }

            public TfsMessage EndRequest(IAsyncResult result) { return null; }

            public TfsMessage Request(TfsMessage message) { return null; }

            public TfsMessage Request(TfsMessage message, TimeSpan timeout) { return null; }

            public Uri Uri { get {return null;  } }

            public TfsClientCredentials Credentials { get { return null; } }

            public CultureInfo Culture { get { return null; } }

            public Guid SessionId { get { return Guid.Empty; } }

            public TfsRequestSettings Settings { get { return null; } }

            public TfsHttpClientState State { get { return default(TfsHttpClientState); } }
        }
    }
}