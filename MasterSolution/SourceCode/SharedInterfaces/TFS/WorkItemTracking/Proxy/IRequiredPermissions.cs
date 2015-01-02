using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IRequiredPermissions
    /// </summary>
    public interface IRequiredPermissions
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the name of the permission.
        /// </summary>
        /// <value>The name of the permission.</value>
        String PermissionName { get; set; }
        /// <summary>
        /// Gets or sets the required permission bits.
        /// </summary>
        /// <value>The required permission bits.</value>
        Int32 RequiredPermissionBits { get; set; }
    }
}