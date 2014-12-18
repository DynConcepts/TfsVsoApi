using System;
using System.Net;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class ITfsRequestListenerImpl : IITfsRequestListener
    {
        void IITfsRequestListener.AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsRequestListener.BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int64 IITfsRequestListener.BeginRequest() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void IITfsRequestListener.EndRequest(Int64 requestId, Exception exception) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}