using System;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IAccessControlList
    /// </summary>
    public interface IAccessControlList
    {
        /// <summary>
        /// Queries the access control entries.
        /// </summary>
        /// <param name="descriptors">The descriptors.</param>
        /// <returns>IEnumerable&lt;IAccessControlEntry&gt;.</returns>
        IEnumerable<IAccessControlEntry> QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors);
        /// <summary>
        /// Queries the access control entry.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry QueryAccessControlEntry(IIdentityDescriptor descriptor);
        /// <summary>
        /// Removes the access control entry.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns>Boolean.</returns>
        Boolean RemoveAccessControlEntry(IIdentityDescriptor descriptor);
        /// <summary>
        /// Removes the permissions.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="permissionsToRemove">The permissions to remove.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove);
        /// <summary>
        /// Sets the access control entries.
        /// </summary>
        /// <param name="accessControlEntries">The access control entries.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IEnumerable&lt;IAccessControlEntry&gt;.</returns>
        IEnumerable<IAccessControlEntry> SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge);
        /// <summary>
        /// Sets the access control entry.
        /// </summary>
        /// <param name="accessControlEntry">The access control entry.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge);
        /// <summary>
        /// Sets the permissions.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="allow">The allow.</param>
        /// <param name="deny">The deny.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IAccessControlEntry.</returns>
        IAccessControlEntry SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge);
        /// <summary>
        /// Gets the access control entries.
        /// </summary>
        /// <value>The access control entries.</value>
        IEnumerable<IAccessControlEntry> AccessControlEntries { get; }
        /// <summary>
        /// Gets or sets the inherit permissions.
        /// </summary>
        /// <value>The inherit permissions.</value>
        Boolean InheritPermissions { get; set; }
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        String Token { get; set; }
    }
}