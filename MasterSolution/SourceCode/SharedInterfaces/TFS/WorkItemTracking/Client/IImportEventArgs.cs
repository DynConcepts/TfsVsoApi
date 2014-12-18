namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IImportEventArgs
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IImportSeverity Severity  { get;   }
    System.String Message  { get;   }
    System.Exception Exception  { get;   }
  }
}
