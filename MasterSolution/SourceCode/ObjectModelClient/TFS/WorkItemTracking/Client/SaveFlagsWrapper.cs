using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal static class SaveFlagsWrapper
    {
        public static SaveFlags GetInstance(ISaveFlags src) { return default(SaveFlags); }

        public static SaveFlags[] GetInstance(ISaveFlags[] src) { return null; }
        public static ISaveFlags GetWrapper(SaveFlags src) { return default(ISaveFlags); }
        public static ISaveFlags[] GetWrapper(SaveFlags[] src) { return null; }
    }
}