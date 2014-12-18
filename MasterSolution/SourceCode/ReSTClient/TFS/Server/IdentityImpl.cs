using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Server
{
    internal class IdentityImpl : IIdentity, IComparable, IITfsXmlSerializable
    {
        String IIdentity.AccountName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IComparable.CompareTo(Object obj) { throw new ToBeImplementedException(); }
        Boolean IIdentity.Deleted { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentity.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentity.DisplayName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentity.DistinguishedName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentity.Domain { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentity.MailAddress { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String[] IIdentity.MemberOf { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String[] IIdentity.Members { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new ToBeImplementedException(); }
        Boolean IIdentity.SecurityGroup { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentity.Sid { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        IApplicationGroupSpecialType IIdentity.SpecialType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Guid IIdentity.TeamFoundationId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IIdentity.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
        IIdentityType IIdentity.Type { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new ToBeImplementedException(); }
    }
}