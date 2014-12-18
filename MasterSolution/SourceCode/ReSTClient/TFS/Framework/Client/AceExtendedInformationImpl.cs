using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Framework.Client
{
    internal class AceExtendedInformationImpl : IAceExtendedInformation
    {
        Int32 IAceExtendedInformation.EffectiveAllow { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IAceExtendedInformation.EffectiveDeny { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IAceExtendedInformation.InheritedAllow { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Int32 IAceExtendedInformation.InheritedDeny { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void IAceExtendedInformation.ToXml(XmlWriter writer, String element) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}