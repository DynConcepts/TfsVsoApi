using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IIdentityDescriptorData
    /// </summary>
    public interface IIdentityDescriptorData
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        String Identifier { get; set; }
        /// <summary>
        /// Gets or sets the type of the identity.
        /// </summary>
        /// <value>The type of the identity.</value>
        String IdentityType { get; set; }
    }
}