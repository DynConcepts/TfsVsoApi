using System;
using System.Collections.Generic;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class ServiceDefinitionImpl.
    /// </summary>
    internal class ServiceDefinitionImpl : IServiceDefinition
    {
        /// <summary>
        ///     Adds the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <param name="location">The location.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IServiceDefinition.AddLocationMapping(IAccessMapping accessMapping, String location) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IServiceDefinition.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IServiceDefinition.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>ILocationMapping.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        ILocationMapping IServiceDefinition.GetLocationMapping(IAccessMapping accessMapping) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Guid IServiceDefinition.Identifier { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the location mappings.
        /// </summary>
        /// <value>The location mappings.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IEnumerable<ILocationMapping> IServiceDefinition.LocationMappings { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the relative path.
        /// </summary>
        /// <value>The relative path.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IServiceDefinition.RelativePath { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the relative to setting.
        /// </summary>
        /// <value>The relative to setting.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IRelativeToSetting IServiceDefinition.RelativeToSetting { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Removes the location mapping.
        /// </summary>
        /// <param name="accessMapping">The access mapping.</param>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Boolean IServiceDefinition.RemoveLocationMapping(IAccessMapping accessMapping) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the type of the service.
        /// </summary>
        /// <value>The type of the service.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IServiceDefinition.ServiceType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IServiceDefinition.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the type of the tool.
        /// </summary>
        /// <value>The type of the tool.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IServiceDefinition.ToolType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
    }
}