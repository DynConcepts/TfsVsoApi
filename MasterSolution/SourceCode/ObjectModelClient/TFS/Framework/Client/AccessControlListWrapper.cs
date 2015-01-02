using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class AccessControlListWrapper.
    /// </summary>
    internal class AccessControlListWrapper : AccessControlListWrapper<IAccessControlList, AccessControlList>, IAccessControlList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlListWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AccessControlListWrapper(AccessControlList instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlList, AccessControlList>(src => src == null ? null : ((AccessControlListWrapper) src).r_Instance, src => new AccessControlListWrapper(src)); }
    }


    /// <summary>
    /// Class AccessControlListWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AccessControlListWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlList where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the access control entries.
        /// </summary>
        /// <value>The access control entries.</value>
        IEnumerable<IAccessControlEntry> IAccessControlList.AccessControlEntries
        {
            get
            {
                IEnumerable<AccessControlEntry> nativeCallResult = r_Instance.AccessControlEntries;
                IEnumerable<IAccessControlEntry> wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the inherit permissions.
        /// </summary>
        /// <value>The inherit permissions.</value>
        Boolean IAccessControlList.InheritPermissions
        {
            get
            {
                bool nativeCallResult = r_Instance.InheritPermissions;
                return nativeCallResult;
            }
            set { r_Instance.InheritPermissions = value; }
        }

        /// <summary>
        /// Queries the access control entries.
        /// </summary>
        /// <param name="descriptors">The descriptors.</param>
        /// <returns>IEnumerable&lt;IAccessControlEntry&gt;.</returns>
        IEnumerable<IAccessControlEntry> IAccessControlList.QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors)
        {
            IEnumerable<AccessControlEntry> nativeCallResult = r_Instance.QueryAccessControlEntries(IdentityDescriptorWrapper.GetInstance(descriptors));
            IEnumerable<IAccessControlEntry> wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Queries the access control entry.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry IAccessControlList.QueryAccessControlEntry(IIdentityDescriptor descriptor)
        {
            AccessControlEntry nativeCallResult = r_Instance.QueryAccessControlEntry(IdentityDescriptorWrapper.GetInstance(descriptor));
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Removes the access control entry.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns>Boolean.</returns>
        Boolean IAccessControlList.RemoveAccessControlEntry(IIdentityDescriptor descriptor)
        {
            bool nativeCallResult = r_Instance.RemoveAccessControlEntry(IdentityDescriptorWrapper.GetInstance(descriptor));
            return nativeCallResult;
        }

        /// <summary>
        /// Removes the permissions.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="permissionsToRemove">The permissions to remove.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry IAccessControlList.RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove)
        {
            AccessControlEntry nativeCallResult = r_Instance.RemovePermissions(IdentityDescriptorWrapper.GetInstance(descriptor), permissionsToRemove);
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Sets the access control entries.
        /// </summary>
        /// <param name="accessControlEntries">The access control entries.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IEnumerable&lt;IAccessControlEntry&gt;.</returns>
        IEnumerable<IAccessControlEntry> IAccessControlList.SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge)
        {
            IEnumerable<AccessControlEntry> nativeCallResult = r_Instance.SetAccessControlEntries(AccessControlEntryWrapper.GetInstance(accessControlEntries), merge);
            IEnumerable<IAccessControlEntry> wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Sets the access control entry.
        /// </summary>
        /// <param name="accessControlEntry">The access control entry.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry IAccessControlList.SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge)
        {
            AccessControlEntry nativeCallResult = r_Instance.SetAccessControlEntry(AccessControlEntryWrapper.GetInstance(accessControlEntry), merge);
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Sets the permissions.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="allow">The allow.</param>
        /// <param name="deny">The deny.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry IAccessControlList.SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge)
        {
            AccessControlEntry nativeCallResult = r_Instance.SetPermissions(IdentityDescriptorWrapper.GetInstance(descriptor), allow, deny, merge);
            IAccessControlEntry wrappedCallResult = AccessControlEntryWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        String IAccessControlList.Token
        {
            get
            {
                string nativeCallResult = r_Instance.Token;
                return nativeCallResult;
            }
            set { r_Instance.Token = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlListWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AccessControlListWrapper(AccessControlList instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly AccessControlList r_Instance;
    }
}