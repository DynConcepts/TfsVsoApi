using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal struct IdRevisionPairImpl : IIdRevisionPair
    {
        Int32 IIdRevisionPair.Id { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        Int32 IIdRevisionPair.Revision { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IIdRevisionPair.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}