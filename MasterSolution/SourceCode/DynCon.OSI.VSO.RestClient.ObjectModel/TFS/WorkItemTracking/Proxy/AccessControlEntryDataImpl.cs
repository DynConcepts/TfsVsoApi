using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    ///     Class AccessControlEntryDataImpl.
    /// </summary>
    internal class AccessControlEntryDataImpl : IAccessControlEntryData
    {
        /// <summary>
        ///     Gets or sets the allow.
        /// </summary>
        /// <value>The allow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntryData.Allow { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the deny.
        /// </summary>
        /// <value>The deny.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Int32 IAccessControlEntryData.Deny { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the descriptor.
        /// </summary>
        /// <value>The descriptor.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityDescriptorData IAccessControlEntryData.Descriptor { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the extended information.
        /// </summary>
        /// <value>The extended information.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IAccessControlEntryExtendedData IAccessControlEntryData.ExtendedInfo { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IAccessControlEntryData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}