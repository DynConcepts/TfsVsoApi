using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Server;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Server
{
    internal class IdentityImpl : IIdentity, IComparable, IITfsXmlSerializable
    {
        String IIdentity.AccountName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IComparable.CompareTo(Object obj) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIdentity.Deleted { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentity.Description { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentity.DisplayName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentity.DistinguishedName { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentity.Domain { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentity.MailAddress { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String[] IIdentity.MemberOf { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String[] IIdentity.Members { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IITfsXmlSerializable.ReadXml(XmlReader reader, String xmlElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Boolean IIdentity.SecurityGroup { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentity.Sid { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IApplicationGroupSpecialType IIdentity.SpecialType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Guid IIdentity.TeamFoundationId { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IIdentity.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IIdentityType IIdentity.Type { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IITfsXmlSerializable.WriteXml(XmlWriter writer, String xmlElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}