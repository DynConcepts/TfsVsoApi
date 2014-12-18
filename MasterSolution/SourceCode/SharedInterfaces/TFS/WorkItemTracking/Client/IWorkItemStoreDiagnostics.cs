namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IWorkItemStoreDiagnostics
  {
    System.Int32 RoundTripCount  { get;   }
    System.Int64 RoundTripTime  { get;   }
  }
}
