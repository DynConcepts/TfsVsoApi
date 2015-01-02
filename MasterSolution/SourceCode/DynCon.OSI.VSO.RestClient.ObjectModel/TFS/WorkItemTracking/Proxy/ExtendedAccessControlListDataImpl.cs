using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class ExtendedAccessControlListDataImpl.
    /// </summary>
    internal class ExtendedAccessControlListDataImpl : IExtendedAccessControlListData
    {
        /// <summary>
        ///     Gets or sets the inherit permissions.
        /// </summary>
        /// <value>The inherit permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IExtendedAccessControlListData.InheritPermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IExtendedAccessControlListData.IsEditable { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IAccessControlListMetadata[] IExtendedAccessControlListData.Metadata { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the permissions.
        /// </summary>
        /// <value>The permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IAccessControlEntryData[] IExtendedAccessControlListData.Permissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IExtendedAccessControlListData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IExtendedAccessControlListData.Token { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}