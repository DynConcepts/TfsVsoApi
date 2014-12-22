using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface IAccessMapping
    {
        void ToXml(XmlWriter writer, String element);
        String AccessPoint { get; }
        String DisplayName { get; }
        String Moniker { get; }
    }
}