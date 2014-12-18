using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class IdentityDescriptorImpl : IIdentityDescriptor
    {
        Object IIdentityDescriptor.Data { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } set { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentityDescriptor.Identifier { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IIdentityDescriptor.IdentityType { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IIdentityDescriptor.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}