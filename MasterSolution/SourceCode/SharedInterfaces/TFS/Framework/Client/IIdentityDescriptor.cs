using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client
{
    public interface IIdentityDescriptor
    {
        void ToXml(XmlWriter writer, String element);
        Object Data { get; set; }
        String Identifier { get; }
        String IdentityType { get; }
    }
}