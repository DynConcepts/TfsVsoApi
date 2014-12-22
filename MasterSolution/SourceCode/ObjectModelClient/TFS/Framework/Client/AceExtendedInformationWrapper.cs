using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class AceExtendedInformationWrapper : AceExtendedInformationWrapper<IAceExtendedInformation, AceExtendedInformation>, IAceExtendedInformation
    {
        protected AceExtendedInformationWrapper(AceExtendedInformation instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAceExtendedInformation, AceExtendedInformation>(src => src == null ? null : ((AceExtendedInformationWrapper) src).r_Instance, src => new AceExtendedInformationWrapper(src)); }
    }


    internal class AceExtendedInformationWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAceExtendedInformation where TInterface : class where TWrapper : class
    {
        Int32 IAceExtendedInformation.EffectiveAllow
        {
            get
            {
                int nativeCallResult = r_Instance.EffectiveAllow;
                return nativeCallResult;
            }
        }

        Int32 IAceExtendedInformation.EffectiveDeny
        {
            get
            {
                int nativeCallResult = r_Instance.EffectiveDeny;
                return nativeCallResult;
            }
        }

        Int32 IAceExtendedInformation.InheritedAllow
        {
            get
            {
                int nativeCallResult = r_Instance.InheritedAllow;
                return nativeCallResult;
            }
        }

        Int32 IAceExtendedInformation.InheritedDeny
        {
            get
            {
                int nativeCallResult = r_Instance.InheritedDeny;
                return nativeCallResult;
            }
        }

        void IAceExtendedInformation.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected AceExtendedInformationWrapper(AceExtendedInformation instance) { r_Instance = instance; }
        protected readonly AceExtendedInformation r_Instance;
    }
}