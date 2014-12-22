using System;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal struct MetadataTableHaveEntryImpl : IMetadataTableHaveEntry
    {
        Int64 IMetadataTableHaveEntry.RowVersion { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        String IMetadataTableHaveEntry.TableName { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }
        void IMetadataTableHaveEntry.ToXml(XmlWriter writer, String element) { throw new ToBeImplementedException(); }
    }
}