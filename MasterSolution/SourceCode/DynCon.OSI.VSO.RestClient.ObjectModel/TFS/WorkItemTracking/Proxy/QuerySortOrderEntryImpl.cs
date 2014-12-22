using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal struct QuerySortOrderEntryImpl : IQuerySortOrderEntry
    {
        Boolean IQuerySortOrderEntry.Ascending { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IQuerySortOrderEntry.ColumnName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IQuerySortOrderEntry.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}