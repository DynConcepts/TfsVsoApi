using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class FieldUsagesWrapper
    {
        public static FieldUsages GetInstance(IFieldUsages src) { return default(FieldUsages); }

        public static FieldUsages[] GetInstance(IFieldUsages[] src) { return null; }
        public static IFieldUsages GetWrapper(FieldUsages src) { return default(IFieldUsages); }
        public static IFieldUsages[] GetWrapper(FieldUsages[] src) { return null; }
    }
}