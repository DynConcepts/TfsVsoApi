using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class FieldStatusWrapper
    {
        public static FieldStatus GetInstance(IFieldStatus src) { return default(FieldStatus); }

        public static FieldStatus[] GetInstance(IFieldStatus[] src) { return null; }
        public static IFieldStatus GetWrapper(FieldStatus src) { return default(IFieldStatus); }
        public static IFieldStatus[] GetWrapper(FieldStatus[] src) { return null; }
    }
}