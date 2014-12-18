using System;
using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal class ITfsRequestListenerWrapper : ITfsRequestListenerWrapper<IITfsRequestListener, ITfsRequestListener>, IITfsRequestListener
    {
        protected ITfsRequestListenerWrapper(ITfsRequestListener instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsRequestListener, ITfsRequestListener>(src => ((ITfsRequestListenerWrapper) src).r_Instance, src => new ITfsRequestListenerWrapper(src)); }
    }


    internal abstract class ITfsRequestListenerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsRequestListener where TInterface : class where TWrapper : class
    {

        void IITfsRequestListener.AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response) { r_Instance.AfterReceiveReply(requestId, methodName, response); }

        void IITfsRequestListener.BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request) { r_Instance.BeforeSendRequest(requestId, methodName, request); }

        Int64 IITfsRequestListener.BeginRequest()
        {
            long nativeCallResult = r_Instance.BeginRequest();
            return nativeCallResult;
        }


        void IITfsRequestListener.EndRequest(Int64 requestId, Exception exception) { r_Instance.EndRequest(requestId, exception); }
        protected ITfsRequestListenerWrapper(ITfsRequestListener instance) { r_Instance = instance; }
        protected readonly ITfsRequestListener r_Instance;
    }
}