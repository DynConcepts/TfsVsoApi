using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class IdentityDescriptorDataImpl : IIdentityDescriptorData
    {
        String IIdentityDescriptorData.Identifier { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IIdentityDescriptorData.IdentityType { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IIdentityDescriptorData.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}