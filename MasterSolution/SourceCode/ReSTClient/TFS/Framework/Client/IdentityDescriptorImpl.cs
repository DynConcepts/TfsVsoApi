using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class IdentityDescriptorImpl : IIdentityDescriptor
    {
        Object IIdentityDescriptor.Data { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentityDescriptor.Identifier { get { throw new ToBeImplementedException(); } }
        String IIdentityDescriptor.IdentityType { get { throw new ToBeImplementedException(); } }
        void IIdentityDescriptor.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}