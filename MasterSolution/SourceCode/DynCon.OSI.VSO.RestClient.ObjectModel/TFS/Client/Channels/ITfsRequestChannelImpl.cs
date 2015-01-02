using System;
using System.Globalization;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client.Channels
{
    internal class ITfsRequestChannelImpl : IITfsRequestChannel
    {
        void IITfsRequestChannel.Abort() { throw new ToBeImplementedException(); }
        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }
        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, TimeSpan timeout, AsyncCallback callback, Object state) { throw new ToBeImplementedException(); }
        ITfsClientCredentials IITfsRequestChannel.Credentials { get { throw new ToBeImplementedException(); } }
        CultureInfo IITfsRequestChannel.Culture { get { throw new ToBeImplementedException(); } }
        ITfsMessage IITfsRequestChannel.EndRequest(IAsyncResult result) { throw new ToBeImplementedException(); }
        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message) { throw new ToBeImplementedException(); }
        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message, TimeSpan timeout) { throw new ToBeImplementedException(); }
        Guid IITfsRequestChannel.SessionId { get { throw new ToBeImplementedException(); } }
        ITfsRequestSettings IITfsRequestChannel.Settings { get { throw new ToBeImplementedException(); } }
        ITfsHttpClientState IITfsRequestChannel.State { get { throw new ToBeImplementedException(); } }
        Uri IITfsRequestChannel.Uri { get { throw new ToBeImplementedException(); } }
    }
}