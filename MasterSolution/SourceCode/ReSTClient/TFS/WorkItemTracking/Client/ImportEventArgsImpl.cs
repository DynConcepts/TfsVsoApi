using System;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class ImportEventArgsImpl : IImportEventArgs
    {
        Exception IImportEventArgs.Exception { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        String IImportEventArgs.Message { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        IImportSeverity IImportEventArgs.Severity { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}