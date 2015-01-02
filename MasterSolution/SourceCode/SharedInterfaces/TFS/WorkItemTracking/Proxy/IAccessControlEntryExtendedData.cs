using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IAccessControlEntryExtendedData
    /// </summary>
    public interface IAccessControlEntryExtendedData
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the effective allow.
        /// </summary>
        /// <value>The effective allow.</value>
        Int32 EffectiveAllow { get; set; }
        /// <summary>
        /// Gets or sets the effective deny.
        /// </summary>
        /// <value>The effective deny.</value>
        Int32 EffectiveDeny { get; set; }
        /// <summary>
        /// Gets or sets the inherited allow.
        /// </summary>
        /// <value>The inherited allow.</value>
        Int32 InheritedAllow { get; set; }
        /// <summary>
        /// Gets or sets the inherited deny.
        /// </summary>
        /// <value>The inherited deny.</value>
        Int32 InheritedDeny { get; set; }
    }
}