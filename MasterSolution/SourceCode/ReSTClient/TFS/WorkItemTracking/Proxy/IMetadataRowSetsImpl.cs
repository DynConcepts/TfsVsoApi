using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Proxy
{
    internal class IMetadataRowSetsImpl : IIMetadataRowSets
    {
        Int32 IIMetadataRowSets.Count { get { throw new ToBeImplementedException(); } }
        IIRowSet IIMetadataRowSets.this[IMetadataRowSetNames name] { get { throw new ToBeImplementedException(); } }
        IIRowSet IIMetadataRowSets.this[Int32 index] { get { throw new ToBeImplementedException(); } }
    }
}