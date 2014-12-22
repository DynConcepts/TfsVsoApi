using System;
using System.Xml.Serialization;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IRowSetColumn : IXmlSerializable
    {
        String Name { get; }
    }
}