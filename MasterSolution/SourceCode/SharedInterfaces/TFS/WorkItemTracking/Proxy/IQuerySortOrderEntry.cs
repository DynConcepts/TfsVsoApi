using System;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    public interface IQuerySortOrderEntry
    {
        void ToXml(XmlWriter writer, String element);
        Boolean Ascending { get; set; }
        String ColumnName { get; set; }
    }
}