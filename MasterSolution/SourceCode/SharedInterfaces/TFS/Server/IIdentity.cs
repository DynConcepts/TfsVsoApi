using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Server
{
    public interface IIdentity : IComparable, IITfsXmlSerializable
    {
        void ToXml(XmlWriter writer, String element);
        String AccountName { get; set; }
        Boolean Deleted { get; set; }
        String Description { get; set; }
        String DisplayName { get; set; }
        String DistinguishedName { get; set; }
        String Domain { get; set; }
        String MailAddress { get; set; }
        String[] MemberOf { get; set; }
        String[] Members { get; set; }
        Boolean SecurityGroup { get; set; }
        String Sid { get; set; }
        IApplicationGroupSpecialType SpecialType { get; set; }
        Guid TeamFoundationId { get; set; }
        IIdentityType Type { get; set; }
    }
}