using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal struct QuerySortOrderEntryWrapper : IQuerySortOrderEntry
    {
        public static QuerySortOrderEntry GetInstance(IQuerySortOrderEntry src) { return default(QuerySortOrderEntry); }
        public static QuerySortOrderEntry[] GetInstance(IQuerySortOrderEntry[] src) { return null; }
        public static QuerySortOrderEntryWrapper GetWrapper(QuerySortOrderEntry src) { return default(QuerySortOrderEntryWrapper); }
        public static IQuerySortOrderEntry[] GetWrapper(QuerySortOrderEntry[] src) { return null; }

        Boolean IQuerySortOrderEntry.Ascending
        {
            get
            {
                bool nativeCallResult = r_Instance.Ascending;
                return nativeCallResult;
            }
            set { r_Instance.Ascending = value; }
        }

        String IQuerySortOrderEntry.ColumnName
        {
            get
            {
                string nativeCallResult = r_Instance.ColumnName;
                return nativeCallResult;
            }
            set { r_Instance.ColumnName = value; }
        }

        void IQuerySortOrderEntry.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        private QuerySortOrderEntryWrapper(QuerySortOrderEntry instance) { r_Instance = instance; }
        private QuerySortOrderEntry r_Instance;
    }
}