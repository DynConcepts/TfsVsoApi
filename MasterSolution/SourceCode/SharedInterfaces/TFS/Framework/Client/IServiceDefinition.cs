using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IServiceDefinition
    /// </summary>
    public interface IServiceDefinition
    {
        /// <summary>
        /// Adds the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <param name="location">The location.</param>
        void AddLocationMapping(IAccessMapping accessMapping, String location);
        /// <summary>
        /// Gets the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>ILocationMapping.</returns>
        ILocationMapping GetLocationMapping(IAccessMapping accessMapping);
        /// <summary>
        /// Removes the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>Boolean.</returns>
        Boolean RemoveLocationMapping(IAccessMapping accessMapping);
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; set; }
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Identifier { get; set; }
        /// <summary>
        /// Gets the location mappings.
        /// </summary>
        /// <value>The location mappings.</value>
        IEnumerable<ILocationMapping> LocationMappings { get; }
        /// <summary>
        /// Gets or sets the relative path.
        /// </summary>
        /// <value>The relative path.</value>
        String RelativePath { get; set; }
        /// <summary>
        /// Gets or sets the relative to setting.
        /// </summary>
        /// <value>The relative to setting.</value>
        IRelativeToSetting RelativeToSetting { get; set; }
        /// <summary>
        /// Gets or sets the type of the service.
        /// </summary>
        /// <value>The type of the service.</value>
        String ServiceType { get; set; }
        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>The type of the tool.</value>
        String ToolType { get; set; }
    }
}