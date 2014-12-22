using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels
{
    public interface ITfsMessageHeader
    {
        XmlDictionaryReader GetReader();
        void Write(XmlDictionaryWriter writer);
        String Name { get; }
        String Namespace { get; }
    }
}