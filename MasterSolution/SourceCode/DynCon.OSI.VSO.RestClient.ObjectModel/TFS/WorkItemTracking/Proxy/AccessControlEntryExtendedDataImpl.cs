using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class AccessControlEntryExtendedDataImpl.
    /// </summary>
    internal class AccessControlEntryExtendedDataImpl : IAccessControlEntryExtendedData
    {
        /// <summary>
        ///     Gets or sets the effective allow.
        /// </summary>
        /// <value>The effective allow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntryExtendedData.EffectiveAllow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the effective deny.
        /// </summary>
        /// <value>The effective deny.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntryExtendedData.EffectiveDeny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the inherited allow.
        /// </summary>
        /// <value>The inherited allow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntryExtendedData.InheritedAllow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the inherited deny.
        /// </summary>
        /// <value>The inherited deny.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntryExtendedData.InheritedDeny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IAccessControlEntryExtendedData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}