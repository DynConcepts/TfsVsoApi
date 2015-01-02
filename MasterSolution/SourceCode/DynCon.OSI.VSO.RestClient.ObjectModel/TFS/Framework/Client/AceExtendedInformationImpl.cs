using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Framework.Client
{
    /// <summary>
    ///     Class AceExtendedInformationImpl.
    /// </summary>
    internal class AceExtendedInformationImpl : IAceExtendedInformation
    {
        /// <summary>
        ///     Gets the effective allow.
        /// </summary>
        /// <value>The effective allow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IAceExtendedInformation.EffectiveAllow { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the effective deny.
        /// </summary>
        /// <value>The effective deny.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IAceExtendedInformation.EffectiveDeny { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the inherited allow.
        /// </summary>
        /// <value>The inherited allow.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IAceExtendedInformation.InheritedAllow { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the inherited deny.
        /// </summary>
        /// <value>The inherited deny.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IAceExtendedInformation.InheritedDeny { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IAceExtendedInformation.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}