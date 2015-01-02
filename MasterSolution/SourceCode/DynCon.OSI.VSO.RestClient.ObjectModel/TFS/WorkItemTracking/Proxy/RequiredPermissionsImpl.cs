using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class RequiredPermissionsImpl.
    /// </summary>
    internal class RequiredPermissionsImpl : IRequiredPermissions
    {
        /// <summary>
        ///     Gets or sets the name of the permission.
        /// </summary>
        /// <value>The name of the permission.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IRequiredPermissions.PermissionName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the required permission bits.
        /// </summary>
        /// <value>The required permission bits.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IRequiredPermissions.RequiredPermissionBits { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IRequiredPermissions.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}