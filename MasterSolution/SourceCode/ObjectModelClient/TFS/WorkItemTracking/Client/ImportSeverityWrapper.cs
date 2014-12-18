using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class ImportSeverityWrapper
    {
        public static ImportSeverity GetInstance(IImportSeverity src) { return default(ImportSeverity); }

        public static ImportSeverity[] GetInstance(IImportSeverity[] src) { return null; }
        public static IImportSeverity GetWrapper(ImportSeverity src) { return default(IImportSeverity); }
        public static IImportSeverity[] GetWrapper(ImportSeverity[] src) { return null; }
    }
}