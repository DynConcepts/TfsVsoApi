using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class FieldTypeWrapper
    {
        public static FieldType GetInstance(IFieldType src) { return default(FieldType); }

        public static FieldType[] GetInstance(IFieldType[] src) { return null; }
        public static IFieldType GetWrapper(FieldType src) { return default(IFieldType); }
        public static IFieldType[] GetWrapper(FieldType[] src) { return null; }
    }
}