namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IProjectCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList
  {
    System.Boolean Contains( System.String projectName);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject GetById( System.Int32 projectId);
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject value);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject this[System.Int32 index] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IProject this[System.String projectName] { get;   }
  }
}
