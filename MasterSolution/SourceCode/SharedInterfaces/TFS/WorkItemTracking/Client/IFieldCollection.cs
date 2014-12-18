namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
  public interface IFieldCollection : DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.IReadOnlyList
  {
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField GetById( System.Int32 id);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField TryGetById( System.Int32 id);
    System.Boolean Contains( System.String fieldName);
    System.Boolean Contains( System.Int32 id);
    void DropCachedData();
    System.Int32 IndexOf( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField value);
    System.Boolean Contains( DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField value);
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField this[System.Int32 index] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField this[DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.ICoreField coreField] { get;   }
    DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client.IField this[System.String name] { get;   }
  }
}
