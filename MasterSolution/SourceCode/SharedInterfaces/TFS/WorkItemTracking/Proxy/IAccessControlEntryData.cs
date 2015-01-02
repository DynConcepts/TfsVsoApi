using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IAccessControlEntryData
    /// </summary>
    public interface IAccessControlEntryData
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the allow.
        /// </summary>
        /// <value>The allow.</value>
        Int32 Allow { get; set; }
        /// <summary>
        /// Gets or sets the deny.
        /// </summary>
        /// <value>The deny.</value>
        Int32 Deny { get; set; }
        /// <summary>
        /// Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
        IIdentityDescriptorData Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the extended information.
        /// </summary>
        /// <value>The extended information.</value>
        IAccessControlEntryExtendedData ExtendedInfo { get; set; }
    }
}