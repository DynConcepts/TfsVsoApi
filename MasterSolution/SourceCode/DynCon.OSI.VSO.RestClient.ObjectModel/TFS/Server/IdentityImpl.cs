using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Server
{
    /// <summary>
    ///     Class IdentityImpl.
    /// </summary>
    internal class IdentityImpl : IIdentity, IComparable, IITfsXmlSerializable
    {
        /// <summary>
        ///     Gets or sets the name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.AccountName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Compares the current instance with another object of the same type and returns an integer that indicates whether
        ///     the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        ///     A value that indicates the relative order of the objects being compared. The return value has these meanings:
        ///     Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance
        ///     occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows
        ///     <paramref name="obj" /> in the sort order.
        /// </returns>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        Int32 IComparable.CompareTo(Object obj) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the deleted.
        /// </summary>
        /// <value>The deleted.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IIdentity.Deleted { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the name of the distinguished.
        /// </summary>
        /// <value>The name of the distinguished.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.DistinguishedName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.Domain { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the mail address.
        /// </summary>
        /// <value>The mail address.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.MailAddress { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the member of.
        /// </summary>
        /// <value>The member of.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String[] IIdentity.MemberOf { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String[] IIdentity.Members { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Reads the XML.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="xmlElement">The XML element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the security group.
        /// </summary>
        /// <value>The security group.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Boolean IIdentity.SecurityGroup { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the sid.
        /// </summary>
        /// <value>The sid.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        String IIdentity.Sid { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the type of the special.
        /// </summary>
        /// <value>The type of the special.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IApplicationGroupSpecialType IIdentity.SpecialType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the team foundation identifier.
        /// </summary>
        /// <value>The team foundation identifier.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        Guid IIdentity.TeamFoundationId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IIdentity.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException">
        /// </exception>
        IIdentityType IIdentity.Type { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Writes the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="xmlElement">The XML element.</param>
        /// <exception cref="DynCon.OSI.Core.Helpers.ToBeImplementedException"></exception>
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new ToBeImplementedException(); }
    }
}