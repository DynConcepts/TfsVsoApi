using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ImportEventArgsImpl : IImportEventArgs
    {
        Exception IImportEventArgs.Exception { get { throw new ToBeImplementedException(); } }
        String IImportEventArgs.Message { get { throw new ToBeImplementedException(); } }
        IImportSeverity IImportEventArgs.Severity { get { throw new ToBeImplementedException(); } }
    }
}