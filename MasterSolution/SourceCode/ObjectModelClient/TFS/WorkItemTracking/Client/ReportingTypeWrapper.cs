using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class ReportingTypeWrapper
    {
        public static ReportingType GetInstance(IReportingType src) { return default(ReportingType); }

        public static ReportingType[] GetInstance(IReportingType[] src) { return null; }
        public static IReportingType GetWrapper(ReportingType src) { return default(IReportingType); }
        public static IReportingType[] GetWrapper(ReportingType[] src) { return null; }
    }
}