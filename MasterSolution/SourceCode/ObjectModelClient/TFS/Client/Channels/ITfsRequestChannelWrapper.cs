using System;
using System.Globalization;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class ITfsRequestChannelWrapper.
    /// </summary>
    internal class ITfsRequestChannelWrapper : ITfsRequestChannelWrapper<IITfsRequestChannel, ITfsRequestChannel>, IITfsRequestChannel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsRequestChannelWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsRequestChannelWrapper(ITfsRequestChannel instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsRequestChannel, ITfsRequestChannel>(src => src == null ? null : ((ITfsRequestChannelWrapper) src).r_Instance, src => new ITfsRequestChannelWrapper(src)); }
    }


    /// <summary>
    /// Class ITfsRequestChannelWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class ITfsRequestChannelWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsRequestChannel where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Aborts this instance.
        /// </summary>
        void IITfsRequestChannel.Abort() { r_Instance.Abort(); }

        /// <summary>
        /// Begins the request.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginRequest(TfsMessageWrapper.GetInstance(message), callback, state);
            return nativeCallResult;
        }


        /// <summary>
        /// Begins the request.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <returns>IAsyncResult.</returns>
        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, TimeSpan timeout, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginRequest(TfsMessageWrapper.GetInstance(message), timeout, callback, state);
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the credentials.
        /// </summary>
        /// <value>The credentials.</value>
        ITfsClientCredentials IITfsRequestChannel.Credentials
        {
            get
            {
                TfsClientCredentials nativeCallResult = r_Instance.Credentials;
                ITfsClientCredentials wrappedCallResult = TfsClientCredentialsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the culture.
        /// </summary>
        /// <value>The culture.</value>
        CultureInfo IITfsRequestChannel.Culture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.Culture;
                return nativeCallResult;
            }
        }


        /// <summary>
        /// Ends the request.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>ITfsMessage.</returns>
        ITfsMessage IITfsRequestChannel.EndRequest(IAsyncResult result)
        {
            TfsMessage nativeCallResult = r_Instance.EndRequest(result);
            ITfsMessage wrappedCallResult = TfsMessageWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Requests the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>ITfsMessage.</returns>
        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message)
        {
            TfsMessage nativeCallResult = r_Instance.Request(TfsMessageWrapper.GetInstance(message));
            ITfsMessage wrappedCallResult = TfsMessageWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Requests the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns>ITfsMessage.</returns>
        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message, TimeSpan timeout)
        {
            TfsMessage nativeCallResult = r_Instance.Request(TfsMessageWrapper.GetInstance(message), timeout);
            ITfsMessage wrappedCallResult = TfsMessageWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the session identifier.
        /// </summary>
        /// <value>The session identifier.</value>
        Guid IITfsRequestChannel.SessionId
        {
            get
            {
                Guid nativeCallResult = r_Instance.SessionId;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>The settings.</value>
        ITfsRequestSettings IITfsRequestChannel.Settings
        {
            get
            {
                TfsRequestSettings nativeCallResult = r_Instance.Settings;
                ITfsRequestSettings wrappedCallResult = TfsRequestSettingsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>The state.</value>
        ITfsHttpClientState IITfsRequestChannel.State
        {
            get
            {
                TfsHttpClientState nativeCallResult = r_Instance.State;
                ITfsHttpClientState wrappedCallResult = TfsHttpClientStateWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri IITfsRequestChannel.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsRequestChannelWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsRequestChannelWrapper(ITfsRequestChannel instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ITfsRequestChannel r_Instance;
    }
}