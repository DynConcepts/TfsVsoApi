namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IReportingAttributes
  {
    System.String Name  { get;   }
    System.String ReferenceName  { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IReportingType Type  { get;   }
  }
}
