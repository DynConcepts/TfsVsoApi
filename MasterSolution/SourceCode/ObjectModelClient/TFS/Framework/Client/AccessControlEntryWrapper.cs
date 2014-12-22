using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class AccessControlEntryWrapper : AccessControlEntryWrapper<IAccessControlEntry, AccessControlEntry>, IAccessControlEntry
    {
        protected AccessControlEntryWrapper(AccessControlEntry instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlEntry, AccessControlEntry>(src => src == null ? null : ((AccessControlEntryWrapper) src).r_Instance, src => new AccessControlEntryWrapper(src)); }
    }


    internal class AccessControlEntryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlEntry where TInterface : class where TWrapper : class
    {
        Int32 IAccessControlEntry.Allow
        {
            get
            {
                int nativeCallResult = r_Instance.Allow;
                return nativeCallResult;
            }
            set { r_Instance.Allow = value; }
        }

        Int32 IAccessControlEntry.Deny
        {
            get
            {
                int nativeCallResult = r_Instance.Deny;
                return nativeCallResult;
            }
            set { r_Instance.Deny = value; }
        }

        IIdentityDescriptor IAccessControlEntry.Descriptor
        {
            get
            {
                IdentityDescriptor nativeCallResult = r_Instance.Descriptor;
                IIdentityDescriptor wrappedCallResult = IdentityDescriptorWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                IdentityDescriptor nativeValue = IdentityDescriptorWrapper.GetInstance(value);

                r_Instance.Descriptor = nativeValue;
            }
        }

        IAceExtendedInformation IAccessControlEntry.ExtendedInfo
        {
            get
            {
                AceExtendedInformation nativeCallResult = r_Instance.ExtendedInfo;
                IAceExtendedInformation wrappedCallResult = AceExtendedInformationWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                AceExtendedInformation nativeValue = AceExtendedInformationWrapper.GetInstance(value);

                r_Instance.ExtendedInfo = nativeValue;
            }
        }

        Boolean IAccessControlEntry.IsEmpty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEmpty;
                return nativeCallResult;
            }
        }

        protected AccessControlEntryWrapper(AccessControlEntry instance) { r_Instance = instance; }
        protected readonly AccessControlEntry r_Instance;
    }
}