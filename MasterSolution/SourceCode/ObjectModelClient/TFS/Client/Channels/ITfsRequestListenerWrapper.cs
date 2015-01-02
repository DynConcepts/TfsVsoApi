using System;
using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class ITfsRequestListenerWrapper.
    /// </summary>
    internal class ITfsRequestListenerWrapper : ITfsRequestListenerWrapper<IITfsRequestListener, ITfsRequestListener>, IITfsRequestListener
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsRequestListenerWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsRequestListenerWrapper(ITfsRequestListener instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsRequestListener, ITfsRequestListener>(src => src == null ? null : ((ITfsRequestListenerWrapper) src).r_Instance, src => new ITfsRequestListenerWrapper(src)); }
    }


    /// <summary>
    /// Class ITfsRequestListenerWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class ITfsRequestListenerWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsRequestListener where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Afters the receive reply.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="response">The response.</param>
        void IITfsRequestListener.AfterReceiveReply(Int64 requestId, String methodName, HttpWebResponse response) { r_Instance.AfterReceiveReply(requestId, methodName, response); }

        /// <summary>
        /// Befores the send request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="request">The request.</param>
        void IITfsRequestListener.BeforeSendRequest(Int64 requestId, String methodName, HttpWebRequest request) { r_Instance.BeforeSendRequest(requestId, methodName, request); }

        /// <summary>
        /// Begins the request.
        /// </summary>
        /// <returns>Int64.</returns>
        Int64 IITfsRequestListener.BeginRequest()
        {
            long nativeCallResult = r_Instance.BeginRequest();
            return nativeCallResult;
        }


        /// <summary>
        /// Ends the request.
        /// </summary>
        /// <param name="requestId">The request identifier.</param>
        /// <param name="exception">The exception.</param>
        void IITfsRequestListener.EndRequest(Int64 requestId, Exception exception) { r_Instance.EndRequest(requestId, exception); }
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsRequestListenerWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsRequestListenerWrapper(ITfsRequestListener instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ITfsRequestListener r_Instance;
    }
}