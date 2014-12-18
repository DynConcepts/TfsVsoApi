using System;
using System.Globalization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class ITfsRequestChannelImpl : IITfsRequestChannel
    {
        void IITfsRequestChannel.Abort() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, AsyncCallback callback, Object state) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, TimeSpan timeout, AsyncCallback callback, Object state) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ITfsClientCredentials IITfsRequestChannel.Credentials { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        CultureInfo IITfsRequestChannel.Culture { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ITfsMessage IITfsRequestChannel.EndRequest(IAsyncResult result) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message, TimeSpan timeout) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Guid IITfsRequestChannel.SessionId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ITfsRequestSettings IITfsRequestChannel.Settings { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ITfsHttpClientState IITfsRequestChannel.State { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri IITfsRequestChannel.Uri { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}