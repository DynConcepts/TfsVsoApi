using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IAccessControlListMetadata
    /// </summary>
    public interface IAccessControlListMetadata
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the full selection permission.
        /// </summary>
        /// <value>The full selection permission.</value>
        String FullSelectionPermission { get; set; }
        /// <summary>
        /// Gets or sets the irrevocable admin permissions.
        /// </summary>
        /// <value>The irrevocable admin permissions.</value>
        String[] IrrevocableAdminPermissions { get; set; }
        /// <summary>
        /// Gets or sets the object class identifier.
        /// </summary>
        /// <value>The object class identifier.</value>
        String ObjectClassId { get; set; }
        /// <summary>
        /// Gets or sets the permission descriptions.
        /// </summary>
        /// <value>The permission descriptions.</value>
        String[] PermissionDescriptions { get; set; }
        /// <summary>
        /// Gets or sets the permission display strings.
        /// </summary>
        /// <value>The permission display strings.</value>
        String[] PermissionDisplayStrings { get; set; }
        /// <summary>
        /// Gets or sets the permission names.
        /// </summary>
        /// <value>The permission names.</value>
        String[] PermissionNames { get; set; }
        /// <summary>
        /// Gets or sets the permission requirements.
        /// </summary>
        /// <value>The permission requirements.</value>
        IRequiredPermissions[] PermissionRequirements { get; set; }
    }
}