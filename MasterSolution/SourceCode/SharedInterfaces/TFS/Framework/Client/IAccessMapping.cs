using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IAccessMapping
    /// </summary>
    public interface IAccessMapping
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets the access point.
        /// </summary>
        /// <value>The access point.</value>
        String AccessPoint { get; }
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; }
        /// <summary>
        /// Gets the moniker.
        /// </summary>
        /// <value>The moniker.</value>
        String Moniker { get; }
    }
}