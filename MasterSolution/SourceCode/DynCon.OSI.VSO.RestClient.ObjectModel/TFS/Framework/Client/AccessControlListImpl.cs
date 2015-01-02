using System;
using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class AccessControlListImpl.
    /// </summary>
    internal class AccessControlListImpl : IAccessControlList
    {
        /// <summary>
        ///     Gets the access control entries.
        /// </summary>
        /// <value>The access control entries.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IAccessControlEntry> IAccessControlList.AccessControlEntries { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the inherit permissions.
        /// </summary>
        /// <value>The inherit permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IAccessControlList.InheritPermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Queries the access control entries.
        /// </summary>
        /// <param name="descriptors">The descriptors.</param>
        /// <returns>IEnumerable&lt;IAccessControlEntry&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IAccessControlEntry> IAccessControlList.QueryAccessControlEntries(IEnumerable<IIdentityDescriptor> descriptors) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Queries the access control entry.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns>IAccessControlEntry.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlEntry IAccessControlList.QueryAccessControlEntry(IIdentityDescriptor descriptor) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the access control entry.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IAccessControlList.RemoveAccessControlEntry(IIdentityDescriptor descriptor) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Removes the permissions.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="permissionsToRemove">The permissions to remove.</param>
        /// <returns>IAccessControlEntry.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlEntry IAccessControlList.RemovePermissions(IIdentityDescriptor descriptor, Int32 permissionsToRemove) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the access control entries.
        /// </summary>
        /// <param name="accessControlEntries">The access control entries.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IEnumerable&lt;IAccessControlEntry&gt;.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<IAccessControlEntry> IAccessControlList.SetAccessControlEntries(IEnumerable<IAccessControlEntry> accessControlEntries, Boolean merge) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the access control entry.
        /// </summary>
        /// <param name="accessControlEntry">The access control entry.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IAccessControlEntry.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlEntry IAccessControlList.SetAccessControlEntry(IAccessControlEntry accessControlEntry, Boolean merge) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the permissions.
        /// </summary>
        /// <param name="descriptor">The descriptor.</param>
        /// <param name="allow">The allow.</param>
        /// <param name="deny">The deny.</param>
        /// <param name="merge">The merge.</param>
        /// <returns>IAccessControlEntry.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessControlEntry IAccessControlList.SetPermissions(IIdentityDescriptor descriptor, Int32 allow, Int32 deny, Boolean merge) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IAccessControlList.Token { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}