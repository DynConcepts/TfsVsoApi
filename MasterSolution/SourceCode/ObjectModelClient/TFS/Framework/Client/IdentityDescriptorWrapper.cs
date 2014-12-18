using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class IdentityDescriptorWrapper : IdentityDescriptorWrapper<IIdentityDescriptor, IdentityDescriptor>, IIdentityDescriptor
    {
        protected IdentityDescriptorWrapper(IdentityDescriptor instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIdentityDescriptor, IdentityDescriptor>(src => ((IdentityDescriptorWrapper) src).r_Instance, src => new IdentityDescriptorWrapper(src)); }
    }


    internal class IdentityDescriptorWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIdentityDescriptor where TInterface : class where TWrapper : class
    {
        Object IIdentityDescriptor.Data
        {
            get
            {
                object nativeCallResult = r_Instance.Data;
                return nativeCallResult;
            }
            set { r_Instance.Data = value; }
        }

        String IIdentityDescriptor.Identifier
        {
            get
            {
                string nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
        }

        String IIdentityDescriptor.IdentityType
        {
            get
            {
                string nativeCallResult = r_Instance.IdentityType;
                return nativeCallResult;
            }
        }

        void IIdentityDescriptor.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected IdentityDescriptorWrapper(IdentityDescriptor instance) { r_Instance = instance; }
        protected readonly IdentityDescriptor r_Instance;
    }
}