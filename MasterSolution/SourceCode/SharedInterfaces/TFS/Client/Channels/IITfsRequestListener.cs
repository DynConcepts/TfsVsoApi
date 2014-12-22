using System;
using System.Net;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    public interface IITfsRequestListener
    {
        void AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response);
        void BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request);
        Int64 BeginRequest();
        void EndRequest(Int64 requestId, Exception exception);
    }
}