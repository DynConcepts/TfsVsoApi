using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IImportEventArgs
  {
    IImportSeverity Severity  { get;   }
    String Message  { get;   }
    Exception Exception  { get;   }
  }
}
