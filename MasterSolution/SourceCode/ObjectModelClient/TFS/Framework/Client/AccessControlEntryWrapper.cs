using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class AccessControlEntryWrapper.
    /// </summary>
    internal class AccessControlEntryWrapper : AccessControlEntryWrapper<IAccessControlEntry, AccessControlEntry>, IAccessControlEntry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlEntryWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AccessControlEntryWrapper(AccessControlEntry instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAccessControlEntry, AccessControlEntry>(src => src == null ? null : ((AccessControlEntryWrapper) src).r_Instance, src => new AccessControlEntryWrapper(src)); }
    }


    /// <summary>
    /// Class AccessControlEntryWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AccessControlEntryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAccessControlEntry where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the allow.
        /// </summary>
        /// <value>The allow.</value>
        Int32 IAccessControlEntry.Allow
        {
            get
            {
                int nativeCallResult = r_Instance.Allow;
                return nativeCallResult;
            }
            set { r_Instance.Allow = value; }
        }

        /// <summary>
        /// Gets or sets the deny.
        /// </summary>
        /// <value>The deny.</value>
        Int32 IAccessControlEntry.Deny
        {
            get
            {
                int nativeCallResult = r_Instance.Deny;
                return nativeCallResult;
            }
            set { r_Instance.Deny = value; }
        }

        /// <summary>
        /// Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
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

        /// <summary>
        /// Gets or sets the extended information.
        /// </summary>
        /// <value>The extended information.</value>
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

        /// <summary>
        /// Gets the is empty.
        /// </summary>
        /// <value>The is empty.</value>
        Boolean IAccessControlEntry.IsEmpty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEmpty;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlEntryWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AccessControlEntryWrapper(AccessControlEntry instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly AccessControlEntry r_Instance;
    }
}