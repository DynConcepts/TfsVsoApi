using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal class TfsMessageHeaderWrapper : TfsMessageHeaderWrapper<ITfsMessageHeader, TfsMessageHeader>, ITfsMessageHeader
    {
        protected TfsMessageHeaderWrapper(TfsMessageHeader instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsMessageHeader, TfsMessageHeader>(src => src==null ? null : ((TfsMessageHeaderWrapper) src).r_Instance, src => new TfsMessageHeaderWrapper(src)); }
    }


    internal abstract class TfsMessageHeaderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsMessageHeader where TInterface : class where TWrapper : class
    {

        XmlDictionaryReader ITfsMessageHeader.GetReader()
        {
            XmlDictionaryReader nativeCallResult = r_Instance.GetReader();
            return nativeCallResult;
        }

        String ITfsMessageHeader.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        String ITfsMessageHeader.Namespace
        {
            get
            {
                string nativeCallResult = r_Instance.Namespace;
                return nativeCallResult;
            }
        }

        void ITfsMessageHeader.Write(XmlDictionaryWriter writer) { r_Instance.Write(writer); }
        protected TfsMessageHeaderWrapper(TfsMessageHeader instance) { r_Instance = instance; }
        protected readonly TfsMessageHeader r_Instance;
    }
}