using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class LocationMappingImpl.
    /// </summary>
    internal class LocationMappingImpl : ILocationMapping
    {
        /// <summary>
        ///     Gets the access mapping.
        /// </summary>
        /// <value>The access mapping.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        IAccessMapping ILocationMapping.AccessMapping { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the location.
        /// </summary>
        /// <value>The location.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String ILocationMapping.Location { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void ILocationMapping.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}