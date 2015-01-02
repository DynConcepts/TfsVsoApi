using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    /// <summary>
    /// Interface IAceExtendedInformation
    /// </summary>
    public interface IAceExtendedInformation
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets the effective allow.
        /// </summary>
        /// <value>The effective allow.</value>
        Int32 EffectiveAllow { get; }
        /// <summary>
        /// Gets the effective deny.
        /// </summary>
        /// <value>The effective deny.</value>
        Int32 EffectiveDeny { get; }
        /// <summary>
        /// Gets the inherited allow.
        /// </summary>
        /// <value>The inherited allow.</value>
        Int32 InheritedAllow { get; }
        /// <summary>
        /// Gets the inherited deny.
        /// </summary>
        /// <value>The inherited deny.</value>
        Int32 InheritedDeny { get; }
    }
}