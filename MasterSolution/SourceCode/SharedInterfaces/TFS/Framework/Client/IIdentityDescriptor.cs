using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IIdentityDescriptor
    /// </summary>
    public interface IIdentityDescriptor
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        Object Data { get; set; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        String Identifier { get; }
        /// <summary>
        /// Gets the type of the identity.
        /// </summary>
        /// <value>The type of the identity.</value>
        String IdentityType { get; }
    }
}