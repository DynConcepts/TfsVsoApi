using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal struct MetadataTableHaveEntryWrapper : IMetadataTableHaveEntry
    {
        public static MetadataTableHaveEntry GetInstance(IMetadataTableHaveEntry src) { return default(MetadataTableHaveEntry); }
        public static MetadataTableHaveEntry[] GetInstance(IMetadataTableHaveEntry[] src) { return null; }
        public static MetadataTableHaveEntryWrapper GetWrapper(MetadataTableHaveEntry src) { return default(MetadataTableHaveEntryWrapper); }
        public static IMetadataTableHaveEntry[] GetWrapper(MetadataTableHaveEntry[] src) { return null; }

        Int64 IMetadataTableHaveEntry.RowVersion
        {
            get
            {
                long nativeCallResult = r_Instance.RowVersion;
                return nativeCallResult;
            }
            set { r_Instance.RowVersion = value; }
        }

        String IMetadataTableHaveEntry.TableName
        {
            get
            {
                string nativeCallResult = r_Instance.TableName;
                return nativeCallResult;
            }
            set { r_Instance.TableName = value; }
        }

        void IMetadataTableHaveEntry.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        private MetadataTableHaveEntryWrapper(MetadataTableHaveEntry instance) { r_Instance = instance; }
        private MetadataTableHaveEntry r_Instance;
    }
}