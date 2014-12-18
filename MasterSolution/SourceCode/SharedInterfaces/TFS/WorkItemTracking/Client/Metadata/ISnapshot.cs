namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.Metadata
{
  public interface ISnapshot
  {
    System.Collections.Generic.Dictionary<System.Int32,System.Int32> LoadFieldIdsByWorkItemType( System.Int32 typeId);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IWorkItemStore Store  { get;   }
  }
}
