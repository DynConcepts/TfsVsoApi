using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class AccessControlEntryImpl.
    /// </summary>
    internal class AccessControlEntryImpl : IAccessControlEntry
    {
        /// <summary>
        ///     Gets or sets the allow.
        /// </summary>
        /// <value>The allow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntry.Allow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the deny.
        /// </summary>
        /// <value>The deny.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntry.Deny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityDescriptor IAccessControlEntry.Descriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the extended information.
        /// </summary>
        /// <value>The extended information.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IAceExtendedInformation IAccessControlEntry.ExtendedInfo { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is empty.
        /// </summary>
        /// <value>The is empty.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IAccessControlEntry.IsEmpty { get { throw new ToBeImplementedException(); } }
    }
}