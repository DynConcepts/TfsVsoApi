using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface ILocationMapping
    /// </summary>
    public interface ILocationMapping
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets the access mapping.
        /// </summary>
        /// <value>The access mapping.</value>
        IAccessMapping AccessMapping { get; }
        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>The location.</value>
        String Location { get; }
    }
}