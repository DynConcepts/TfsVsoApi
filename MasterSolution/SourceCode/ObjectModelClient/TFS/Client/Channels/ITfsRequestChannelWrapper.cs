using System;
using System.Globalization;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal class ITfsRequestChannelWrapper : ITfsRequestChannelWrapper<IITfsRequestChannel, ITfsRequestChannel>, IITfsRequestChannel
    {
        protected ITfsRequestChannelWrapper(ITfsRequestChannel instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsRequestChannel, ITfsRequestChannel>(src => src==null ? null : ((ITfsRequestChannelWrapper) src).r_Instance, src => new ITfsRequestChannelWrapper(src)); }
    }


    internal abstract class ITfsRequestChannelWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsRequestChannel where TInterface : class where TWrapper : class
    {

        void IITfsRequestChannel.Abort() { r_Instance.Abort(); }

        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginRequest(TfsMessageWrapper.GetInstance(message), callback, state);
            return nativeCallResult;
        }


        IAsyncResult IITfsRequestChannel.BeginRequest(ITfsMessage message, TimeSpan timeout, AsyncCallback callback, Object state)
        {
            IAsyncResult nativeCallResult = r_Instance.BeginRequest(TfsMessageWrapper.GetInstance(message), timeout, callback, state);
            return nativeCallResult;
        }

        ITfsClientCredentials IITfsRequestChannel.Credentials
        {
            get
            {
                TfsClientCredentials nativeCallResult = r_Instance.Credentials;
                ITfsClientCredentials wrappedCallResult = TfsClientCredentialsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        CultureInfo IITfsRequestChannel.Culture
        {
            get
            {
                CultureInfo nativeCallResult = r_Instance.Culture;
                return nativeCallResult;
            }
        }


        ITfsMessage IITfsRequestChannel.EndRequest(IAsyncResult result)
        {
            TfsMessage nativeCallResult = r_Instance.EndRequest(result);
            ITfsMessage wrappedCallResult = TfsMessageWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message)
        {
            TfsMessage nativeCallResult = r_Instance.Request(TfsMessageWrapper.GetInstance(message));
            ITfsMessage wrappedCallResult = TfsMessageWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        ITfsMessage IITfsRequestChannel.Request(ITfsMessage message, TimeSpan timeout)
        {
            TfsMessage nativeCallResult = r_Instance.Request(TfsMessageWrapper.GetInstance(message), timeout);
            ITfsMessage wrappedCallResult = TfsMessageWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Guid IITfsRequestChannel.SessionId
        {
            get
            {
                Guid nativeCallResult = r_Instance.SessionId;
                return nativeCallResult;
            }
        }

        ITfsRequestSettings IITfsRequestChannel.Settings
        {
            get
            {
                TfsRequestSettings nativeCallResult = r_Instance.Settings;
                ITfsRequestSettings wrappedCallResult = TfsRequestSettingsWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ITfsHttpClientState IITfsRequestChannel.State
        {
            get
            {
                TfsHttpClientState nativeCallResult = r_Instance.State;
                ITfsHttpClientState wrappedCallResult = TfsHttpClientStateWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Uri IITfsRequestChannel.Uri
        {
            get
            {
                Uri nativeCallResult = r_Instance.Uri;
                return nativeCallResult;
            }
        }

        protected ITfsRequestChannelWrapper(ITfsRequestChannel instance) { r_Instance = instance; }
        protected readonly ITfsRequestChannel r_Instance;
    }
}