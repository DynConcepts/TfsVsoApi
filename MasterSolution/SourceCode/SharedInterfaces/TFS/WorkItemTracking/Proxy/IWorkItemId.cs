using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IWorkItemId
    {
        void ToXml(XmlWriter writer, String element);
        Int32 Id { get; set; }
        Int64 RowVersion { get; set; }
    }
}