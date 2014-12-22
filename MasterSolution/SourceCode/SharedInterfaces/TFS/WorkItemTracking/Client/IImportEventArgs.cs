using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IImportEventArgs
    {
        Exception Exception { get; }
        String Message { get; }
        IImportSeverity Severity { get; }
    }
}