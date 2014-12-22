using System;
using System.Collections.ObjectModel;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    public interface ITfsMessage
    {
        void Close();
        Exception CreateException();
        XmlDictionaryReader GetBodyReader();
        void WriteBodyContents(XmlDictionaryWriter writer);
        String Action { get; }
        Collection<ITfsMessageHeader> Headers { get; }
        Boolean IsEmpty { get; }
        Boolean IsFault { get; }
        Uri To { get; }
    }
}