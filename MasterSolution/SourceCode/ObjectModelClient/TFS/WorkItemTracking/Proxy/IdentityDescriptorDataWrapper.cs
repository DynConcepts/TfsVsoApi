using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class IdentityDescriptorDataWrapper : IdentityDescriptorDataWrapper<IIdentityDescriptorData, IdentityDescriptorData>, IIdentityDescriptorData
    {
        protected IdentityDescriptorDataWrapper(IdentityDescriptorData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIdentityDescriptorData, IdentityDescriptorData>(src => src == null ? null : ((IdentityDescriptorDataWrapper) src).r_Instance, src => new IdentityDescriptorDataWrapper(src)); }
    }


    internal class IdentityDescriptorDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIdentityDescriptorData where TInterface : class where TWrapper : class
    {
        String IIdentityDescriptorData.Identifier
        {
            get
            {
                string nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
            set { r_Instance.Identifier = value; }
        }

        String IIdentityDescriptorData.IdentityType
        {
            get
            {
                string nativeCallResult = r_Instance.IdentityType;
                return nativeCallResult;
            }
            set { r_Instance.IdentityType = value; }
        }

        void IIdentityDescriptorData.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected IdentityDescriptorDataWrapper(IdentityDescriptorData instance) { r_Instance = instance; }
        protected readonly IdentityDescriptorData r_Instance;
    }
}