using System;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class TfsMessageImpl : ITfsMessage
    {
        String ITfsMessage.Action { get { throw new ToBeImplementedException(); } }
        void ITfsMessage.Close() { throw new ToBeImplementedException(); }
        Exception ITfsMessage.CreateException() { throw new ToBeImplementedException(); }
        XmlDictionaryReader ITfsMessage.GetBodyReader() { throw new ToBeImplementedException(); }
        Collection<ITfsMessageHeader> ITfsMessage.Headers { get { throw new ToBeImplementedException(); } }
        Boolean ITfsMessage.IsEmpty { get { throw new ToBeImplementedException(); } }
        Boolean ITfsMessage.IsFault { get { throw new ToBeImplementedException(); } }
        Uri ITfsMessage.To { get { throw new ToBeImplementedException(); } }
        void ITfsMessage.WriteBodyContents(XmlDictionaryWriter writer) { throw new ToBeImplementedException(); }
    }
}