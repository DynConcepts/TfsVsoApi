using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IAccessControlEntry
    /// </summary>
    public interface IAccessControlEntry
    {
        /// <summary>
        /// Gets or sets the allow.
        /// </summary>
        /// <value>The allow.</value>
        Int32 Allow { get; set; }
        /// <summary>
        /// Gets or sets the deny.
        /// </summary>
        /// <value>The deny.</value>
        Int32 Deny { get; set; }
        /// <summary>
        /// Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
        IIdentityDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the extended information.
        /// </summary>
        /// <value>The extended information.</value>
        IAceExtendedInformation ExtendedInfo { get; set; }
        /// <summary>
        /// Gets the is empty.
        /// </summary>
        /// <value>The is empty.</value>
        Boolean IsEmpty { get; }
    }
}