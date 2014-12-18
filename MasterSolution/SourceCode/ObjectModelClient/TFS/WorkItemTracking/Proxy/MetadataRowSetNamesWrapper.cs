using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace  DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal static class MetadataRowSetNamesWrapper
    {
        public static MetadataRowSetNames GetInstance(IMetadataRowSetNames src) { return default(MetadataRowSetNames); }

        public static MetadataRowSetNames[] GetInstance(IMetadataRowSetNames[] src) { return null; }
        public static IMetadataRowSetNames GetWrapper(MetadataRowSetNames src) { return default(IMetadataRowSetNames); }
        public static IMetadataRowSetNames[] GetWrapper(MetadataRowSetNames[] src) { return null; }
    }
}