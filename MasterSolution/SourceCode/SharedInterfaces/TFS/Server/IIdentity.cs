using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Server
{
    /// <summary>
    /// Interface IIdentity
    /// </summary>
    public interface IIdentity : IComparable, IITfsXmlSerializable
    {
        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ToXml(XmlWriter writer, String element);
        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        String AccountName { get; set; }
        /// <summary>
        /// Gets or sets the deleted.
        /// </summary>
        /// <value>The deleted.</value>
        Boolean Deleted { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        String Description { get; set; }
        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the name of the distinguished.
        /// </summary>
        /// <value>The name of the distinguished.</value>
        String DistinguishedName { get; set; }
        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        String Domain { get; set; }
        /// <summary>
        /// Gets or sets the mail address.
        /// </summary>
        /// <value>The mail address.</value>
        String MailAddress { get; set; }
        /// <summary>
        /// Gets or sets the member of.
        /// </summary>
        /// <value>The member of.</value>
        String[] MemberOf { get; set; }
        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>The members.</value>
        String[] Members { get; set; }
        /// <summary>
        /// Gets or sets the security group.
        /// </summary>
        /// <value>The security group.</value>
        Boolean SecurityGroup { get; set; }
        /// <summary>
        /// Gets or sets the sid.
        /// </summary>
        /// <value>The sid.</value>
        String Sid { get; set; }
        /// <summary>
        /// Gets or sets the type of the special.
        /// </summary>
        /// <value>The type of the special.</value>
        IApplicationGroupSpecialType SpecialType { get; set; }
        /// <summary>
        /// Gets or sets the team foundation identifier.
        /// </summary>
        /// <value>The team foundation identifier.</value>
        Guid TeamFoundationId { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        IIdentityType Type { get; set; }
    }
}