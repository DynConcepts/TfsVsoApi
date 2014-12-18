using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class MetadataChangeTypesWrapper
    {
        public static MetadataChangeTypes GetInstance(IMetadataChangeTypes src) { return default(MetadataChangeTypes); }

        public static MetadataChangeTypes[] GetInstance(IMetadataChangeTypes[] src) { return null; }
        public static IMetadataChangeTypes GetWrapper(MetadataChangeTypes src) { return default(IMetadataChangeTypes); }
        public static IMetadataChangeTypes[] GetWrapper(MetadataChangeTypes[] src) { return null; }
    }
}