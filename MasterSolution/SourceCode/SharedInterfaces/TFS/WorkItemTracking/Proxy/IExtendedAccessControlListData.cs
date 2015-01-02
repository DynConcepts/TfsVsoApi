using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IExtendedAccessControlListData
    /// </summary>
    public interface IExtendedAccessControlListData
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the inherit permissions.
        /// </summary>
        /// <value>The inherit permissions.</value>
        Boolean InheritPermissions { get; set; }
        /// <summary>
        /// Gets or sets the is editable.
        /// </summary>
        /// <value>The is editable.</value>
        Boolean IsEditable { get; set; }
        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        IAccessControlListMetadata[] Metadata { get; set; }
        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        /// <value>The permissions.</value>
        IAccessControlEntryData[] Permissions { get; set; }
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>The token.</value>
        String Token { get; set; }
    }
}