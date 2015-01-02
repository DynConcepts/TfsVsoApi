using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class AccessMappingImpl.
    /// </summary>
    internal class AccessMappingImpl : IAccessMapping
    {
        /// <summary>
        ///     Gets the access point.
        /// </summary>
        /// <value>The access point.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IAccessMapping.AccessPoint { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IAccessMapping.DisplayName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the moniker.
        /// </summary>
        /// <value>The moniker.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        String IAccessMapping.Moniker { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IAccessMapping.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}