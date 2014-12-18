namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IRevisionCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList
  {
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision value);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IRevision this[System.Int32 index] { get;   }
  }
}
