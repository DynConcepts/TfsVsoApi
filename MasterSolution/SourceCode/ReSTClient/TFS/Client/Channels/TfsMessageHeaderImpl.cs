using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class TfsMessageHeaderImpl : ITfsMessageHeader
    {
        XmlDictionaryReader ITfsMessageHeader.GetReader() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        String ITfsMessageHeader.Name { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String ITfsMessageHeader.Namespace { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITfsMessageHeader.Write(XmlDictionaryWriter writer) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}