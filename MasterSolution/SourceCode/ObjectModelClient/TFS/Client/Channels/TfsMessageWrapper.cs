using System;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal class TfsMessageWrapper : TfsMessageWrapper<ITfsMessage, TfsMessage>, ITfsMessage
    {
        protected TfsMessageWrapper(TfsMessage instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsMessage, TfsMessage>(src => src==null ? null : ((TfsMessageWrapper) src).r_Instance, src => new TfsMessageWrapper(src)); }
    }


    internal class TfsMessageWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsMessage where TInterface : class where TWrapper : class
    {

        String ITfsMessage.Action
        {
            get
            {
                string nativeCallResult = r_Instance.Action;
                return nativeCallResult;
            }
        }

        void ITfsMessage.Close() { r_Instance.Close(); }

        Exception ITfsMessage.CreateException()
        {
            Exception nativeCallResult = r_Instance.CreateException();
            return nativeCallResult;
        }


        XmlDictionaryReader ITfsMessage.GetBodyReader()
        {
            XmlDictionaryReader nativeCallResult = r_Instance.GetBodyReader();
            return nativeCallResult;
        }



        Collection<ITfsMessageHeader> ITfsMessage.Headers
        {
            get
            {
                Collection<TfsMessageHeader> nativeCallResult = r_Instance.Headers;
                Collection<ITfsMessageHeader> wrappedCallResult = TfsMessageHeaderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean ITfsMessage.IsEmpty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEmpty;
                return nativeCallResult;
            }
        }

        Boolean ITfsMessage.IsFault
        {
            get
            {
                bool nativeCallResult = r_Instance.IsFault;
                return nativeCallResult;
            }
        }

        Uri ITfsMessage.To
        {
            get
            {
                Uri nativeCallResult = r_Instance.To;
                return nativeCallResult;
            }
        }

        void ITfsMessage.WriteBodyContents(XmlDictionaryWriter writer) { r_Instance.WriteBodyContents(writer); }
        protected TfsMessageWrapper(TfsMessage instance) { r_Instance = instance; }
        protected readonly TfsMessage r_Instance;
    }
}