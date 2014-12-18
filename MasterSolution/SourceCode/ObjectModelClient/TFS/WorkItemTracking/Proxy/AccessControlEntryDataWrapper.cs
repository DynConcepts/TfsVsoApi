using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class AccessControlEntryDataWrapper : AccessControlEntryDataWrapper<IAccessControlEntryData, AccessControlEntryData>, IAccessControlEntryData
    {
        protected AccessControlEntryDataWrapper(AccessControlEntryData instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlEntryData, AccessControlEntryData>(src => ((AccessControlEntryDataWrapper) src).r_Instance, src => new AccessControlEntryDataWrapper(src)); }
    }


    internal class AccessControlEntryDataWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlEntryData where TInterface : class where TWrapper : class
    {
        Int32 IAccessControlEntryData.Allow
        {
            get
            {
                int nativeCallResult = r_Instance.Allow;
                return nativeCallResult;
            }
            set { r_Instance.Allow = value; }
        }

        Int32 IAccessControlEntryData.Deny
        {
            get
            {
                int nativeCallResult = r_Instance.Deny;
                return nativeCallResult;
            }
            set { r_Instance.Deny = value; }
        }

        IIdentityDescriptorData IAccessControlEntryData.Descriptor
        {
            get
            {
                IdentityDescriptorData nativeCallResult = r_Instance.Descriptor;
                IIdentityDescriptorData wrappedCallResult = IdentityDescriptorDataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityDescriptorData nativeValue = IdentityDescriptorDataWrapper.GetInstance(value);

                r_Instance.Descriptor = nativeValue;
            }
        }

        IAccessControlEntryExtendedData IAccessControlEntryData.ExtendedInfo
        {
            get
            {
                AccessControlEntryExtendedData nativeCallResult = r_Instance.ExtendedInfo;
                IAccessControlEntryExtendedData wrappedCallResult = AccessControlEntryExtendedDataWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                AccessControlEntryExtendedData nativeValue = AccessControlEntryExtendedDataWrapper.GetInstance(value);

                r_Instance.ExtendedInfo = nativeValue;
            }
        }

        void IAccessControlEntryData.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected AccessControlEntryDataWrapper(AccessControlEntryData instance) { r_Instance = instance; }
        protected readonly AccessControlEntryData r_Instance;
    }
}