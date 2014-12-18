using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal class AccessControlListWrapper : AccessControlListWrapper<IAccessControlList, AccessControlList>, IAccessControlList
    {
        protected AccessControlListWrapper(AccessControlList instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlList, AccessControlList>(src => src==null ? null : ((AccessControlListWrapper) src).r_Instance, src => new AccessControlListWrapper(src)); }
    }


    internal class AccessControlListWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlList where TInterface : class where TWrapper : class
    {

        IEnumerable<IAccessControlEntry> IAccessControlList.AccessControlEntries
        {
            get
            {
                IEnumerable<AccessControlEntry> nativeCallResult = r_Instance.AccessControlEntries;
                IEnumerable<IAccessControlEntry> wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Boolean IAccessControlList.InheritPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.InheritPermissions;
                return nativeCallResult;
            }
            set { r_Instance.InheritPermissions = value; }
        }

        IEnumerable<IAccessControlEntry> IAccessControlList.QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors)
        {
            IEnumerable<AccessControlEntry> nativeCallResult = r_Instance.QueryAccessControlEntries(IdentityDescriptorWrapper.GetInstance(descriptors));
            IEnumerable<IAccessControlEntry> wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IAccessControlEntry IAccessControlList.QueryAccessControlEntry(IIdentityDescriptor descriptor)
        {
            AccessControlEntry nativeCallResult = r_Instance.QueryAccessControlEntry(IdentityDescriptorWrapper.GetInstance(descriptor));
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Boolean IAccessControlList.RemoveAccessControlEntry(IIdentityDescriptor descriptor)
        {
            bool nativeCallResult = r_Instance.RemoveAccessControlEntry(IdentityDescriptorWrapper.GetInstance(descriptor));
            return nativeCallResult;
        }

        IAccessControlEntry IAccessControlList.RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove)
        {
            AccessControlEntry nativeCallResult = r_Instance.RemovePermissions(IdentityDescriptorWrapper.GetInstance(descriptor), permissionsToRemove);
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }




        IEnumerable<IAccessControlEntry> IAccessControlList.SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge)
        {
            IEnumerable<AccessControlEntry> nativeCallResult = r_Instance.SetAccessControlEntries(AccessControlEntryWrapper.GetInstance(accessControlEntries), merge);
            IEnumerable<IAccessControlEntry> wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IAccessControlEntry IAccessControlList.SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge)
        {
            AccessControlEntry nativeCallResult = r_Instance.SetAccessControlEntry(AccessControlEntryWrapper.GetInstance(accessControlEntry), merge);
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        IAccessControlEntry IAccessControlList.SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge)
        {
            AccessControlEntry nativeCallResult = r_Instance.SetPermissions(IdentityDescriptorWrapper.GetInstance(descriptor), allow, deny, merge);
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }



        String IAccessControlList.Token
        {
            get
            {
                string nativeCallResult = r_Instance.Token;
                return nativeCallResult;
            }
            set { r_Instance.Token = value; }
        }

        protected AccessControlListWrapper(AccessControlList instance) { r_Instance = instance; }
        protected readonly AccessControlList r_Instance;
    }
}