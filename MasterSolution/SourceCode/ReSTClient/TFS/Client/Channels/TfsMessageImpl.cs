using System;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class TfsMessageImpl : ITfsMessage
    {
        String ITfsMessage.Action { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITfsMessage.Close() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Exception ITfsMessage.CreateException() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        XmlDictionaryReader ITfsMessage.GetBodyReader() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Collection<ITfsMessageHeader> ITfsMessage.Headers { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITfsMessage.IsEmpty { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Boolean ITfsMessage.IsFault { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        Uri ITfsMessage.To { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        void ITfsMessage.WriteBodyContents(XmlDictionaryWriter writer) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
    }
}