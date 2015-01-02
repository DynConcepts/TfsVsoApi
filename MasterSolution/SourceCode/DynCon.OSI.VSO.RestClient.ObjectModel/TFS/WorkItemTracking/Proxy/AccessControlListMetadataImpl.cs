using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class AccessControlListMetadataImpl.
    /// </summary>
    internal class AccessControlListMetadataImpl : IAccessControlListMetadata
    {
        /// <summary>
        ///     Gets or sets the full selection permission.
        /// </summary>
        /// <value>The full selection permission.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IAccessControlListMetadata.FullSelectionPermission { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the irrevocable admin permissions.
        /// </summary>
        /// <value>The irrevocable admin permissions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String[] IAccessControlListMetadata.IrrevocableAdminPermissions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the object class identifier.
        /// </summary>
        /// <value>The object class identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IAccessControlListMetadata.ObjectClassId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the permission descriptions.
        /// </summary>
        /// <value>The permission descriptions.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String[] IAccessControlListMetadata.PermissionDescriptions { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the permission display strings.
        /// </summary>
        /// <value>The permission display strings.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String[] IAccessControlListMetadata.PermissionDisplayStrings { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the permission names.
        /// </summary>
        /// <value>The permission names.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String[] IAccessControlListMetadata.PermissionNames { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the permission requirements.
        /// </summary>
        /// <value>The permission requirements.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IRequiredPermissions[] IAccessControlListMetadata.PermissionRequirements { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IAccessControlListMetadata.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}